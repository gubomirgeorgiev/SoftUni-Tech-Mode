import java.util.Scanner;

public class MilesToKm {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double miles = Double.parseDouble(console.nextLine());
        double oneKm = 1.60934;
        System.out.printf("%.2f", miles*oneKm);
    }
}
