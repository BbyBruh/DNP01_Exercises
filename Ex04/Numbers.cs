namespace Ex04;

public class Numbers
{
    public void Even(int x)
    {
        for (int i = 0; i < x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void Uneven(int x)
    {
        for (int i = 0; i < x; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void Divisible(int x, int y)
    {
        for (int i = 0; i < x; i++)
        {
            if (i % y == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}