Shader "Hidden/Shader" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_ComponentColor("Component Color", Color) = (1, 1, 1, 1)
	}

	SubShader {
		Tags 
		{
			"Queue"="Transparent"
			"IgnoreProjector"="True"
			"RenderType"="Transparent"
			"PreviewType"="Plane"
		}

        Cull Off
        Lighting Off
        ZWrite Off

        Blend SrcAlpha OneMinusSrcAlpha
        Fog { Mode Off }

		Pass {
			CGPROGRAM

			#pragma vertex vert
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest
			#pragma target 2.0
			#include "UnityCG.cginc"
			#include "UnityUI.cginc"

			uniform sampler2D _MainTex;
			uniform float4 _MainTex_ST;
			uniform float4 _MainTex_TexelSize;

			float4 _ComponentColor;

			struct appdataIn {
				half4 vertex : POSITION;
				fixed2 texcoord : TEXCOORD0;
			};

			struct v2f {
				half4 pos : SV_POSITION;
				fixed2 texcoord : TEXCOORD0;
			};

			v2f vert(appdataIn v)
			{
				v2f o;
				o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
				o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
#ifdef UNITY_HALF_TEXEL_OFFSET
                o.pos.xy += (_ScreenParams.zw-1.0)*float2(-1,1);
#endif
				return o;
			}

			fixed4 frag(v2f input) : SV_Target
			{
				return _ComponentColor;
			}

			ENDCG
		}
	}
}