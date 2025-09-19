#version 400

in vec2 uv;                  // Input from vertex shader: position of fragment on quad [-1,1]
out vec4 fragColor;          // Output color

uniform samplerCube cubeMap; // Cubemap texture (environment)
//uniform float fov = 220.0;   // Horizontal field of view
uniform float height = 1.0;  // Cylinder height (full height, replaces hardcoded 0.5)
uniform float angleStart = -110; 
uniform float angleEnd = 110; 

void main()
{
    // Convert uv from [-1,1] to [0,1] for easier mapping
    float u = uv.x * 0.5 + 0.5;         // controls the horizontal angle
    float v = uv.y * 0.5 + 0.5;         // controls the vertical position along the cylinder

    // Map u coordinate to the slice's angular range
    float thetaDeg = mix(angleStart, angleEnd, u);
    float theta = radians(thetaDeg); // Convert angle to radians

    // Compute lateral XZ direction of the ray in world space with forward along -Z 
    vec3 dir = normalize(vec3(sin(theta), 0.0, -cos(theta)));

    // Map vertical position into cylinder height [-height/2, +height/2]
    dir.y = (v - 0.5) * height;

    // Clamp vertical coordinate so it stays inside cylinder
    dir.y = clamp(dir.y, -height/2.0, height/2.0);

    // Sample the cubemap texture
    fragColor = texture(cubeMap, dir);
}