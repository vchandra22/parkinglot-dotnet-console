namespace ParkingSystem.Models
{
    public class Vehicle
    {
        public string RegistrationNumber { get; }
        public string Colour { get; }
        public string Type { get; }

        public Vehicle(string registrationNumber, string colour, string type)
        {
            RegistrationNumber = registrationNumber;
            Colour = colour;
            Type = type;
        }

        public bool IsOodPlate()
        {
            var numberPart = ExtractNumericPart();
            if (numberPart.HasValue)
            {
                return numberPart.Value % 2 != 0;
            }
            return false;
        }

        public bool IsEventPlate()
        {
            var numberPart = ExtractNumericPart();
            if (numberPart.HasValue)
            {
                return numberPart.Value % 2 == 0;
            }
            return false;
        }

        private int? ExtractNumericPart()
        {
            var parts = RegistrationNumber.Split('-');
            if (parts.Length > 1 && int.TryParse(parts[1], out int number))
            {
                return number;
            }
            return null;
        }
    }
}
