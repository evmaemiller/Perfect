using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hi User! Please enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number)) {
            if (number < 1 || number > 10000) {
                Console.WriteLine("Number must be between 1 and 10000.");
            }
            else {
                bool isPerfect = false;
                int sum = 0;
                for (int i = 1; i <= number / 2; i++) {
                    if (number % i == 0) {
                        sum += i;
                    }
                }

                if (sum == number) {
                    isPerfect = true;
                }

                Console.WriteLine(isPerfect ? "Perfect Number":"Not a Perfect Number");
            }
        }
        else {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        }
    }