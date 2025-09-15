using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class CRTPostEffectAnimated : MonoBehaviour
{
    [SerializeField] Material crtMaterial;

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if(crtMaterial != null)
        {
            // 시간 전달
            crtMaterial.SetFloat("_Time", Time.time);
            Graphics.Blit(src, dest, crtMaterial);
        }
        else
        {
            Graphics.Blit(src, dest);
        }
    }
}
