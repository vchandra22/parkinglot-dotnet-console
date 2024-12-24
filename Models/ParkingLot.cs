using System;
using System.Collections.Generic;
using System.Linq;
using ParkingSystem.Models; // Tambahkan ini agar bisa akses Vehicle

namespace ParkingSystem.Models
{
    public class ParkingLot
    {
        private readonly int _capacity;
        private readonly Dictionary<int, Vehicle> _slots;
        
        public ParkingLot(int capacity)
        {
            _capacity = capacity;
            _slots = new Dictionary<int, Vehicle>(capacity);
        }
        
        public void Park(Vehicle vehicle)
        {
            if (_slots.Count < _capacity)
            {
                int slot = Enumerable.Range(1, _capacity).First(s => !_slots.ContainsKey(s));
                _slots[slot] = vehicle;
                Console.WriteLine($"Allocated slot number: {slot}");
            }
            else
            {
                Console.WriteLine("Sorry, parking lot is full");
            }
        }
        
        public void Leave(int slot)
        {
            if (_slots.ContainsKey(slot))
            {
                _slots.Remove(slot);
                Console.WriteLine($"Slot number {slot} is free");
            }
            else
            {
                Console.WriteLine("Slot not found");
            }
        }
        
        public void Status()
        {
            Console.WriteLine("Slot\tNo.\t\tType\tRegistration No\t\tColour");
            int no = 1;
            foreach (var slot in _slots.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{slot.Key}\t{no++}\t\t{slot.Value.Type}\t{slot.Value.RegistrationNumber}\t\t{slot.Value.Colour}");
            }
        }
        
        public int CountByType(string type) => _slots.Values.Count(v => v.Type.Equals(type, StringComparison.OrdinalIgnoreCase));

        public IEnumerable<string> GetRegistrationByColour(string colour) => 
            _slots.Values.Where(v => v.Colour.Equals(colour, StringComparison.OrdinalIgnoreCase))
                .Select(v => v.RegistrationNumber);
        
        public IEnumerable<int> GetSlotsByColour(string colour) => 
            _slots.Where(v => v.Value.Colour.Equals(colour, StringComparison.OrdinalIgnoreCase))
                .Select(v => v.Key);
        
        public int? GetSlotByRegistration(string registration)
        {
            var result = _slots.FirstOrDefault(v => v.Value.RegistrationNumber == registration);
            return result.Key > 0 ? result.Key : (int?)null;
        }

        public IEnumerable<string> GetRegistrationByPlateType(string plateType)
        {
            if (plateType.Equals("ood_plate", StringComparison.OrdinalIgnoreCase))
            {
                return _slots.Values.Where(v => v.IsOodPlate()).Select(v => v.RegistrationNumber);
            }
            else if (plateType.Equals("event_plate", StringComparison.OrdinalIgnoreCase))
            {
                return _slots.Values.Where(v => v.IsEventPlate()).Select(v => v.RegistrationNumber);
            }
            return new List<string>();
        }
    }
}
