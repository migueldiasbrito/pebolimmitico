Shader "Custom/wallsShader"
{
   Properties
    {
        _myDifuse("d Tex", 2D) ="White"{}
        _myBump("d Bump", 2D) ="bump"{}
        _mySlider("my slider", Range(0,10))=1
         _mySliderS("my Size", Range(0,10))=1
    }
    SubShader
    {

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _myDifuse;
         sampler2D _myBump;
         half _mySlider;
         half _mySliderS;


        struct Input
        {
            float2 uv_myDifuse;
            float2 uv_myBump;
        };



        void surf (Input IN, inout SurfaceOutputStandard o)
        {
        float4 green = float4(0,1,0,1);
            o.Albedo = (tex2D(_myDifuse, IN.uv_myDifuse*_mySliderS)).rgb;
            o.Normal = UnpackNormal(tex2D(_myBump, IN.uv_myBump*_mySliderS));
          //  o.Normal *= float3(_mySlider, _mySlider, 1);
          o.Normal.x *= _mySlider;
          o.Normal.y *=_mySlider;
     
        }
        ENDCG
    }
    FallBack "Diffuse"
}
