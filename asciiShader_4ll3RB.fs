/*
{
  "IMPORTED" : [

  ],
  "CATEGORIES" : [
    "Automatically Converted",
    "Shadertoy"
  ],
  "DESCRIPTION" : "",
  
  "INPUTS" : [
    {
      "TYPE" : "image",
      "NAME" : "inputImage"
    },
    
    
    
    
    {
			"NAME": "size",
			"TYPE": "float",
			"MIN": 0.0,
			"MAX": 10.0,
			"DEFAULT": 2.0
	}    
	
  ]
}
*/



#define r RENDERSIZE.xy
#define t TIME


//#define zoom 1.0

#define P(id,a,b,c,d,e,f,g,h) if( id == int(pos.y) ){ int pa = a+2*(b+2*(c+2*(d+2*(e+2*(f+2*(g+2*(h))))))); cha = floor(mod(float(pa)/pow(2.,float(pos.x)-1.),2.)); }

float gray(vec3 _i)
{
    return _i.x*0.299+_i.y*0.587+_i.z*0.114;
}

void main() {



    vec2 uv = vec2(floor(gl_FragCoord.x/8./size)*8.*size,floor(gl_FragCoord.y/12./size)*12.*size)/r;
    ivec2 pos = ivec2(mod(gl_FragCoord.x/size,8.),mod(gl_FragCoord.y/size,12.));
    vec4 tex = IMG_NORM_PIXEL(inputImage,mod(uv,1.0));
    float cha = 0.;
    
    float g = gray(tex.xyz);
    if( g < .125 )
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,0,0,0,0,0,0);
        P(9,0,0,0,0,0,0,0,0);
        P(8,0,0,0,0,0,0,0,0);
        P(7,0,0,0,0,0,0,0,0);
        P(6,0,0,0,0,0,0,0,0);
        P(5,0,0,0,0,0,0,0,0);
        P(4,0,0,0,0,0,0,0,0);
        P(3,0,0,0,0,0,0,0,0);
        P(2,0,0,0,0,0,0,0,0);
        P(1,0,0,0,0,0,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else if( g < .25 ) // .
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,0,0,0,0,0,0);
        P(9,0,0,0,0,0,0,0,0);
        P(8,0,0,0,0,0,0,0,0);
        P(7,0,0,0,0,0,0,0,0);
        P(6,0,0,0,0,0,0,0,0);
        P(5,0,0,0,0,0,0,0,0);
        P(4,0,0,0,1,1,0,0,0);
        P(3,0,0,0,1,1,0,0,0);
        P(2,0,0,0,0,0,0,0,0);
        P(1,0,0,0,0,0,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else if( g < .375 ) // ,
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,0,0,0,0,0,0);
        P(9,0,0,0,0,0,0,0,0);
        P(8,0,0,0,0,0,0,0,0);
        P(7,0,0,0,0,0,0,0,0);
        P(6,0,0,0,0,0,0,0,0);
        P(5,0,0,0,0,0,0,0,0);
        P(4,0,0,0,1,1,0,0,0);
        P(3,0,0,0,1,1,0,0,0);
        P(2,0,0,0,0,1,0,0,0);
        P(1,0,0,0,1,0,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else if( g < .5 ) // -
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,0,0,0,0,0,0);
        P(9,0,0,0,0,0,0,0,0);
        P(8,0,0,0,0,0,0,0,0);
        P(7,0,0,0,0,0,0,0,0);
        P(6,1,1,1,1,1,1,1,0);
        P(5,0,0,0,0,0,0,0,0);
        P(4,0,0,0,0,0,0,0,0);
        P(3,0,0,0,0,0,0,0,0);
        P(2,0,0,0,0,0,0,0,0);
        P(1,0,0,0,0,0,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else if(g < .625 ) // +
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,0,0,0,0,0,0);
        P(9,0,0,0,1,0,0,0,0);
        P(8,0,0,0,1,0,0,0,0);
        P(7,0,0,0,1,0,0,0,0);
        P(6,1,1,1,1,1,1,1,0);
        P(5,0,0,0,1,0,0,0,0);
        P(4,0,0,0,1,0,0,0,0);
        P(3,0,0,0,1,0,0,0,0);
        P(2,0,0,0,0,0,0,0,0);
        P(1,0,0,0,0,0,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else if(g < .75 ) // *
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,0,1,0,0,0,0);
        P(9,1,0,0,1,0,0,1,0);
        P(8,0,1,0,1,0,1,0,0);
        P(7,0,0,1,1,1,0,0,0);
        P(6,0,0,0,1,0,0,0,0);
        P(5,0,0,1,1,1,0,0,0);
        P(4,0,1,0,1,0,1,0,0);
        P(3,1,0,0,1,0,0,1,0);
        P(2,0,0,0,1,0,0,0,0);
        P(1,0,0,0,0,0,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else if(g < .875 ) // #
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,1,0,0,1,0,0);
        P(9,0,0,1,0,0,1,0,0);
        P(8,1,1,1,1,1,1,1,0);
        P(7,0,0,1,0,0,1,0,0);
        P(6,0,0,1,0,0,1,0,0);
        P(5,0,1,0,0,1,0,0,0);
        P(4,0,1,0,0,1,0,0,0);
        P(3,1,1,1,1,1,1,1,0);
        P(2,0,1,0,0,1,0,0,0);
        P(1,0,1,0,0,1,0,0,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    else // @
    {
        P(11,0,0,0,0,0,0,0,0);
        P(10,0,0,1,1,1,1,0,0);
        P(9,0,1,0,0,0,0,1,0);
        P(8,1,0,0,0,1,1,1,0);
        P(7,1,0,0,1,0,0,1,0);
        P(6,1,0,0,1,0,0,1,0);
        P(5,1,0,0,1,0,0,1,0);
        P(4,1,0,0,1,0,0,1,0);
        P(3,1,0,0,1,1,1,1,0);
        P(2,0,1,0,0,0,0,0,0);
        P(1,0,0,1,1,1,1,1,0);
        P(0,0,0,0,0,0,0,0,0);
    }
    
    vec3 col = tex.xyz/max(tex.x,max(tex.y,tex.z));
    gl_FragColor = vec4(cha*col,1.);
}
