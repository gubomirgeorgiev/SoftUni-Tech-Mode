import java.util.Scanner;

public class TestNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int N = Integer.parseInt(console.nextLine());
        int M = Integer.parseInt(console.nextLine());
        int max = Integer.parseInt(console.nextLine());
        int sum = 0;
        int counter = 0;
        int stopCounter = 0;
        int stopSum=0;
        for (int i=N; i>=1; i--)
        {
            for (int j = 1; j<=M; j++)
            {
                sum = sum + (3 * (i * j));
                counter ++;
                try
                {
                    if (sum >= max)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    stopSum = sum;
                    stopCounter = counter;
                    i = 0;
                    j = 0;
                    break;
                }
            }
        }
        if (sum >= max)
        {
            System.out.printf("%d combinations%n",stopCounter);
            System.out.printf("Sum: %d >= %d",stopSum,max);
        } else
        {
            System.out.printf("%d combinations%n", counter);
            System.out.printf("Sum: %d", sum);
        }
    }
}
