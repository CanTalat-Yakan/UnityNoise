using UnityEngine;

namespace UnityEditor.TerrainTools
{
    internal class NoiseBlitShaderGenerator : NoiseShaderGenerator<NoiseBlitShaderGenerator>
    {
        private static ShaderGeneratorDescriptor m_desc = new ShaderGeneratorDescriptor()
        {
            name = "NoiseBlit",
            shaderCategory = "Hidden/TerrainTools/Noise/NoiseBlit",
            outputDir = "Generated/",
            templatePath = "Templates/Blit"
        };

        public override ShaderGeneratorDescriptor GetDescription() => m_desc;
    }
}