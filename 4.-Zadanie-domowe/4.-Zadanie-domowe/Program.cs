var name = "Ewa";
var gender = "Woman";
var age = 33;
if (age - 16 < 18 && gender == "Man")
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else if (name == "Ewa" && age == 33 && gender == "Woman")
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (age - 4 < 30 && gender == "Woman" || name == "Ewa")
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}