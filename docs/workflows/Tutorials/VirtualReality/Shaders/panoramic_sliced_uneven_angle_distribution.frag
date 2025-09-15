#version 400

in vec2 uv;               // from vertex shader
out vec4 fragColor;

uniform samplerCube cubeMap;
uniform int sliceIndex = 2;      // 0=left,1=front,2=right
uniform float maxY = 0.5;          // vertical half-height of cylinder

void main()
{
    // define slice angles in degrees
    float sliceStart;
    float sliceEnd;

    if(sliceIndex == 0) {          // left
        sliceStart = -110.0;
        sliceEnd   = -45.0;
    } else if(sliceIndex == 1) {   // front
        sliceStart = -45.0;
        sliceEnd   = 45.0;
    } else if(sliceIndex == 2) {   // right
        sliceStart = 45.0;
        sliceEnd   = 110.0;
    } else {
        sliceStart = -45.0;
        sliceEnd   = 45.0;
    }

    // normalized coords [0,1]
    float u = uv.x * 0.5 + 0.5;
    float v = uv.y * 0.5 + 0.5;

    // map u to slice range
    float thetaDeg = mix(sliceStart, sliceEnd, u);
    float theta = radians(thetaDeg);

    // lateral XZ direction
    vec3 dir = normalize(vec3(sin(theta), 0.0, cos(theta)));

    // linear vertical mapping to [-maxY,+maxY]
    float y = (v - 0.5) * 2.0 * maxY;
    dir.y = clamp(y, -maxY, maxY);

    fragColor = texture(cubeMap, dir);
}



