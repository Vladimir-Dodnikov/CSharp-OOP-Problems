
using SingleInheritance.Farm;

namespace SingleInheritance
{
    public class StartUp
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Bark();

            //Multiply Inheritance Task 2
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            //Multiply Inheritance Task 3
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}
