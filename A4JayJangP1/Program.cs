/* Program ID: A4JayJangP1
 * Purpose: Assignment 4 Reservation system.
 * Revision History:
 * Jay Jang - April 3, 2017
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4JayJangP1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declaration variables initionalize
            string userOption = "";
            string seatRow = "";
            int seatNumber = 0;
            string stringSeat = "";
            string userName = "";
            string checkName = "";
            string cancelName = "";
            string lastQuestion = "";
            string[,] seatArray = new string[4, 6];

            Console.WindowHeight = 50;
           
            // read file io
            try
            {
                StreamReader reader = new StreamReader("data.txt");
                for (int j = 0; j < seatArray.GetLength(0); j++)
                {
                    string line = reader.ReadLine();
                    for (int i = 0; i < seatArray.GetLength(1); i++)
                    {
                        string[] tokens = line.Split('|');
                        if (tokens[i] != "")
                        {
                            seatArray[j, i] = tokens[i];
                        }
                        else
                        {
                            seatArray[j, i] = null;
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Main menu
            do
            {
                Console.Write("               _________________      ____");
                Console.WriteLine("         __________");
                Console.Write(" .       .    /                 |    /");
                Console.WriteLine("    \\    .  |          \\");
                Console.Write("     .       /    ______   _____| . /");
                Console.WriteLine("      \\      |    ___    |     .");
                Console.Write("             \\    \\    |   |       /");
                Console.WriteLine("   /\\   \\     |   |___>   |");
                Console.Write("           .  \\    \\   |   |      /");
                Console.WriteLine("   /__\\   \\  . |         _/     .");
                Console.Write(" .     ________>    |  |   | .   /    ");
                Console.WriteLine("        \\   |   |\\    \\_______    .");
                Console.Write("      |            /   |   |    /    _____");
                Console.WriteLine("_    \\  |   | \\           |");
                Console.Write("      |___________/    |___|   /____/      ");
                Console.WriteLine("\\____\\ |___|  \\__________| .");
                Console.Write("  .     ____    __  . _____   ____      .  ");
                Console.WriteLine("__________   .  _________");
                Console.Write("       \\    \\  /  \\  /    /  /    \\    ");
                Console.WriteLine("   |          \\    /         |   .");
                Console.Write("        \\    \\/    \\/    /  /      \\   ");
                Console.WriteLine("   |    ___    |  /    ______|.");
                Console.Write("         \\              /  /   /\\   \\ . ");
                Console.WriteLine("  |   |___>   |  \\    \\");
                Console.Write("   .      \\            /  /   /__\\   \\  ");
                Console.WriteLine("  |         _/.   \\    \\");
                Console.Write("           \\    /\\    /  /            \\ ");
                Console.WriteLine("  |   |\\    \\______>    |   .");
                Console.Write("            \\  /  \\  /  /    ______    \\");
                Console.WriteLine("  |   | \\              /        .");
                Console.Write(" .       .   \\/    \\/  /____/      \\____");
                Console.WriteLine("\\ |___|  \\____________/  ");
                Console.Write("");

                Console.Write("────────────────────────WELCOME STAR WARS");
                Console.WriteLine(" CINEMA───────────────────────");
                Console.WriteLine("");
                Console.Write("┌───────────────────────────MENU OPTIONS─");
                Console.WriteLine("─────────────────────────────┐");
                Console.Write("│                     1. MAKE YOUR RESERV");
                Console.WriteLine("ATION                        │");
                Console.Write("│                     2. CHECK YOUR RESER");
                Console.WriteLine("VATION                       │");
                Console.Write("│                     3. CANCEL YOUR RESE");
                Console.WriteLine("RVATION                      │");
                Console.Write("│                     4. EXIT RESERVATION");
                Console.WriteLine(" SYSTEM                      │");
                Console.Write("└────────────────────────────────────────");
                Console.WriteLine("─────────────────────────────┘");

                do
                {
                    Console.Write(" Please choose the option you want: ");
                    userOption = Console.ReadLine();
                    Console.WriteLine("");
                } while (userOption != "1" && userOption != "2" &&
                             userOption != "3" && userOption != "4");

                //Option 1 Booking
                if (userOption == "1")
                {
                    int j = 0;
                    Console.Write("┌──────────────────────────────────");
                    Console.WriteLine("───────────────────────────────────┐");
                    Console.Write("│                     1. MAKE YOUR RESER");
                    Console.WriteLine("VATION                        │");
                    Console.Write("└───────────────────────────────────────");
                    Console.WriteLine("──────────────────────────────┘");
                    Console.WriteLine("");
                    Console.Write("             =================SCREEN");
                    Console.WriteLine("=================");
                    Console.Write("");
                    Console.Write(" ROW  ┌──────────────────────SEAT NO.");
                    Console.WriteLine("─────────────────────┐");
                    seatArray[0, 0] = "A";
                    seatArray[1, 0] = "B";
                    seatArray[2, 0] = "C";
                    seatArray[3, 0] = "D";

                    for (j = 0; j < seatArray.GetLength(0); j++)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] != null)
                            {
                                if (i == 0)
                                {
                                    Console.Write(" [" + seatArray[j, i] + "] ");
                                }
                                else
                                {
                                    if (seatArray[j, i].Length >= 1 &&
                                        seatArray[j, i].Length <= 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                            .PadRight(4) + ": " + "■" + "] ");
                                    }
                                    else if (seatArray[j, i].Length > 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                        .Substring(0, 4) + ": " + "■" + "] ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write(" [Seat: " + i + "] ");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("                          ");
                    Console.WriteLine("[■] = Occupied");
                    Console.Write("──────────────────────────");
                    Console.WriteLine("─────────────────────────────────");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    // Ask to input booking name
                    do
                    {
                        Console.Write("Pleaes write your booking name: ");
                        userName = Console.ReadLine().ToUpper();
                        userName = userName.Replace("|", "");
                        if (userName.Length < 2)
                        {

                            Console.Write("***Please wtire your booking name");
                            Console.WriteLine(" at least two characters.***");
                            userName = "";
                        }

                    } while (userName == "");

                    // Check Occupied seat Loop
                    bool seat = true;
                    while (seat)
                    {
                        // Ask to input seat ROW
                      do
                      {
                       Console.Write("Please choose your seat ROW[A to D]: ");
                       seatRow = Console.ReadLine().ToUpper();
                      } while (seatRow != "A" && seatRow != "B" &&
                               seatRow != "C" && seatRow != "D");

                        switch (seatRow)
                        {
                            case "A":
                                j = 0;
                                break;
                            case "B":
                                j = 1;
                                break;
                            case "C":
                                j = 2;
                                break;
                            case "D":
                                j = 3;
                                break;
                        }

                        // Ask to input seat number
                        do
                        {
                            Console.Write("Please choose your");
                            Console.Write(" seat Number[1 to 5]: ");
                            stringSeat = Console.ReadLine();
                        } while (stringSeat != "1" && stringSeat != "2" &&
                                 stringSeat != "3" && stringSeat != "4" &&
                                 stringSeat != "5");
                        seatNumber = int.Parse(stringSeat);

                        // Check seat is empty or not
                        Console.WriteLine();
                        Console.WriteLine(" Select seat: " + seatRow.ToUpper()
                            + seatNumber);
                        Console.WriteLine("");
                        if (seatArray[j, seatNumber] == null)
                        {
                            seat = false;
                        }
                        else
                        {
                            Console.WriteLine("******OCCUPIED SEAT******");
                            Console.WriteLine("Please choose other seat.");
                            Console.WriteLine();
                            seat = true;
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("────────────────────Your reservation");
                    Console.WriteLine(" seat─────────────────");
                    Console.Write("             =================SCREEN");
                    Console.WriteLine("=================");
                    Console.WriteLine("");
                    Console.Write(" ROW  ┌──────────────────────SEAT NO.");
                    Console.WriteLine("─────────────────────┐");
                    seatArray[0, 0] = "A";
                    seatArray[1, 0] = "B";
                    seatArray[2, 0] = "C";
                    seatArray[3, 0] = "D";
                    seatArray[j, seatNumber] = userName;
                    for (j = 0; j < seatArray.GetLength(0); j++)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] != null)
                            {
                                if (i == 0)
                                {
                                    Console.Write(" [" + seatArray[j, i] + "] ");
                                }
                                else
                                {
                                    if (seatArray[j, i].Length >= 1 &&
                                        seatArray[j, i].Length <= 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                            .PadRight(4) + ": " + "■" + "] ");
                                    }
                                    else if (seatArray[j, i].Length > 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                        .Substring(0, 4) + ": " + "■" + "] ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write(" [Seat: " + i + "] ");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("                          ");
                    Console.WriteLine("[■] = Selected");
                    Console.Write("──────────────────────────");
                    Console.WriteLine("─────────────────────────────────");
                    Console.WriteLine("");

                    //File IO: lead the file.
                    StreamWriter writer;
                    writer = new StreamWriter("data.txt");
                    try
                    {
                        for (j = 0; j < seatArray.GetLength(0); j++)
                        {
                            for (int i = 0; i < seatArray.GetLength(1); i++)
                            {
                                if (i < 5)
                                {
                                    writer.Write(seatArray[j, i] + "|");
                                }
                                else if (i == 5)
                                {
                                    writer.Write(seatArray[j, i]);
                                }
                            }
                            writer.WriteLine();
                        }
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }

                }

                // Option 2 Check booking
                else if (userOption == "2")
                {
                    Console.Write("┌───────────────────────────────────");
                    Console.WriteLine("──────────────────────────────────┐");
                    Console.Write("│                     2. CHECK YOUR ");
                    Console.WriteLine("RESERVATION                       │");
                    Console.Write("└──────────────────────────────────────");
                    Console.WriteLine("───────────────────────────────┘");
                    Console.WriteLine("");
                    Console.Write("────────────────────Seat Information");
                    Console.WriteLine("──────────────────────");
                    Console.WriteLine("");
                    Console.Write("             =================SCREEN");
                    Console.WriteLine("=================");
                    Console.WriteLine("");
                    Console.Write(" ROW  ┌──────────────────────SEAT NO.");
                    Console.WriteLine("─────────────────────┐");
                    seatArray[0, 0] = "A";
                    seatArray[1, 0] = "B";
                    seatArray[2, 0] = "C";
                    seatArray[3, 0] = "D";
                    for (int j = 0; j < seatArray.GetLength(0); j++)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] != null)
                            {
                                if (i == 0)
                                {
                                    Console.Write(" [" + seatArray[j, i] + "] ");
                                }
                                else
                                {
                                    if (seatArray[j, i].Length >= 1 &&
                                        seatArray[j, i].Length <= 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                            .PadRight(4) + ": " + "■" + "] ");
                                    }
                                    else if (seatArray[j, i].Length > 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                        .Substring(0, 4) + ": " + "■" + "] ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write(" [Seat: " + i + "] ");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("────────────────────────────────");
                    Console.WriteLine("───────────────────────────");
                    Console.WriteLine("");

                    do
                    {
                        Console.Write(" Pleaes write your booking name: ");
                        checkName = Console.ReadLine().ToUpper();
                        if (checkName.Length < 2)
                        {

                            Console.Write("***Please wtire your booking name");
                            Console.WriteLine(" at least two characters.***");
                            checkName = "";
                        }
                    } while (checkName == "");


                    seatArray[0, 0] = "A";
                    seatArray[1, 0] = "B";
                    seatArray[2, 0] = "C";
                    seatArray[3, 0] = "D";
                    for (int j = 0; j < seatArray.GetLength(0); j++)
                    {
                        Console.WriteLine();
                        for (int i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] != null)
                            {
                                if (i == 0)
                                {
                                    Console.Write(" [" + seatArray[j, i] + "] ");
                                }
                                else
                                {
                                    if (seatArray[j, i].Length >= 1 &&
                                        seatArray[j, i].Length <= 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                            .PadRight(4) + ": " + "■" + "] ");
                                    }
                                    else if (seatArray[j, i].Length > 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                        .Substring(0, 4) + ": " + "■" + "] ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write(" [Seat: " + i + "] ");
                            }
                        }
                    }
                    Console.WriteLine("");

                    // Display reservation seat or not
                    bool empty = true;
                    Console.WriteLine("");
                    Console.WriteLine(" User name: " + checkName);
                    for (int j = 0; j < seatArray.GetLength(0); j++)
                    {
                        for (int i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] == checkName)
                            {
                                Console.WriteLine("  Booking seat is ["
                                    + (Char)(j + 65) + i + "]");
                                empty = false;
                            }
                        }
                    }
                    while (empty)
                    {
                        Console.Write(" There is no reservation");
                        Console.WriteLine(" seat in your name");
                        empty = false;
                    }
                }

                // Option 3 Cancel booking
                else if (userOption == "3")
                {
                    int j = 0;
                    int i = 0;
                    bool empty = true;
                    Console.Write("┌───────────────────────────────────");
                    Console.WriteLine("──────────────────────────────────┐");
                    Console.Write("│                     3. CANCEL YOUR ");
                    Console.WriteLine("RESERVATION                      │");
                    Console.Write("└─────────────────────────────────────");
                    Console.WriteLine("────────────────────────────────┘");
                    Console.WriteLine("");
                    Console.Write("────────────────────Seat Information");
                    Console.WriteLine("──────────────────────");
                    Console.WriteLine("");
                    Console.Write("             =================SCREEN");
                    Console.WriteLine("=================");
                    Console.WriteLine("");
                    Console.Write(" ROW  ┌──────────────────────SEAT NO.");
                    Console.WriteLine("─────────────────────┐");
                    seatArray[0, 0] = "A";
                    seatArray[1, 0] = "B";
                    seatArray[2, 0] = "C";
                    seatArray[3, 0] = "D";
                    for (j = 0; j < seatArray.GetLength(0); j++)
                    {
                        Console.WriteLine();
                        for (i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] != null)
                            {
                                if (i == 0)
                                {
                                    Console.Write(" [" + seatArray[j, i] + "] ");
                                }
                                else
                                {
                                    if (seatArray[j, i].Length >= 1 &&
                                        seatArray[j, i].Length <= 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                            .PadRight(4) + ": " + "■" + "] ");
                                    }
                                    else if (seatArray[j, i].Length > 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                       .Substring(0, 4) + ": " + "■" + "] ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write(" [Seat: " + i + "] ");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("───────────────────────────");
                    Console.WriteLine("────────────────────────────────");
                    Console.WriteLine("");

                    do
                    {
                        Console.Write(" Pleaes write your booking name: ");
                        cancelName = Console.ReadLine().ToUpper();
                        if (cancelName.Length < 2)
                        {
                         Console.Write("***Please wtire your booking ");
                         Console.WriteLine("name at least two characters.***");
                         cancelName = "";
                        }
                    } while (cancelName == "");

                    seatArray[0, 0] = "A";
                    seatArray[1, 0] = "B";
                    seatArray[2, 0] = "C";
                    seatArray[3, 0] = "D";
                    for (j = 0; j < seatArray.GetLength(0); j++)
                    {
                        Console.WriteLine();
                        for (i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] != null)
                            {
                                if (i == 0)
                                {
                                    Console.Write(" ["
                                        + seatArray[j, i] + "] ");
                                }
                                else
                                {
                                    if (seatArray[j, i].Length >= 1 &&
                                        seatArray[j, i].Length <= 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                            .PadRight(4) + ": " + "■" + "] ");
                                    }
                                    else if (seatArray[j, i].Length > 4)
                                    {
                                        Console.Write(" [" + seatArray[j, i]
                                        .Substring(0, 4) + ": " + "■" + "] ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write(" [Seat: " + i + "] ");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(" User name: " + cancelName);

                    for (j = 0; j < seatArray.GetLength(0); j++)
                    {
                        for (i = 0; i < seatArray.GetLength(1); i++)
                        {
                            if (seatArray[j, i] == cancelName)
                            {
                                Console.WriteLine(" Booking seat is ["
                                    + (Char)(j + 65) + i + "]");
                                empty = false;
                            }
                        }
                    }
                    Console.WriteLine("");

                    if (empty == false)
                    {
                        bool cancelSeat = true;
                        bool exitCancel = true;
                        while (cancelSeat)
                        {
                            // Ask to input seat ROW
                            do
                            {
                                Console.Write(" Please choose");
                                Console.WriteLine(" you want to cancel seat.");
                                Console.Write("  [If you want exit cacel ");
                                Console.WriteLine("booking, write \"exit\"]");
                                Console.Write("  Cancel seat ROW [A to D]: ");
                                seatRow = Console.ReadLine().ToUpper();
                            } while (seatRow != "A" && seatRow != "B" &&
                                     seatRow != "C" && seatRow != "D" &&
                                     seatRow != "EXIT");

                            switch (seatRow)
                                {
                                    case "A":
                                        j = 0;
                                    exitCancel = true;
                                    break;
                                    case "B":
                                        j = 1;
                                    exitCancel = true;
                                    break;
                                    case "C":
                                        j = 2;
                                    exitCancel = true;
                                    break;
                                    case "D":
                                        j = 3;
                                    exitCancel = true;
                                    break;
                                    case "EXIT":
                                    exitCancel = false;
                                    cancelSeat = false;
                                    break;
                                }

                            while (exitCancel)
                            {
                                //Ask to input seat number
                             do
                             {
                              Console.Write("  Cancel seat Number[1 to 5]: ");
                              stringSeat = Console.ReadLine();
                             } while (stringSeat != "1" && stringSeat != "2" &&
                                      stringSeat != "3" && stringSeat != "4" &&
                                      stringSeat != "5");
                                seatNumber = int.Parse(stringSeat);

                                switch (seatNumber)
                                {
                                    case 1:
                                        i = 1;
                                        break;
                                    case 2:
                                        i = 2;
                                        break;
                                    case 3:
                                        i = 3;
                                        break;
                                    case 4:
                                        i = 4;
                                        break;
                                    case 5:
                                        i = 5;
                                        break;
                                }

                                Console.WriteLine();
                                Console.WriteLine("  Cancel seat is: "
                                    + seatRow.ToUpper() + seatNumber);
                                Console.WriteLine("");
                                if (seatArray[j, i] == cancelName)
                                {
                                    seatArray[j, i] = null;
                                    cancelSeat = false;
                                    exitCancel = false;
                                }
                                else
                                {
                                    Console.Write(" ***It is not your");
                                    Console.WriteLine(" booking seat***");
                                    Console.Write(" Please choose your");
                                    Console.WriteLine(" booking seat.");
                                    Console.WriteLine();
                                    cancelSeat = true;
                                    exitCancel = false;
                                }                          

                          Console.WriteLine("");
                          Console.Write("────────────────────Seat Infor");
                          Console.WriteLine("mation──────────────────────");
                          Console.Write("             =================SC");
                          Console.WriteLine("REEN=================");
                          Console.WriteLine("");
                          Console.Write(" ROW  ┌──────────────────────SEAT");
                          Console.WriteLine(" NO.─────────────────────┐");
                            seatArray[0, 0] = "A";
                            seatArray[1, 0] = "B";
                            seatArray[2, 0] = "C";
                            seatArray[3, 0] = "D";
                            for (j = 0; j < seatArray.GetLength(0); j++)
                            {
                                Console.WriteLine();
                                for (i = 0; i < seatArray.GetLength(1); i++)
                                {
                                    if (seatArray[j, i] != null)
                                    {
                                        if (i == 0)
                                        {
                                            Console.Write(" ["
                                                + seatArray[j, i] + "] ");
                                        }
                                        else
                                        {
                                         if (seatArray[j, i].Length >= 1 &&
                                             seatArray[j, i].Length <= 4)
                                          {
                                           Console.Write(" [" + seatArray[j, i]
                                           .PadRight(4) + ": " + "■" + "] ");
                                          }
                                         else if (seatArray[j, i].Length > 4)
                                         {
                                          Console.Write(" [" + seatArray[j, i]
                                         .Substring(0, 4) + ": " + "■" + "] ");
                                         }
                                        }
                                    }
                                    else
                                    {
                                        Console.Write(" [Seat: " + i + "] ");
                                    }
                                }
                                }
                                Console.WriteLine("");
                            }
                        }
                            Console.WriteLine("");
                        while (seatRow == "A" && seatRow == "B" &&
                                     seatRow == "C" && seatRow == "D")
                        {
                          Console.WriteLine(" Cancel your booking seat: " + "["
                                + seatRow.ToUpper() + seatNumber + "]");
                          Console.Write("──────────────────────────────────");
                          Console.WriteLine("─────────────────────");
                          Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.Write(" There is no reservation seat");
                        Console.WriteLine(" in your name");
                    }

                    //File IO: write the file.
                    StreamWriter writer;
                    writer = new StreamWriter("data.txt");
                    try
                    {
                        for (j = 0; j < seatArray.GetLength(0); j++)
                        {
                            for (i = 0; i < seatArray.GetLength(1); i++)
                            {
                                if (i < 5)
                                {
                                    writer.Write(seatArray[j, i] + "|");
                                }
                                else if (i == 5)
                                {
                                    writer.Write(seatArray[j, i]);
                                }
                            }
                            writer.WriteLine();
                        }
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }
                }

                // Option 4 start
                else if (userOption == "4")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you See you again:)");
                    Console.WriteLine("");
                    return;
                }

                do
                {
                    Console.WriteLine("");
                    Console.Write("┌──────────────────────────────────────");
                    Console.WriteLine("───────────────────────────────┐");
                    Console.Write("│                     1. RETURN TO MAIN");
                    Console.WriteLine(" MENU                          │");
                    Console.Write("│                     2. EXIT PROGRAM");
                    Console.WriteLine("                                 │");
                    Console.Write("└─────────────────────────────────────");
                    Console.WriteLine("────────────────────────────────┘");
                    Console.Write(" Choose the option 1 or 2 : ");
                    lastQuestion = Console.ReadLine();
                    switch (lastQuestion)
                    {             
                    case "1":
                        Console.Clear();
                        break;
                    case "2":
                            Console.WriteLine("");
                            Console.WriteLine("Thank you See you again:)");
                            Console.WriteLine("");
                            return;
                    }
                } while (lastQuestion != "1" && lastQuestion != "2");
            } while (true);
        }
    }
}