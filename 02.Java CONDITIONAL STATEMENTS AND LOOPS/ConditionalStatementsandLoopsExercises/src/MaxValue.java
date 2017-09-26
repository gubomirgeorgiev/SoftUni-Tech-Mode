import java.util.Scanner;

public class MaxValue {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int numberOne = Integer.parseInt(console.nextLine());
        int numberTwo = Integer.parseInt(console.nextLine());
        for (int i = Math.min(numberOne,numberTwo); i <= Math.max(numberOne, numberTwo); i++)
        {
            System.out.println(i);
        }
    }
}
