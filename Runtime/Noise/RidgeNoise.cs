namespace UnityEditor.TerrainTools
{
    /// <summary>
    /// A NoiseType implementation for Ridge noise.
    /// </summary>
    [System.Serializable]
    internal class RidgeNoise : NoiseType<RidgeNoise>
    {
        private static NoiseTypeDescriptor desc = new NoiseTypeDescriptor()
        {
            name = "Ridge",
            outputDir = "NoiseLib",
            sourcePath = "Implementation/RidgeImpl",
            supportedDimensions = NoiseDimensionFlags._1D | NoiseDimensionFlags._2D | NoiseDimensionFlags._3D,
            inputStructDefinition = null
        };

        public override NoiseTypeDescriptor GetDescription() => desc;
    }
}