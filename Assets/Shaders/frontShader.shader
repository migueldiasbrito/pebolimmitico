Shader "Custom/frontShader"
{
    Properties
    {

        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags {"Queue" = "Transparent" "RenderType"="Transparent" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Lambert NoLighting alpha 

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

   


        void surf (Input IN, inout SurfaceOutput o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
      
            if(c.w !=0){
                o.Albedo = c;
                o.Alpha = 1;
                o.Emission = c;
            } 
            else{
               o.Alpha =0;
               o.Emission = 0;
            }
        
        
        }
        ENDCG
    }
    FallBack "Diffuse"
}
