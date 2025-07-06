


using FactoryDesignPattern.Juice;

Console.WriteLine("Plwase Select Your Favorite Juice");
while (true)
{
    Console.WriteLine("[1] Orange");
    Console.WriteLine("[2] Apple");
    string juiceName = Console.ReadLine();


    Ijuceinterface juice = JuiceFactory.createJuice(juiceName);
    if(juice is ErrorJuice)
    {
        Console.WriteLine("This juice is unavaliable");
    }
    else{
        juice.Drink();
    }

    Console.WriteLine("Plwase Select Your Favorite Juice to ceater another one");

}