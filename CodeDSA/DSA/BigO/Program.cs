BigOConstant();
BigOofN();
BigOofNSquare();


//O(1)
//The below method is an example of BigO(1)
static void BigOConstant()
{
    Console.WriteLine("------------------O(1)--------------------");
    Console.WriteLine("The cost of this operation is O(1) ");
    Console.WriteLine("The cost of this operation is O(1) ");
    Console.WriteLine("Total complexity is O(2) .");
    Console.WriteLine("Summary : No matter the number of operations this function has " +
      Environment.NewLine+  "it will always take a constant time to run on a machine ; Hence it is O(1) [BigO of constant / 1.");
}

//O(N)
static void BigOofN()
{
    Console.WriteLine("---------------O(N)-------------------");
    Console.WriteLine("Here the size of the input matters ; The algorithm grows slower linearly " +
        "towards the size of the input ");
    Console.WriteLine("The below operation would take O(2)");
    for (int i = 0; i < 2; i++)
    { Console.WriteLine(i); };


    Console.WriteLine("The below operation would take O(10)");
    for (int i = 0; i < 10; i++)
    { Console.WriteLine(i); };

    Console.WriteLine("To summarize ; O(2) / O(10) could be replaced with the size of the input i.e, O(N)");
}



//O(N^2)
static void BigOofNSquare()
{
    Console.WriteLine("---------------O(N^2)-------------------");
    Console.WriteLine("Here the size of the input matters ; The algorithm is quadratic " +
        "towards the size of the input ");
    Console.WriteLine("The below operation would take O(N) in the first loop and O(N) inside every iteration " +
        "of the first loop causing a quadratic time complexity .");

    for (int i = 0; i < 2; i++)
    { Console.WriteLine(i);

        for (int j = 0; j < 10; j++)
        { Console.WriteLine(j); };
    };


    Console.WriteLine("To summarize ; loops inside loops  could be cause run time of an algo to grow " +
        "slower with increase in size of its input i.e, O(N^2)");
}

//O(logN) more efficient and more scalable. binary search [reducing the input size by half at every iteration]
static void BigOLogN()
{



}


