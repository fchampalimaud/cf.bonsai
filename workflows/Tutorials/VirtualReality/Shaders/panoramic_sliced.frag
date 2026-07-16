#version 400

in vec2 uv;               // UV coordinates passed from vertex shader
out vec4 fragColor;       // Output color of the fragment

uniform samplerCube cubeMap; // The cubemap texture containing the environment
uniform int sliceIndex = 2;  // Determines which horizontal slice to render: 0=left, 1=front, 2=right
uniform float maxY = 0.5;    // Maximum vertical half-height of the cylindrical mapping

void main()
{
    // Define start and end angles of the horizontal slice in degrees
    float sliceStart;
    float sliceEnd;

    // Assign angular range based on the selected slice
    if(sliceIndex == 0) {          // left slice
        sliceStart = -110.0;
        sliceEnd   = -45.0;
    } else if(sliceIndex == 1) {   // front slice
        sliceStart = -45.0;
        sliceEnd   = 45.0;
    } else if(sliceIndex == 2) {   // right slice
        sliceStart = 45.0;
        sliceEnd   = 110.0;
    } else {                        // fallback to front
        sliceStart = -45.0;
        sliceEnd   = 45.0;
    }

    // Normalize uv coordinates from [-1,1] to [0,1]
    float u = uv.x * 0.5 + 0.5;
    float v = uv.y * 0.5 + 0.5;

    // Map u coordinate to the slice's angular range
    float thetaDeg = mix(sliceStart, sliceEnd, u);
    float theta = radians(thetaDeg); // Convert angle to radians

    // Compute lateral direction vector in XZ plane with forward along -Z 
    vec3 dir = normalize(vec3(sin(theta), 0.0, -cos(theta)));

    // Map vertical coordinate v to Y axis within [-maxY, maxY]
    float y = (v - 0.5) * 2.0 * maxY;
    dir.y = clamp(y, -maxY, maxY);

    // Sample the cubemap in the computed direction
    fragColor = texture(cubeMap, dir);
}