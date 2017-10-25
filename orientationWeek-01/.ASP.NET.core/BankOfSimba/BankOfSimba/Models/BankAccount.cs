namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public TypeOfAnimal AnimalType { get; set; }
        public bool isKing { get; set; } = false;
    }

    public enum TypeOfAnimal
    {
        Lion,
        Monkey,
        Parrot
    }
}
