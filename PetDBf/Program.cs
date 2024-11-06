using PetDB;
using PetDB.Models;
using System.Diagnostics;
using System.Linq;

namespace PetDBf
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (PetDBContext db = new(true))
            {
                var dogType = new PetType { TypeName = "Dog" };
                var catType = new PetType { TypeName = "Cat" };
                db.PetTypes.AddRange(dogType, catType);

                var male = new Gender { GenderName = "Male" };
                var female = new Gender { GenderName = "Female" };
                db.Genders.AddRange(male, female);
                db.SaveChanges();

                Pet p1 = new Pet {
                    Name = "Bella", AgeMonth = 12, TypeId = dogType.Id, Gender = female,
                    Description = "Friendly golden retriever puppy." };

                Pet p2 = new Pet {
                    Name = "Max", AgeMonth = 24, TypeId = catType.Id, Gender = male,
                    Description = "Energetic tabby cat with a playful personality." };

                Client client1 = new Client
                {
                    Name = "John Doe", GenderId = male.Id, Address = "123 Elm Street",
                    PhoneNumber = "555-1234", Email = "johndoe@example.com"
                };

                Client client2 = new Client
                {
                    Name = "Jane Smith", GenderId = female.Id, Address = "456 Maple Avenue",
                    PhoneNumber = "555-5678", Email = "janesmith@example.com"
                };
                db.Clients.AddRange(client1, client2);

                db.Pets.Add(p1);
                db.Pets.Add(p2);
                db.SaveChanges();

                var pets = db.Pets.ToList();
                foreach (var pet in pets)
                {
                    Debug.WriteLine($"{pet.Name} - {pet.AgeMonth}");
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new HomePage());
        }
    }
}