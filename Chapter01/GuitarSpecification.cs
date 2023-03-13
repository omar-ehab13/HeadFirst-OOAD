
namespace Chapter01
{
    public class GuitarSpecification
    {
        #region Constructor
        public GuitarSpecification(Builder builder, string model, GuitarType guitarType, Wood backWood, Wood topWood, int numberOfStrings)
        {
            Builder = builder;
            Model = model;
            GuitarType = guitarType;
            BackWood = backWood;
            TopWood = topWood;
            NumberOfStrings = numberOfStrings;
        }
        #endregion

        #region Properties
        public Builder Builder { get; }
        public string Model{ get; }
        public GuitarType GuitarType{ get; }
        public Wood BackWood{ get; }
        public Wood TopWood{ get; }
        public int NumberOfStrings { get; }
        #endregion

        #region Methods
        public bool IsEqual(GuitarSpecification comparedGuitarSpec)
        {
            return Builder == comparedGuitarSpec.Builder &&
                Model == comparedGuitarSpec.Model &&
                GuitarType == comparedGuitarSpec.GuitarType &&
                BackWood == comparedGuitarSpec.BackWood &&
                TopWood == comparedGuitarSpec.TopWood &&
                NumberOfStrings == comparedGuitarSpec.NumberOfStrings;
        }

        public override string ToString()
        {
            return $"{Builder} {Model} {GuitarType} ({NumberOfStrings}-strings) guitar: \n    {BackWood} back and sides,\n    {TopWood} top.";
        }
        #endregion
    }
}
