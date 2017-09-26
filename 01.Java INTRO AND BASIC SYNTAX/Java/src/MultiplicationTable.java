import java.util.Scanner;

public class MultiplicationTable {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int num = Integer.parseInt(console.nextLine());
        for (int i = 1; i <= 10; i++) {
            System.out.println(num + " X " + i + " = " + (num*i));
        }
    }
}
