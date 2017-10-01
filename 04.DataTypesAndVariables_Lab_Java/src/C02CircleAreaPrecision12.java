import java.util.Scanner;

public class C02CircleAreaPrecision12 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double radius = Double.parseDouble(console.nextLine());
        System.out.printf("%.12f", Math.PI*radius*radius);
    }
}
