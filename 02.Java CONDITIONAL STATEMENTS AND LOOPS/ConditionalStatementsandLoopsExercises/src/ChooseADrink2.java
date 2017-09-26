import java.util.Scanner;

public class ChooseADrink2 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        int quantity = Integer.parseInt(console.nextLine());
        switch (input) {
            case "Athlete":
                System.out.printf("The %s has to pay %.2f.", input, (quantity*0.7));
                break;
            case "Businessman":
            case "Businesswoman":
                System.out.printf("The %s has to pay %.2f.", input, (quantity*1.0));
                break;
            case "SoftUni Student":
                System.out.printf("The %s has to pay %.2f.", input, (quantity*1.7));
                break;
            default:
                System.out.printf("The %s has to pay %.2f.", input, (quantity*1.2));
                break;
        }
    }
}
