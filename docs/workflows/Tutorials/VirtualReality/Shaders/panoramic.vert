#version 400                      // Use GLSL version 4.00

layout(location = 0) in vec2 vp;  // Input vertex attribute at location 0: 
                                  // a 2D position (clip-space coords [-1,1])

out vec2 uv;                      // Output variable passed to the fragment shader

void main()
{
    uv = vp;                          // Forward the input position to fragment shader as "uv"
    gl_Position = vec4(vp, 0.0, 1.0); // Set the final clip-space position (z=0, w=1)
}