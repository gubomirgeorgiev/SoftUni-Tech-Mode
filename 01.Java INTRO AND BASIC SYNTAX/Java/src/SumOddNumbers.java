import java.util.Scanner;

public class SumOddNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int count = n;
        int forCount = 999;
        int oddCount=0;
        if (count > 0)
        {
            for (int i = 1; i <= forCount; i++)
            {
                if (count > 0)
                {
                    if (i % 2 != 0)
                    {
                        System.out.println(i);
                        oddCount += i;
                        count--;
                    }
                }
                else forCount = 0;
            }
        }
        System.out.println("Sum: "+oddCount);
    }
}
