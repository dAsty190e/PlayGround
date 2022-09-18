using System;

namespace _08_PlayWithCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Do you ready to choose your animal? y/n");
            var animals = Console.ReadKey().KeyChar;

            if (char.ToLower(animals) == 'y')
            {
                var control = true;
                do
                {
                    Console.WriteLine("\nOk! What is your favorite animal? a/b/c/d");
                    Console.WriteLine("\na.Cat");
                    Console.WriteLine("\nb.Dog");
                    Console.WriteLine("\nc.Duck");
                    Console.WriteLine("\nd.Horse");

                    char animal = Console.ReadKey().KeyChar;
                    Console.WriteLine("\nWhat name you will give to this pet?");
                    string name = Console.ReadLine();
                    
                    
                    if (char.ToLower(animal) == 'a') // cat
                    {
                        Console.WriteLine($"\nDo you want to feed this {name}? y/n");
                        string food = Console.ReadLine().ToLower();
                        
                        if (food == "y")
                        {
                            Console.WriteLine("\nWhat you will choose? a/b/c");
                            Console.WriteLine("\na.Fish");
                            Console.WriteLine("\nb.Meat");
                            Console.WriteLine("\nc.Dry cat food");

                            var yummy = Console.ReadLine().ToLower();

                            if (yummy == "a")
                            {
                                Console.WriteLine($"\nDo you want give a pets to a {name}? y/n");
                                char pets = Console.ReadKey().KeyChar;

                                if (char.ToLower(pets) == 'y')
                                {
                                    Console.WriteLine("\nPuuuuuuurrrrrrr");
                                    Console.WriteLine("\nDo you want try another aniimal? y/n");
                                    char anotherAni = Console.ReadKey().KeyChar;

                                    if (char.ToLower(anotherAni) == 'y')
                                    {
                                        Console.WriteLine("\nLets do it!");
                                        control = true;
                                    }
                                    else if (char.ToLower(anotherAni) == 'n')
                                    {
                                        Console.WriteLine("\nSee you later!");
                                        control = false;
                                    }
                                }
                            }// cat
                            else if (yummy =="b")
                            {
                                Console.WriteLine($"\n{name} not like your treats and start to go away! What you will do? a/b ");
                                Console.WriteLine($"\na.Start give to the {name} a pets!");
                                Console.WriteLine("\nb.Oh! If he like this so be it! Let him go!");
                                char away = Console.ReadKey().KeyChar;

                                if (char.ToLower(away) == 'a')
                                {
                                    Console.WriteLine("\nOh! Look at him! He likes it!");
                                    Console.WriteLine($"\nDo you want to play with {name}? y/n");
                                    char toys = Console.ReadKey().KeyChar;

                                    if (char.ToLower(toys) == 'y')
                                    {
                                        Console.WriteLine("\nWhat toy you will choose? a/b");
                                        Console.WriteLine("\na.Ball");
                                        Console.WriteLine("\nb.Cat stick");
                                        char toy = Console.ReadKey().KeyChar;

                                        if (char.ToLower(toy) == 'a')
                                        {
                                            Console.WriteLine("\nNow he tired and fall asleep!");
                                            Console.WriteLine("\nDid you want try another anomal? y/n");
                                            char another = Console.ReadKey().KeyChar;

                                            if (char.ToLower(another) == 'y')
                                            {
                                                Console.WriteLine("\nLets start!");
                                                control = true;
                                            }
                                            else if (char.ToLower(another) == 'n')
                                            {
                                                Console.WriteLine("\nSee you next time! Take care!");
                                                control = false;
                                            }
                                        }
                                        else if (char.ToLower(toy) == 'b')
                                        {
                                            Console.WriteLine($"\n{name} like it so much! Do you want to give him pets before he go away? y/n");
                                            char goAway = Console.ReadKey().KeyChar;

                                            if (char.ToLower(goAway) == 'y')
                                            {
                                                Console.WriteLine("\nIt is so cute! He fall asleep on your knees! <3");
                                                Console.WriteLine("\nDo you want to rty another anomal? y/n");
                                                char goNext = Console.ReadKey().KeyChar;

                                                if (char.ToLower(goNext) == 'y')
                                                {
                                                    Console.WriteLine("\nIt will be fun! Lest go!");
                                                    control = true;
                                                }
                                                else if (char.ToLower(goNext) == 'n')
                                                {
                                                    Console.WriteLine("\nSee you next time");
                                                    control = false;
                                                }

                                            }
                                            else if (char.ToLower(goAway) == 'n')
                                            {
                                                Console.WriteLine($"\n{name} run away!");
                                                Console.WriteLine("\nSee you next time! Take care!");
                                                control = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nSee you later!");
                                        }

                                    }
                                    else if (char.ToLower(toys) == 'n')
                                    {

                                    }
                                }
                                else if (char.ToLower(away) == 'b')
                                {
                                    Console.WriteLine($"\n{name} is run away!");
                                    Console.WriteLine("\nDo you want to try with another anomal? y/n");
                                    char again = Console.ReadKey().KeyChar;

                                    if (char.ToLower(again) == 'y')
                                    {
                                        Console.WriteLine("\nLets do it!");
                                        control = true;
                                    }
                                    else if (char.ToLower(again) == 'n')
                                    {
                                        Console.WriteLine("\nSee you later!");
                                        control = false;
                                    }

                                }
                            } //cat
                            else if (yummy == "c") //cat
                            {
                                Console.WriteLine($"\n{name} like it!");
                                Console.WriteLine($"\nDo you want to buy to {name} a new bed? y/n");
                                char bed = Console.ReadKey().KeyChar;

                                if (char.ToLower(bed) == 'y')
                                {
                                    Console.WriteLine($"\nLook! {name} so like it!");
                                    Console.WriteLine($"{name} want to play! Do you? y/n");
                                    char play = Console.ReadKey().KeyChar;

                                    if (char.ToLower(play) == 'y')
                                    {
                                        Console.WriteLine($"\nYou spend a great time with {name}. Come back later!");
                                        Console.WriteLine("\nDo you want try another animal? y/n");
                                        char tryAnother = Console.ReadKey().KeyChar;

                                        if (char.ToLower(tryAnother) == 'y')
                                        {
                                            Console.WriteLine("\nLets go!");
                                            control = true;
                                        }
                                        else if (char.ToLower(tryAnother) == 'n')
                                        {
                                            Console.WriteLine("\nSee you another time!");
                                            control = false;
                                        }

                                    }
                                    else if (char.ToLower(play) == 'n')
                                    {
                                        Console.WriteLine("\nOk! Do you want to try another animal? y/n");
                                        char animalAnother = Console.ReadKey().KeyChar;

                                        if (true)
                                        {
                                            Console.WriteLine("\nGood! We already there!");
                                            control = true;
                                        }
                                        else if (char.ToLower(animalAnother) == 'n')
                                        {
                                            Console.WriteLine("\nHave a nice day!");
                                            control = false;
                                        }
                                    }
                                }
                                else if (char.ToLower(bed) == 'n')
                                {
                                    Console.WriteLine($"\n{name} upset and run away!");
                                    Console.WriteLine("\n Do you want to try another pet? y/n");
                                    char anotherPet = Console.ReadKey().KeyChar;

                                    if (char.ToLower(anotherPet) == 'y')
                                    {
                                        Console.WriteLine("\nLets choose!");
                                        control = true;
                                    }
                                    else if (char.ToLower(anotherPet) == 'n')
                                    {
                                        Console.WriteLine("\nOK");
                                        control = false;
                                    }
                                }
                            }

                        }
                        else if (food == "n")
                        {
                            Console.WriteLine("\nDo you want choose another animal? y/n");
                            control = true;
                        }
                    }
                    else if (char.ToLower(animal) == 'b') // dog
                    {
                        Console.WriteLine("\nDog so happy to see you! Do you wamt to play with him? y/n");
                        var play = Console.ReadKey().KeyChar;

                        if (char.ToLower(play) == 'y')
                        {
                            Console.WriteLine("\nIt was fun! Lets feed this dog! What snack you will give him? a/b/c");
                            Console.WriteLine("\na.Bone");
                            Console.WriteLine("\nb.Treats");
                            Console.WriteLine("\nc.Dog food");

                            char treats = Console.ReadKey().KeyChar;

                            if (char.ToLower(treats) == 'a')
                            {
                                Console.WriteLine($"\nLook! {name} diging a hole and hiding it! Oh no! {name} need a bath! Do you want to help? y/n");
                                char bath = Console.ReadKey().KeyChar;

                                if (char.ToLower(bath) == 'y')
                                {
                                    Console.WriteLine("\nWe need take a shampo! Hmm, which one? a/b/c");
                                    Console.WriteLine("\na.Head&Heands");
                                    Console.WriteLine("\nb.Heand soap");
                                    Console.WriteLine("\nc.Pets shampo");
                                    char shampo = Console.ReadKey().KeyChar;

                                    if (char.ToLower(shampo) == 'a')
                                    {
                                        Console.WriteLine($"\nOh no! It is a lot of bubles! But not for a {name}!");
                                        Console.WriteLine("\nDo you want choose another one? y/n");
                                        char secondShampo = Console.ReadKey().KeyChar;

                                        if (char.ToLower(secondShampo) == 'y')
                                        {
                                            Console.WriteLine("\nLets choose again! a/b");
                                            Console.WriteLine("\na.Heand soap");
                                            Console.WriteLine("\nb.Pets shampo");
                                            char shampoo = Console.ReadKey().KeyChar;

                                            if (char.ToLower(shampoo) == 'a')
                                            {
                                                Console.WriteLine($"\nOh no! It is a lot of bubles! But not for a {name}!");
                                                Console.WriteLine("\n");
                                                Console.WriteLine($"\n We have a pets shampo for {name}. Lets wash {name}. Ready? y/n");
                                                char wash = Console.ReadKey().KeyChar;

                                                if (char.ToLower(wash) == 'y')
                                                {
                                                    Console.WriteLine($"\nNow {name} look great! Look! He bring his toy! Play with {name} y/n");
                                                    char toyOne = Console.ReadKey().KeyChar;

                                                    if (char.ToLower(toyOne) == 'y')
                                                    {
                                                        Console.WriteLine($"\nHow many time you want to play with {name}");
                                                        var moreTime = new string[] {"1", "2", "3", "4", "5"};

                                                        //!!! use a while loop

                                                    }
                                                    else if (true)
                                                    {

                                                    }

                                                }
                                                else if (char.ToLower(wash) == 'n')
                                                {
                                                    Console.WriteLine("\nThank you for you help! See you!");
                                                    control = false;
                                                }
                                            }
                                            else if (char.ToLower(shampoo) == 'n')
                                            {
                                                Console.WriteLine("\nSee you!");
                                                control = false;
                                            }
                                        }
                                        else if (char.ToLower(secondShampo) == 'n')
                                        {
                                            Console.WriteLine("\nOk! Have a nice day!");
                                            control = false;
                                        }
                                    }
                                    else if (true)
                                    {

                                    }
                                    else if (true)
                                    {

                                    }
                                }
                                else if (char.ToLower(bath) == 'n')
                                {
                                    Console.WriteLine($"\nYou let {name} run away and be dirty like a pig!");
                                    Console.WriteLine("\nSee you!");
                                    control = false;
                                }

                            }
                            else if (char.ToLower(treats) == 'b')
                            {

                            }
                            else if (char.ToLower(treats) == 'c')
                            {

                            }
                        }
                        else if (char.ToLower(play) == 'n')
                        {
                            Console.WriteLine("\nSee you next time!");
                            control = false;
                        }
                    } 
                    else if (char.ToLower(animal) == 'c') //Duck
                    {
                        Console.WriteLine("\nThis duck really scared of a cat! What we will do? a/b/c");
                    } 
                    else if (char.ToLower(animal) == 'd') //Horse
                    {
                        Console.WriteLine("\nOMG! He is adorable! Did you want to ride a horse? y/n");
                    } 

                } while (control);

            }
            else Console.WriteLine("\nSee you next time!");

        }
    }
}
