Shader "Hidden/Test/SimpleImageEffect"
{
    Properties
    {
        _MainTex("", 2D) = "white"{}
    }

    CGINCLUDE

    #include "UnityCG.cginc"

    sampler2D _MainTex;

    fixed4 frag(v2f_img i) : SV_Target
    {
        fixed4 source = tex2D(_MainTex, i.uv);
        return 1 - source;
    }

    ENDCG

    SubShader
    {
        Cull Off ZWrite Off ZTest Always
        Pass
        {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            #pragma target 3.0
            ENDCG
        }
    }
}
