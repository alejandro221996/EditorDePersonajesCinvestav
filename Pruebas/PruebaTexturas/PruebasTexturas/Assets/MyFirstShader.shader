﻿Shader "Custom/My First Shader" {
    SubShader{
        Pass {
        CGPROGRAM
        #pragma vertex MyVertexProgram
            #pragma fragment MyFragmentProgram
        ENDCG
        }
    }
}