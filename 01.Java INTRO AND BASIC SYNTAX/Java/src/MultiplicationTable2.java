import java.util.Scanner;

public class MultiplicationTable2 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int num = Integer.parseInt(console.nextLine());
        int multiplicNum = Integer.parseInt(console.nextLine());
        if (multiplicNum <= 10) {
            for (int i = multiplicNum; i <= 10; i++)
            {
                System.out.println(num +" X " + i + " = " + (num * i));
            }
        }
        else
        {
            System.out.println(num +" X " + multiplicNum + " = " + (num * multiplicNum));
        }
    }
}
