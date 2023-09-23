using System.Security.AccessControl;

namespace CSharp_11_Book;

class Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }

}
class Dog : Animal
{
    public bool Strong { get; set; } 
}

class Cat : Animal
{
    public bool Wild { get; set; }
}

public class SwitchAndClasses
{
    public static void exe()
    {
        Animal?[] animals = new Animal[]
        {
            new Cat {Name = "CatDog", Breed ="Michifú", Wild = true},
            new Cat {Name = "Garfield", Breed ="Michifá", Wild = false},
            new Dog { Name = "Chiquiño", Breed ="Pitbull", Strong = true},
            new Dog { Name = "Choky", Breed ="Not even god Knows", Strong = false},
            null
        };

        foreach(var a in animals)
        {
            string Message=String.Empty;
            switch(a)
            {
                case Cat wildCat when wildCat.Wild == true:
                    Message = $"{wildCat.Name.ToUpper()}, is a wild cat!!";
                    break;
                case Cat normalCat when normalCat.Wild == false:
                    Message = $"{normalCat.Name.ToUpper()} is not a wild cat, you can pet the cat";
                    break;
                case Dog isStrong when isStrong.Strong == true:
                    Message = $"{isStrong.Name.ToUpper()} is a {isStrong.Breed.ToUpper()} breed! hold on firm the leash!";
                    break;
                case Dog isNotStrong when isNotStrong.Strong == false:
                    Message = $"{isNotStrong.Name.ToUpper()} is just a \"{isNotStrong.Breed.ToUpper()}\" breed dont worry!";
                    break;
                case null:
                    WriteLine("This is a null reference, there is no values here");
                    break;
                default:
                    WriteLine("In this example this option will never be used");
                    break;
            }
            WriteLine(Message);
        }

    }
}
