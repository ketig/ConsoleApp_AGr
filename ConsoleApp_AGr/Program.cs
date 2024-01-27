// pastebin.com/7QvYYzZv

// დაბეჭდეთ 1-დან 100-ის ჩათვლით 3-ის ჯერადი
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0) // 3-ის ჯერადი
    {
        Console.WriteLine(i);
    }
}

// დაბეჭდეთ 1-დან 100-ის ჩათვლით ლუწი რიცხვები
for (int i = 2; i <= 10; i += 2)
{
    Console.WriteLine(i);
}


// https://www.w3resource.com/csharp-exercises/array/index.php
// 1. ... stores elements in an array and prints them.
double[] myNumbers = { 1, 4, 3.5, 47 };
string[] studNamesAgr = new string[4] { "Rati", "Mariami", "Gaga", "Nika" };
string[] studNamesAgr2 = new string[] { "Rati", "Mariami", "Gaga", "Nika" };

double[] studentsAge = new double[9];

studentsAge[2] = 11;
studentsAge[4] = 14;
studentsAge[1] = 13;
studentsAge[3] = 14;


// string ტიპის მასივი
string[] studentNames = {"Rati", "Goga", "Alexadnre", "Nika", "Demiko", 
    "Giorgi", "Nikolozi"};



string[] cars = new string[4]; // {"", "", "", ""}
cars[1] = "Ford"; // {"", "Ford", "", ""}
cars[2] = "Opel"; // {"", "Ford", "Opel", ""}
cars[0] = "BMW"; // {"BMW", "Ford", "Opel", ""}
cars[3] = "Mercedec"; // {"BMW", "Ford", "Opel", "Mercedec"}


// დაბეჭდეთ მასივის ელემენტები თანმიმდევრობით
// Console.WriteLine(cars[0]);
// Console.WriteLine(cars[1]);
// Console.WriteLine(cars[2]);
// Console.WriteLine(cars[3]);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(cars[i]);
}


// დაბეჭდეთ მასივის ელემენტები უკუღმა