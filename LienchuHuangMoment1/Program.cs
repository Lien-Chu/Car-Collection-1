using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LienChuHuangMoment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Mini-Cooper", "BMW", "Mercedes-Benz", "Toyota", "Audi" }; //Create and assign values for array

            while (true)
            {   //Create an interface for users to choose the options. 
                Console.Clear();
                Console.WriteLine("\n\t\tWelcome to car Collection\n\nPlease navigate through the menu by typing a number \n(1, 2, 3, 0) of your choice"
                    + "\n\n0. End dialougue"
                    + "\n1. List all of cars"
                    + "\n2. Change car"
                    + "\n3. List cars in order");

                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    Console.Write("\nPlease enter your choice  between 1-3 or enter 0 to exit: ");
                    input = Console.ReadLine()[0]; //Identify the first char in input line. 
                }
                catch (IndexOutOfRangeException) //Catch Exception like if the input line is empty, then ask the users for some input.
                {
                    Console.WriteLine("Please enter a number between 1-3 or enter 0 to exit the application! Hit any key to continue. ");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (input > '3') //If the input number is not match, ask the users for some input.
                {
                    Console.WriteLine("This number is not availabl. Please enter a number between 1 - 3 or enter 0 to exit the application! Hit any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    switch (input)//Switch case for execution according to the input number.
                    {
                        case '0':
                            return;
                        case '1':
                            ListAllOfCars(); //Nav to method ListAllOfCars().
                            break;
                        case '2':
                            ChangeCar();//Nav to method ChangeCar().
                            break;
                        case '3':
                            ListCarsInOrder();//nav to method ListCarsInOrder().
                            break;
                        default:
                            break;
                    }
                }
            }

            #region 1. List all of cars
            void ListAllOfCars() //Method for list up all the cars by using for loop.
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine(cars[i]);
                }
                Console.WriteLine("\nPlease hit any key to continue. ");
                Console.ReadLine();
            }
            #endregion

            #region 2. Change car
            void ChangeCar() //Method for Change car.
            {
                int selectedIndex;
                char input = ' ';
                while (true)
                {
                    //List up all the cars for user to choose from.
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine("Car " + (i + 1) + " : " + cars[i]);
                    } 
                    try
                    {
                        Console.Write("\nPlease enter your choice between 1-5 or enter 0 to exit : ");
                        input = Console.ReadLine()[0];
                    }
                    catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                    {
                        Console.WriteLine("Please enter a number between 1-5 or enter 0 to exit the application! Hit any key to continue. ");
                        Console.ReadLine();
                    }            
                if (input > '5') //If the input number is not match, ask the users for some input.
                    {
                        Console.WriteLine("This number is not available! Hit any key to continue.");
                        Console.ReadLine();
                    }
                    else
                    {
                        switch (input)//Execute switch-case according to the input number.
                        {
                            case '0':
                                return;
                            case '1':
                                selectedIndex = 0; //Identify the index number that the user has selected.
                                AssignInputAsANewValue(selectedIndex); //nav to method AssignInputAsANewValue().
                                break;
                            case '2':
                                selectedIndex = 1;
                                AssignInputAsANewValue(selectedIndex);
                                break;
                            case '3':
                                selectedIndex = 2;
                                AssignInputAsANewValue(selectedIndex);
                                break;
                            case '4':
                                selectedIndex = 3;
                                AssignInputAsANewValue(selectedIndex);
                                break;
                            case '5':
                                selectedIndex = 4;
                                AssignInputAsANewValue(selectedIndex);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            #endregion

            #region 3. List cars in order
            void ListCarsInOrder() //Method for list up all the cars in order by using foreach loop.
            {
                Array.Sort(cars);
                foreach (string model in cars)
                {
                    Console.WriteLine(model);
                }
                Console.WriteLine("\nPlease hit any key to continue. ");
                Console.ReadLine();
            }
            #endregion

            #region 4. Assign input as a new value
            void AssignInputAsANewValue(int selectedIndex) //Method for Assign input as a new value.
            {
                Console.Write("Which car do you want to replace?\nPlease enter a car's name:");
                cars[selectedIndex] = Console.ReadLine(); //Assign input as a new value for cars array's index.
                for (int i = 0; i < cars.Length; i++)  //list up the cars array in new value.
                {
                    Console.WriteLine("Car " + (i + 1) + " : " + cars[i]);
                }
                Console.WriteLine("\nPlease hit any key to continue.");
                Console.ReadLine();
            }
            #endregion
        }
    }
}

