Shader "Custom/CRTFullScreenAnimated"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _ScanlineIntensity ("Scanline Intensity", Range(0,1)) = 0.2
        _RGBOffset ("RGB Offset", Range(0,0.02)) = 0.005
        _Distortion ("Screen Distortion", Range(0,0.05)) = 0.01
        _ScanlineSpeed ("Scanline Speed", Range(0,10)) = 1
        _RGBSpeed ("RGB Speed", Range(0,10)) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" "Queue"="Transparent" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float _ScanlineIntensity;
            float _RGBOffset;
            float _Distortion;
            float _ScanlineSpeed;
            float _RGBSpeed;
            float _Time;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 uv = i.uv;

                // 화면 중앙 기준으로 약간의 왜곡
                uv.x += sin(uv.y * 30.0 + _Time * 0.5) * _Distortion;
                uv.y += cos(uv.x * 30.0 + _Time * 0.5) * _Distortion;

                // RGB 채널 오프셋 애니메이션
                float rgbOffsetAnim = _RGBOffset * sin(_Time * _RGBSpeed);
                fixed r = tex2D(_MainTex, uv + float2(rgbOffsetAnim,0)).r;
                fixed g = tex2D(_MainTex, uv).g;
                fixed b = tex2D(_MainTex, uv - float2(rgbOffsetAnim,0)).b;

                fixed4 col = fixed4(r,g,b,1);

                // 스캔라인 애니메이션
                col.rgb *= 1.0 - _ScanlineIntensity * sin(uv.y * 800 + _Time * _ScanlineSpeed);

                return col;
            }
            ENDCG
        }
    }
}
