/*
{
	"CREDIT": "by VIDVOX",
	"ISFVSN": "2",
	"CATEGORIES": [
		"Geometry Adjustment", "Stylize"
	],
	"INPUTS": [
		{
			"NAME": "inputImage",
			"TYPE": "image"
		},
		{
			"NAME": "magnitude",
			"TYPE": "float",
			"MIN": 0.0,
			"MAX": 2.0,
			"DEFAULT": 0.0
		},
		{
			"NAME": "intensity",
			"TYPE": "float",
			"MIN": 0.0,
			"MAX": 10.0,
			"DEFAULT": 1.0
		}
	]
}
*/


const float pi = 3.14159265359;


float rand(vec2 co) {
	return fract(sin(dot(co.xy, vec2(12.9898,78.233))) * 43758.5453);
}

void main(void) {
	float offset = 0.1 * magnitude;
	vec2 uv = gl_FragCoord.xy / RENDERSIZE.xy;
	float rotation = intensity * 2.0 * pi * rand(vec2(magnitude, TIME));
	float yOffset = offset * sin(TIME * 1.0 * cos(TIME * intensity) + rotation) * rand(vec2(magnitude, TIME));
	float xOffset = offset * cos(TIME * 1.0 * cos(TIME * intensity) + rotation) * rand(vec2(1.0-magnitude, TIME));;
	
	float zoom = 1.0 + offset;

	uv = (uv - 0.5) / zoom + 0.5;

	uv.y += yOffset;
	uv.x += xOffset;

	gl_FragColor = IMG_NORM_PIXEL(inputImage, uv);
}