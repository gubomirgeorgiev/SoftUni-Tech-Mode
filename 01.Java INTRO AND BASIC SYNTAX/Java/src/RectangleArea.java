import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double width = Double.parseDouble(console.nextLine());
        double height = Double.parseDouble(console.nextLine());
        System.out.printf("%.2f", width*height);
    }
}
