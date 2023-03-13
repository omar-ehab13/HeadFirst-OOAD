namespace Chapter01
{
    public class Guitar
    {
        public Guitar(string serialNumber, decimal price, GuitarSpecification guitarSpecification)
        {
            SerialNumber = serialNumber;
            Price = price;
            GuitarSpecification = guitarSpecification;
        }

        public string SerialNumber { get; }
        public decimal Price { get; set; }
        public GuitarSpecification GuitarSpecification { get; }

        public GuitarSpecification GetGuitarSpecification()
        {
            return new GuitarSpecification(this.GuitarSpecification.Builder,
                this.GuitarSpecification.Model,
                this.GuitarSpecification.GuitarType,
                this.GuitarSpecification.BackWood,
                this.GuitarSpecification.TopWood,
                this.GuitarSpecification.NumberOfStrings);
        }

        public override string ToString()
        {
            return GuitarSpecification.ToString();
        }
    }
}
