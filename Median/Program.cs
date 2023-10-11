var calculator = new ContinuousMedianCalculator();

var numbers = new List<int> { 17, 2, 8, 27, 12, 9 };
int id = 1;
foreach (int number in numbers)
{
    calculator.AddNumber(number);
    var median = calculator.GetMedian();
    Console.WriteLine($"{id}: Median after adding {number}: {median}");
    id++;
}

public class ContinuousMedianCalculator
{
    private List<int> numbers = new();

    public void AddNumber(int number)
    {
        numbers.Add(number);
        numbers.Sort();
    }

    public double GetMedian()
    {
        int count = numbers.Count;
        if (count % 2 == 0)
        {
            int first = numbers[(count - 1) / 2];
            int second = numbers[count / 2];
            return (first + second) / 2.0;
        }
        else
        {
            return numbers[count / 2];
        }
    }
}