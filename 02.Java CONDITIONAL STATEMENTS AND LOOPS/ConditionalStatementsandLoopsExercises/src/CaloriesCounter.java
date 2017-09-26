import java.util.Scanner;

public class CaloriesCounter {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int brake = Integer.parseInt(console.nextLine());
        int calories=0;
        for (int i = 0; i < brake; i++)
        {
            String ingredients = console.nextLine();
            if (ingredients.toLowerCase().equals("cheese"))
            {
                calories += 500;
            }
            else if (ingredients.toLowerCase().equals("tomato sauce"))
            {
                calories += 150;
            }
            else if (ingredients.toLowerCase().equals("salami"))
            {
                calories += 600;
            }
            else if (ingredients.toLowerCase().equals("pepper"))
            {
                calories += 50;
            }
        }
        System.out.println("Total calories: "+calories);
    }
}
