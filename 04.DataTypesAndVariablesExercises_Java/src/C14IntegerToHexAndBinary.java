import java.util.Scanner;

public class C14IntegerToHexAndBinary {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int num = Integer.parseInt(console.nextLine());
        System.out.println(String.format("%X", num));
        System.out.println(Integer.toBinaryString(num));
    }
}
