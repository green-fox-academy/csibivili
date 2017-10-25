namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; } = "Simba";
        public double Balance { get; set; } = 2000.00;
        public TypeOfAnimal AnimalType { get; set; } = TypeOfAnimal.Lion;
    }

    public enum TypeOfAnimal
    {
        Lion
    }
}
