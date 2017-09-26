import java.util.Scanner;

public class GameOfNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int N = Integer.parseInt(console.nextLine());
        int M = Integer.parseInt(console.nextLine());
        int magicNumber = Integer.parseInt(console.nextLine());
        int counter = 0;
        int numb1=0;
        int numb2 = 0;
        for (int i=N; i<=M; i++)
        {
            for (int j = N; j<=M; j++)
            {
                counter++;
                if (i + j == magicNumber)
                {
                    numb1 = j;
                    numb2 = i;
                }
            }
        }
        if (numb1 != 0)
        {
            System.out.printf("Number found! %d + %d = %d",numb2,numb1,magicNumber);
        }
        else
        {
            System.out.printf("%d combinations - neither equals %d",counter,magicNumber);
        }
    }
}
