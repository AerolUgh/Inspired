using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string Flower()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string flower = @"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⢠⠿⠷⣭⣶⣯⣥⣶⣾⣿⠀⠀⠀⠀⢠⠖⣒⡒⢢⣄⡴⠒⢢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢸⠷⣾⣿⡀⢠⡿⠑⠀⠀⢸⣿⡿⡄⠀⠀⠀⢸⢼⣍⠙⠛⠙⢷⡀⠀⣷⠒⠈⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢸⣼⡟⣭⣻⢿⣧⡀⠀⣰⡿⠛⣫⣽⠀⠀⢠⠃⠈⢾⣄⠀⠀⢸⣷⡶⠓⢷⣄⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⡏⠀⠈⠀⠙⣿⣴⡿⠁⠀⠁⢸⠂⠀⢸⠀⠀⠀⢫⣆⣰⡟⠁⠀⠀⢈⣿⠃⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣷⠀⠀⠀⠀⠘⣿⡇⠀⠀⢀⡟⠀⠀⠘⡆⠀⠀⠀⣿⡏⠀⠀⠀⠀⣸⡏⠀⠀⣾⣿⣿⣿⣶⣾⡝⡆⣀⡀
⠀⠀⠀⠀⠀⢀⡠⣤⠤⡀⠈⢧⡀⠀⠀⠀⣻⡇⠀⣠⠞⠀⠀⠀⠀⠙⢄⡀⠀⣿⠁⠀⠀⠀⣰⠋⠀⠀⡰⣿⢿⣏⠀⠹⣷⣿⣿⣿⣿
⠀⠀⡞⠉⢱⡾⠾⠛⣷⠷⡀⠀⠙⠦⠤⢤⣿⣿⠟⠀⠀⠀⠀⠀⢀⣴⣀⠭⢶⣿⣤⣄⠤⠞⠁⠀⠀⠀⣿⣿⠎⢿⣦⣾⠟⠏⠾⣿⡇
⡖⢒⣇⡀⣿⠀⠀⢠⡟⠀⠘⡆⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀⠀⣠⣿⣿⡇⠀⢰⡏⠀⠈⠑⠢⣄⡀⠀⠀⢻⡹⠀⢸⡿⠁⠀⠂⣰⡟⠀
⠱⣼⠋⠉⠛⠷⣤⣼⠁⠀⠀⢱⠀⠀⠀⠀⠀⢹⡇⠀⠀⡠⢺⣿⣿⣿⡇⠀⣼⠇⠀⠀⠀⠀⠀⣭⠲⢄⡀⠙⢦⣼⣧⠄⢀⡴⠋⠀⠀
⠀⠻⣆⠀⠀⠀⠈⢻⡄⠀⢀⠆⠀⠀⠀⣰⡄⠘⣷⢀⡜⠁⣾⣿⣿⣿⡇⢀⡿⠀⠀⠀⣴⣧⢸⣿⣧⠀⠉⠲⢄⣿⠋⠉⠉⠀⠀⠀⠀
⠀⠀⠙⢦⡀⠀⠀⠀⣧⣴⠋⠀⠀⠀⢠⣿⣿⡄⢿⡎⠀⢸⣿⣿⣿⣿⡇⢸⡇⠀⢀⣾⣿⣿⣾⣿⣿⡇⠀⠀⢸⠏⠑⠢⣀⣤⡶⠀⠀
⠀⠀⠀⠀⠈⠁⠒⠈⠙⣯⠀⠀⠀⠀⣼⣿⣿⣿⣼⡇⠀⣿⣿⣿⣿⣿⠃⣾⠃⢀⣿⣿⣿⡇⣿⣿⣿⣧⠀⢀⡿⠀⢀⣴⣿⣿⡇⠀⠀
⠀⠀⠀⢀⣀⠀⠀⠀⠀⠘⣷⠀⠀⠀⣿⣿⣿⣿⣟⡇⢠⣿⣿⣿⣿⡟⢀⣿⢀⣾⣿⣿⣿⠇⢿⣿⣿⣿⠀⣸⠇⢠⣾⣿⣿⠏⢣⠀⠀
⠀⠀⠀⠈⢿⣿⣦⣄⠀⠀⠘⣧⠀⢀⣿⣿⣿⣿⣿⣿⢸⣿⣿⣿⡿⠁⢸⡏⣸⣿⣿⣿⡟⠀⠸⣿⣿⣿⢀⡿⢠⣿⣿⣿⠏⠀⠀⡇⠀
⠀⠀⠀⠀⠈⢿⣿⣿⣷⣄⠀⣸⣷⠉⣿⣿⣿⣿⣿⢹⣸⣿⣿⡿⠁⠀⢸⣇⣿⣿⣿⡟⠀⠀⠀⠹⣿⣿⣼⢧⣿⣿⠟⠁⢀⢔⡫⠆⠀
⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣄⠹⡆⢹⣿⣿⣿⡟⢸⣿⡿⠋⡀⠀⠀⣿⢹⣿⣿⠏⢀⣴⣿⠀⠀⠙⢿⣿⠛⠋⢁⡠⣺⠔⠉⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣠⠟⢿⣿⣿⣿⣧⣹⡜⣿⣿⣿⠇⢸⣧⠀⢰⣿⡀⠀⣿⠸⠟⠁⠀⣾⣿⡟⠀⠀⠀⢸⣇⡠⢖⡭⠊⠀⠀⠀⠀⡄⠀
⠀⠀⠀⠀⠀⠀⢾⠭⢒⡿⠿⢿⣿⣿⣿⣿⣿⠏⠀⠸⣿⠀⣿⣿⣷⢰⣿⠀⠀⠀⣼⣿⣿⠇⠀⢀⡤⣞⠭⠚⢹⠀⠀⠀⠀⠀⠀⠇⠀
⠀⠀⠀⠀⠀⠀⢸⡀⠀⠘⡏⠒⠪⠭⣛⡿⠯⣀⡀⠀⣿⠀⣿⣿⣿⣸⡿⠀⠀⢰⣿⣿⣿⠴⣪⠕⠊⠁⠀⠀⠚⠀⠀⠀⠀⠀⢀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡇⠀⠀⢳⠀⠀⠀⠀⠉⠑⢲⡪⠭⣛⡓⠿⢿⣿⣿⣇⠀⣀⠼⢛⡩⠒⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠈⣧⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀⠉⢁⡐⠖⠈⠩⠔⠊⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡎⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⡆⠀⠀⠘⣆⠀⠀⢀⡀⠠⠼⠓⠂⠩⠑⠒⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠇⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣀⡙⠂⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⠀⠀⠀⠀⠀⡇⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⢸⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡎⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⡀⠀⠀⠀⢇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠃⠀⠀⠀⠀⡸⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⡀⠀⠀⠘⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⠀⠀⠀⠀⢠⠃⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢣⠀⠀⠘⣳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡇⠀⠀⠀⢠⠃⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢇⠀⠀⢹⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡞⠀⠀⠀⣰⠃⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠆⠀⠀⢷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡸⠁⠀⠀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡄⠀⠘⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠃⠀⠀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⡀⠀⠹⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡏⠀⠀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⡄⠀⢱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡿⠀⠀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢆⠀⢣⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢾⠃⠀⣰⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢦⠈⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣨⠏⠀⣰⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡶⠋⠉⠓⢦⣄⢣⡈⢧⠀⠀⠀⠀⠀⠀⠀⠀⢰⡛⠀⣰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣦⣄⡀⠀⠙⢷⣷⠀⢧⠀⠀⠀⠀⠀⠀⢀⣣⡵⡾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⠷⣦⣤⣹⣟⣈⣇⣀⡠⠤⠖⠛⠉⣁⣰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";

            Console.WriteLine(flower);
            return flower;
        }

        public static string Butterfly()
        {
            string butterfly = @"
        .==-.                   .-==.
        \\()8`-._  `.   .'  _.-'8()//
        (88""   ::.  \\./  .::   ""88)
         \\_.'`-::::.(#).::::-'`._//
           `._... .q(_)p. ..._.'
             """"-..-'|=|`-..-""""
             .""""' .'|=|`. `"""".
            ,':8(o)./|=|\\.(o)8:`.
          (  O :88  \=|=/  88: O  )
           \\,88,/\(/|=|\\)/,88,//
            \ _..-8(_)=(_)8-.._ /
              `--._.--.--._.--'
";
            Console.WriteLine(butterfly);
            return butterfly;
        }

        public static void TrackDate()
        {
                string enteredDate = "";
                Console.Write("Enter Date (MM/dd/yyyy): ");
                enteredDate = Console.ReadLine();
            
                DateTime dateNow = DateTime.Now;
                DateTime dateEntered = Convert.ToDateTime(enteredDate);
            
                int days = (dateNow - dateEntered).Days;
                int months = (dateNow.Year - dateEntered.Year) * 12 + (dateNow.Month - dateEntered.Month);
                int years = (dateNow.Year - dateEntered.Year);
                TimeSpan hour = dateNow - dateEntered;
                TimeSpan minute = dateNow - dateEntered;
                double hours = Math.Round(hour.TotalHours, 2);
                double minutes = Math.Round(minute.TotalMinutes, 2);
            
                if (dateNow.Month < dateEntered.Month || (dateNow.Month == dateEntered.Month && dateNow.Day < dateEntered.Day))
                {
                    years--; // Subtract 1 year if the anniversary hasn't passed
                }
            
                Console.WriteLine($"Years : {Math.Abs(years)}");
                Console.WriteLine($"Months : {Math.Abs(months)}");
                Console.WriteLine($"Days : {Math.Abs(days)}");
                Console.WriteLine($"Hours : {Math.Abs(hours)}");
                Console.WriteLine($"Minutes : {Math.Abs(minutes)}");
            }

        public static string Letter()
        {
            string letter = 
@"      * THIS PROGRAM IS INTENDED FOR MY BEAUTIFUL AND POWERFUL BABY GIRL *
    
    To my beautiful lady out there seeing this program, I just want to say 
    that I love you so much, I know this program is corny and simple HAHAHAA 
    but maybe years after if i gain huge knowledge about my profession basin 
    dili ra in ani ako mabuhat heehe. I love you so muchh babyy. Take care <3";

            Console.WriteLine(letter);
            return letter;
        }

        static void Main(string[] args)
        {
            try
            {
                begin:

                Console.WriteLine("[1] Flower");
                Console.WriteLine("[2] Butterfly");
                Console.WriteLine("[3] Track how long are we together");
                Console.WriteLine("[4] Letter from the developer");
                Console.Write("Choose: ");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Flower();
                        break;
                    case 2:
                        Butterfly();
                        break;
                    case 3:
                        TrackDate();
                        break;
                    case 4:
                        Letter();
                        break;
                    default:
                        break;
                }

                string tryagain = "y";
                Console.Write("You want to try again? (y/n): ");
                tryagain = Console.ReadLine().ToLower();

                if (tryagain == "y")
                {
                    Console.Clear();
                    goto begin;
                }
                else
                {
                    goto end;
                }

                end:
                Console.WriteLine("I Love you so muchhh!!!!");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter a Number");
                
            }
        }
    }
}
