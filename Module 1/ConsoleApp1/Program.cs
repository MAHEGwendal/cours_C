Console.WriteLine("--------------Module 1---------------");

// Console.WriteLine permet d'afficher du texte dans la console en faisant un retour à la ligne
Console.WriteLine("--------------WriteLine()---------------");

Console.WriteLine("Ligne 1\nLigne 2"); //Le texte doit toujours être dans "", \n pour revenir à la ligne
Console.WriteLine("Nom: \tAlex"); // \t pour une tabulation
Console.WriteLine("Path: C:\\Users");// double \ pour pouvoir afficher un back-slash
Console.WriteLine("She said, \"Hi!\""); // \ \" permet d'avoir du texte entre guillemets

// Console.Write fait la même chose mais sans le retour à la ligne
Console.WriteLine("-----------------Write()-----------------");

Console.Write("Texte 1 ");
Console.Write("Texte 2");

//Console.ReadLine permet de récupérer la réponse d'un utilisateur depuis la console. /!\ La fonction ne retourne qu'une chaine de caractère, les int ne marchent donc pas

Console.WriteLine("");
Console.WriteLine("---------------ReadLine()----------------");
Console.Write("What is your favorite color ? ");
String favoriteColor = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteColor + " too !");

Console.WriteLine("");
Console.WriteLine("---------------Concaténation----------------");
string first = "Hello";
string last = "World";
string message = first + last;
Console.WriteLine(message);
Console.WriteLine($"Hello, {last} ! ");


Console.WriteLine("");
Console.WriteLine("---------------Méthodes de chaîne courantes----------------");
string testMethode = "David";
Console.WriteLine($".ToUpper() = {testMethode.ToUpper()} ");
Console.WriteLine($".ToLower() = {testMethode.ToLower()} ");
Console.WriteLine($".Replace(\"old\", \"new\") = {testMethode.Replace("a", "o")}");
Console.WriteLine($".Length = {testMethode.Length} ");

Console.ReadLine();