in vec3 in_Vertex;
in vec2 in_TexCoord0;

uniform mat4 modelViewProjectionMatrix;
uniform mat4 textureMatrix;

out vec2 isf_FragNormCoord;
out vec2 mm_SurfaceCoord;

void main()
{
    isf_FragNormCoord = (textureMatrix*vec4(in_TexCoord0,0,1)).xy;
    mm_SurfaceCoord = in_TexCoord0;
    gl_Position = modelViewProjectionMatrix * vec4(in_Vertex.xyz,1);
    #ifdef IS_MATERIAL
        materialVsFunc(isf_FragNormCoord);
    #endif
}
