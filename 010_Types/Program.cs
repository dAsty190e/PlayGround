// See https://aka.ms/new-console-template for more information

using _010_Types;

var PiperCat = new Cat();
PiperCat.Name = "PiperCat";
PiperCat.Color = "White";
PiperCat.Age = 5;
PiperCat.EyeColor = "Blue";
PiperCat.Gender = "GirlyGirl";

var Basya = new Cat();
Basya.Name = "Basya";
Basya.Color = "Black & White";
Basya.Age = 5;
Basya.EyeColor = "Green";
Basya.Gender = "GirlyGirl";

Console.WriteLine($"\n{PiperCat.Name} is a {PiperCat.Gender} {PiperCat.Color} cat with {PiperCat.EyeColor} eyes");
PiperCat.Meow();

Console.WriteLine($"\n{Basya.Name} is a {Basya.Gender} {Basya.Color} cat with {Basya.EyeColor} eyes");
Basya.Meow();
