using Console_App_Animals.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    class Griffin : Animal
    {
        public Griffin()
        {
            griffinName = "Griffin";
        }


        public string griffinName { get; private set; }

        public override void Move()
        {
            Console.WriteLine($"{griffinName} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{griffinName} sleep");
        }
    }
}
