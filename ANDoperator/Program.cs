//Math >90; biology >=90; chemistry >=90;

int math, biology, chemisty;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemisty = Int32.Parse(Console.ReadLine());


if(math>= 90 && biology >= 90 && chemisty >= 90)
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved");
}