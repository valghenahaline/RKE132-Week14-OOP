Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");

Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}");

myDog.Rename("Bad boy");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name;
    private int _LevelOfHappiness;

    public Dog(string name)
    {
        _name = name;
        _LevelOfHappiness = 0;

    }
    public string Name
    {
        get { return _name; }  
    }
    public int LevelOfHappiness
    {
        get { return _LevelOfHappiness; }
    }
    public void Rename (string newName)
    {
        _name = newName; 
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _LevelOfHappiness++;
    }
    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
}