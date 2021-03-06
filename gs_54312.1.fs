/*
{
  "CATEGORIES" : [
    "Automatically Converted",
    "GLSLSandbox"
  ],
  "INPUTS" : [

  ],
  "DESCRIPTION" : "Automatically converted from http:\/\/glslsandbox.com\/e#54312.1"
}
*/


#ifdef GL_FRAGMENT_PRECISION_HIGH
precision highp float;
#else
//precision mediump float;
#endif


vec2 wave(vec2 f, float s) {
	for(float i = 1.; i < 2.; i++)
	{
		vec2 v = f;
		v.x += -0.75/i*sin(i*f.y+TIME/(100.0/s));
		v.y += 2.35/i*cos(i*f.x+TIME/(100.0/s));
		f=v;
	}
	return f;

}

mat2 rot(float g) {
	float s = sin(g);
	float c = cos(g);
	return mat2(c, s,
				-s, c);
}

void main(void) {
	
	
	float ss = 16.0*sin(TIME*0.9);
	vec2 gg = gl_FragCoord.xy;
	gg = ceil(gg / ss) * ss;	
	
	float mx = max(RENDERSIZE.x, RENDERSIZE.y);
	vec2 uv = 16.0 * (2.0 * gg - RENDERSIZE) / mx;
	uv *= rot(sin(TIME/3.)*0.01+0.4);
	uv = wave(uv, 128.);
	uv *= rot(cos(TIME/2.)*0.04+0.5);

	gl_FragColor = 1. - smoothstep(0.1, 0.2, vec4(sin(uv.x+uv.y*3.)));
	gl_FragColor.g *=0.2+sin(TIME)*0.4;
	gl_FragColor.b *= 0.3+sin(TIME*0.33)*0.9*uv.x;
}