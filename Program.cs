using System;

namespace TriangleAssignment 
{
    class TTriangleAssigmentclass
    {    

        public static void Main()
        {
            int MenuInput = 0;
            double x = 0, y = 0, z = 0;

            Boolean LoopContinue = true;

            while (LoopContinue == true)
            {
                LoopContinue = true;
                while (LoopContinue == true)
                {
                    try
                    {
                        Console.Write("Menu:  \n 1. Enter Triangle Dimensions \n 2. Exit \n");
                        MenuInput = Convert.ToInt32(Console.ReadLine());
                        LoopContinue = false;
                    }

                    catch
                    {
                        Console.Write("Invalid input entered. Please re-eneter valid numeric value.\n");
                        LoopContinue = true;
                    }
                }
                if (MenuInput == 1 || MenuInput == 2)
                {
                    if (MenuInput == 1)
                    {
                        LoopContinue = true;
                        while (LoopContinue == true)
                        {
                            try
                            {
                                Console.Write("Input the first value x :");
                                x = Convert.ToDouble(Console.ReadLine());
                                LoopContinue = false;
                            }
                            catch
                            {
                                Console.Write("Invalid input entered. Please re-eneter valid numeric value for x.\n");
                                LoopContinue = true;
                            }
                        }
                        LoopContinue = true;
                        while (LoopContinue == true)
                        {
                            try
                            {
                                Console.Write("Input the second value y :");
                                y = Convert.ToDouble(Console.ReadLine());
                                LoopContinue = false;
                            }
                            catch
                            {
                                Console.Write("Invalid input entered. Please re-eneter valid numeric value for y.\n");
                                LoopContinue = true;
                            }
                        }
                        LoopContinue = true;
                        while (LoopContinue == true)
                        {
                            try
                            {
                                Console.Write("Input the third value z :");
                                z = Convert.ToDouble(Console.ReadLine());
                                LoopContinue = false;
                            }
                            catch
                            {
                                Console.Write("Invalid input entered. Please re-eneter valid numeric value for z.\n");
                                LoopContinue = true;
                            }
                        }

                        Console.WriteLine("\n" + TriangleSolver.Analyze(x, y, z));
                        LoopContinue = true;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("Invalid input entered.\n");
                    LoopContinue = true;
                }

            }

        }
    }
}
