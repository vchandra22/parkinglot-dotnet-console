using System;
using ParkingSystem.Models;

namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = null;
            string input;

            while ((input = Console.ReadLine()) != "exit")
            {
                var command = input.Split(' ');

                switch (command[0])
                {
                    case "create_parking_lot":
                        parkingLot = new ParkingLot(int.Parse(command[1]));
                        Console.WriteLine($"Created a parking lot with {command[1]} slots");
                        break;
                    case "park":
                        parkingLot?.Park(new Vehicle(command[1], command[2], command[3]));
                        break;
                    case "leave":
                        parkingLot?.Leave(int.Parse(command[1]));
                        break;
                    case "status":
                        parkingLot?.Status();
                        break;
                    case "type_of_vehicles":
                        Console.WriteLine(parkingLot?.CountByType(command[1]));
                        break;
                    case "registration_numbers_for_vehicles_with_ood_plate":
                        Console.WriteLine(string.Join(", ", parkingLot?.GetRegistrationByPlateType("ood_plate") ?? new List<string>()));
                        break;
                    case "registration_numbers_for_vehicles_with_event_plate":
                        Console.WriteLine(string.Join(", ", parkingLot?.GetRegistrationByPlateType("event_plate") ?? new List<string>()));
                        break;
                    case "registration_numbers_for_vehicles_with_colour":
                        Console.WriteLine(string.Join(", ", parkingLot?.GetRegistrationByColour(command[1]) ?? new List<string>()));
                        break;
                    case "slot_numbers_for_vehicles_with_colour":
                        Console.WriteLine(string.Join(", ", parkingLot?.GetSlotsByColour(command[1]) ?? new List<int>()));
                        break;
                    case "slot_number_for_registration_number":
                        var slot = parkingLot?.GetSlotByRegistration(command[1]);
                        Console.WriteLine(slot.HasValue ? slot.Value.ToString() : "Not found");
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
