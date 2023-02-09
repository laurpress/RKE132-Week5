//Math >= 90 OR chemistry >= 90 OR biology >= 90

//Math && chemistry || math && biology || chemistry && biology

int math, biology, chemisty;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemisty = Int32.Parse(Console.ReadLine());

if (math >= 90 && chemisty >= 90 || (math >= 90 && biology >= 90) || (chemisty >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved");
}