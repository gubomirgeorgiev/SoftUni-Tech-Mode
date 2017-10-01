import java.util.Scanner;

public class C08RefactorVolumeOfPyramid {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double length, width, heigth, volume = 0;
        System.out.print("Length: ");
        length = Double.parseDouble(console.nextLine());
        System.out.print("Width: ");
        width = Double.parseDouble(console.nextLine());
        System.out.print("Height: ");
        heigth = Double.parseDouble(console.nextLine());
        volume = (length * width * heigth) / 3;
        System.out.printf("Pyramid Volume: %.2f", volume);
    }
}
