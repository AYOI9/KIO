
        int x, y, biggerNumber, cube;

        Console.WriteLine("Введите целое число x:");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите целое число y:");
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            biggerNumber = x;
        }
        else
        {
            biggerNumber = y;
        }

        cube = biggerNumber * biggerNumber * biggerNumber;

        Console.WriteLine("Куб большего из чисел: " + cube);
  
