
            Console.WriteLine("Simple Calculator \n");


            Console.Write("1.ADDITION \n");
            Console.Write("2.MULTIPLICATION \n");
            Console.Write("3.SUBTRACTION \n ");
            Console.Write("4.DIVISION \n ");
            Console.Write("5.MODULAR \n");

            Console.Write("Enter the Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Input first number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Input second number
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int one = num1 + num2;
                    Console.WriteLine("RESULT =" + one);
                    break;
                case 2:
                    int two = num1 - num2;
                    Console.WriteLine("RESULT =" + two);
                    break;
                case 3:
                    int three = num1 * num2;
                    Console.WriteLine("RESULT =" + three);
                    break;

                case 4:
                    int four = num1 / num2;

                    Console.WriteLine("RESULT =" + four);
                    break;

                case 5:
                    int five = num1 % num2;

                    Console.WriteLine("RESULT =" + five);
                    break;

                default:
                    Console.WriteLine("Error: Invalid choice");

                    break;
            }

        
        
    
  