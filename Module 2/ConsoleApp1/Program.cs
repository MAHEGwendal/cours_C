Console.WriteLine("--------------Module 2---------------");

Console.WriteLine("--------------Les littéraux---------------");

Console.WriteLine("Hello");        // string literal - utilisé des ""
Console.WriteLine('H');            // char literal - utilisé un ' pour UN SEUL caractère
Console.WriteLine(42);             // int literal - juste un nombre
Console.WriteLine(3.14);           // decimal literal - besoin du point
Console.WriteLine(true);           // bool literal - true ou false

Console.WriteLine("--------------Les variables---------------");
//Lorsque vous affectez une valeur à une var variable, C# détermine automatiquement son type de données en fonction de la valeur affectée 

var name = "Alice";           // C# sees a string, so name is string
var age = 25;                 // C# sees a whole number, so age is int
var price = 19.99;            // C# sees a decimal, so price is double