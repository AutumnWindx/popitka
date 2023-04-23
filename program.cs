static void Sum(int num1, int num2)
{
  int sum = num1 + num2;
  Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
}

static void DisplayString(string message)
{
  Console.WriteLine(message);
}

static int FindMax(int[] arr)
{
  int max = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] > max)
    {
      max = arr[i];
    }
  }
  return max;
}

static void CheckEvenOdd(int num)
{
  if (num % 2 == 0)
  {
    Console.WriteLine("{0} is even", num);
  }
  else
  {
    Console.WriteLine("{0} is odd", num);
  }
}
