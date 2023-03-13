namespace Chapter01
{
    public class Inventory
    {
        private IList<Guitar> guitarList;

        public Inventory()
        {
            guitarList = new List<Guitar>();
        }

        public void AddGuitar(Guitar guitar)
        {
            guitarList.Add(guitar);
        }

        public Guitar? GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitarList)
            {
                if (serialNumber == guitar.SerialNumber)
                    return guitar;
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpecification searchGuitar)
        {
            List<Guitar> selectedGutiars = new List<Guitar>();

            foreach (var guitar in guitarList)
            {
                GuitarSpecification guitarSpec = guitar.GetGuitarSpecification();

                if (guitarSpec.IsEqual(searchGuitar))
                {
                    selectedGutiars.Add(guitar);
                }
            }
            return selectedGutiars;
        }

    }
}
