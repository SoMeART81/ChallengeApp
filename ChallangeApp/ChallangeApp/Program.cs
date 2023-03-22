string name = "Ewa";
string sex = "Kobieta";
int age = 17;

if (sex == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni " + sex);
}

else if (age < 30 && sex == "Kobieta")
{
    Console.WriteLine(sex + " poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine(name + ", lat " + age);
}



