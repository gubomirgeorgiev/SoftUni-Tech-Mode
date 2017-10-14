import java.util.Scanner;

public class P07ExchangeVariableValues {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int a = Integer.parseInt(console.nextLine());
        int b = Integer.parseInt(console.nextLine());
        int temp;
        temp = b;
        b = a;
        System.out.printf("Before:%na = %d%nb = %d%nAfter:%na = %d%nb = %d",b,temp,temp,a);
    }
}
