﻿using System;

namespace tictac
{
    class Program
    {
       

       


        static void Main(string[] args)
        {
           


            int reverse=0;
            do
            {
                int player = 0;
                int maxmove = 0;
                char m1, m2, m3, m4, m5, m6, m7, m8, m9 = 'X';
                m1 = m2 = m3 = m4 = m5 = m6 = m7 = m8 = m9 = ' ';
                
                Console.WriteLine("Welcome to the tic-tac-toe");



                int pick;

                Console.Clear();

                do
            {
                    Console.WriteLine("Please select a menu option");
                    Console.WriteLine("1. New Game");
                    Console.WriteLine("2. About the Author");
                    Console.WriteLine("3. Quit");
                    pick = Convert.ToInt32(Console.ReadLine());
                reverse = 0;

                switch (pick)
            {

                case 1:
                    Console.Clear();
                       
                        break;

                case 2:
                            Console.Clear();
                    Console.WriteLine("Author's Name is: Yusuf Sonğur" + "\n" + "Author's Birthplace: Turkey");
                    Console.WriteLine("[Press Enter to return to main menu...]");
                    reverse++;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                   
                case 3:
                            Console.Clear();
                    Console.WriteLine("are you sure you want to quit ? [y/n]");
                    string result = (Console.ReadLine());
                    while (result != "y" && result != "Y" && result != "n" && result != "N")
                    {
                        Console.WriteLine("Plese choose Y or N ");
                        result = (Console.ReadLine());

                    }
                    if (result == "y" || result == "Y")
                    {
                        Environment.Exit(0);
                        break;
                    }
                    else if (result == "n" || result == "N")
                    {
                        Console.Clear();
                            reverse++;
                            break;
                    }
                    break;


            }
            } while (reverse==1);






            int checkwin = 0;

            Console.WriteLine("Welcome to the tic-tac-toe \n");
            do
            {
               


                Console.WriteLine(" {0} | {1} | {2} ", m1, m2, m3);

                Console.WriteLine("---+---+---");


                Console.WriteLine(" {0} | {1} | {2} ", m4, m5, m6);

                Console.WriteLine("---+---+---");

                Console.WriteLine(" {0} | {1} | {2} ",m7, m8, m9);

               

                if (++maxmove > 10)
                    break;


                do
                {
                   
                        if (m1 == 'X' && m2 == 'X' && m3 == 'X' || m4 == 'X' && m5 == 'X' && m6 == 'X' || m7 == 'X' && m8 == 'X' && m9 == 'X')
                        {
                            Console.WriteLine("X HAS WON");
                            checkwin++;
                            break;

                        }
                        else if (m1 == 'O' && m2 == 'O' && m3 == 'O' || m4 == 'O' && m5 == 'O' && m6 == 'O' || m7 == 'O' && m8 == 'O' && m9 == 'O')
                        {
                            Console.WriteLine("O HAS WON");
                            checkwin++;
                            break;
                        }
                        else if (m1 == 'X' && m4 == 'X' && m7 == 'X' || m2 == 'X' && m5 == 'X' && m8 == 'X' || m3 == 'X' && m6 == 'X' && m9 == 'X')
                        {
                            Console.WriteLine("X HAS WON");
                            checkwin++;
                            break;
                        }
                        else if (m1 == 'O' && m4 == 'O' && m7 == 'O' || m2 == 'O' && m5 == 'O' && m8 == 'O' || m3 == 'O' && m6 == 'O' && m9 == 'O')
                        {
                            Console.WriteLine("O HAS WON");
                            checkwin++;
                            break;
                        }
                        else if (m1 == 'X' && m5 == 'X' && m9 == 'X' || m3 == 'X' && m5 == 'X' && m7 == 'X')
                        {
                            Console.WriteLine("X HAS WON");
                            checkwin++;
                            break;
                        }
                        else if (m1 == 'O' && m5 == 'O' && m9 == 'O' || m3 == 'O' && m5 == 'O' && m7 == 'O')
                        {
                            Console.WriteLine("O HAS WON");
                            checkwin++;
                            break;
                        }
                        else if (m1 != ' ' && m2 != ' ' && m3 != ' ' && m4 != ' ' && m5 != ' ' && m6 != ' ' && m7 != ' ' && m8 != ' ' && m9 != ' ')
                        {
                        Console.WriteLine("GAME DRAW");
                        checkwin++;
                        break;
                        }








                    if (player == 0)
                     {
                           

                       
                        Console.Write("X's move > ");
                        string userchoice = Console.ReadLine();

                        if (userchoice == "1" && m1 == ' ')
                        {
                            m1 = 'X';
                           player++;
                            
                            break;
                        }
                        else if (userchoice == "2" && m2 == ' ')
                        {
                            m2 = 'X';

                            player++;
                            break;
                        }
                        else if (userchoice == "3" && m3 == ' ')
                        {
                            m3 = 'X';
                            player++;

                            break;
                        }
                        else if (userchoice == "4" && m4 == ' ')
                        {
                            m4 = 'X';
                            player++;

                            break;
                        }
                        else if (userchoice == "5" && m5 == ' ')
                        {
                            m5 = 'X';
                            player++;

                            break;
                        }
                        else if (userchoice == "6" && m6 == ' ')
                        {
                            m6 = 'X';
                            player++;

                            break;
                        }
                        else if (userchoice == "7" && m7 == ' ')
                        {
                            m7 = 'X';
                            player++;

                            break;
                        }
                        else if (userchoice == "8" && m8 == ' ')
                        {
                            m8 = 'X';

                            player++;
                            break;
                        }
                        else if (userchoice == "9" && m9 == ' ')
                        {
                            m9 = 'X';
                            player++;

                            break;
                        }
                        
                        else
                        {
                            Console.WriteLine("İllegal Move! Try again.");
                        }
                    }
                    


                    if (player == 1)
                    {

                        


                     
                        
                        
                        Console.Write("O's move > ");
                        string userchoice = Console.ReadLine();

                        if (userchoice == "1" && m1 == ' ')
                        {
                            m1 = 'O';
                            player--;
                           
                            break;
                        }
                        else if (userchoice == "2" && m2 == ' ')
                        {
                            m2 = 'O';
                            player--;

                            break;
                        }
                        else if (userchoice == "3" && m3 == ' ')
                        {
                            m3 = 'O';
                            player--;

                            break;
                        }
                        else if (userchoice == "4" && m4 == ' ')
                        {
                            m4 = 'O';

                            player--;
                            break;
                        }
                        else if (userchoice == "5" && m5 == ' ')
                        {
                            m5 = 'O';
                            player--;

                            break;
                        }
                        else if (userchoice == "6" && m6 == ' ')
                        {
                            m6 = 'O';
                            player--;

                            break;
                        }
                        else if (userchoice == "7" && m7 == ' ')
                        {
                            m7 = 'O';
                            player--;

                            break;
                        }
                        else if (userchoice == "8" && m8 == ' ')
                        {
                            m8 = 'O';
                            player--;

                            break;
                        }
                        else if (userchoice == "9" && m9 == ' ')
                        {
                            m9 = 'O';

                            player--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("İllegal Move! Try again.");
                        }
                        }
                        
                    
                   
                   


                } while (m1 != m2 && m2 != m3 ||
                         m4 != m5 && m5 != m6 ||
                         m6 != m7 && m7 != m8 ||


                         m1 != m4 && m4 != m7 ||
                         m2 != m5 && m5 != m8 ||
                         m3 != m6 && m6 != m9 ||

                         m1 != m5 && m5 != m9 ||
                         m3 != m5 && m5 != m7 ||

                         m1 != 'X' || m1 != 'O' && m2 != 'X' || m2 != 'O' && m3 != 'X' || m3 != 'O' &&
                         m4 != 'X' || m4 != 'O' && m5 != 'X' || m5 != 'O' && m6 != 'X' || m6 != 'O' &&
                         m7 != 'X' || m7 != 'O' && m8 != 'X' || m8 != 'O' && m9 != 'X' || m9 != 'O');

               




            } while (checkwin!=1);
                Console.WriteLine("[Press Enter to return to main menu...]");
                Console.ReadKey();
                Console.Clear();
            } while (true);



            
        }

       
    }
}
