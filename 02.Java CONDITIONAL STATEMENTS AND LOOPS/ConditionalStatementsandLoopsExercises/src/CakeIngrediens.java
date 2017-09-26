import java.util.Scanner;

public class CakeIngrediens {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int brake = 21;
        int counter = 0;

        for (int i = 0; i < brake; i++) {
            String ingredient = console.nextLine();
            if (ingredient.equals("Bake!")) {
                brake = 0;
                System.out.printf("Preparing cake with %d ingredients.", counter);
            } else {
                System.out.printf("Adding ingredient %s.%n", ingredient);
                counter++;
            }
        }
    }
}
