#version 330 core
out vec4 FragColor;
in vec2 TexCoord1;
uniform sampler2D texture1;
uniform sampler2D texture2;
void main()
{
 FragColor = mix(texture(texture1, TexCoord1), texture(texture2, TexCoord1), 0.2);
}