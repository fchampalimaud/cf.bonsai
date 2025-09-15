#version 400
layout(location = 0) in vec2 vp;   // fullscreen quad [-1,1]
out vec2 uv;

void main()
{
    uv = vp;                          // pass clip coords to fragment
    gl_Position = vec4(vp, 0.0, 1.0); // no transform
}
