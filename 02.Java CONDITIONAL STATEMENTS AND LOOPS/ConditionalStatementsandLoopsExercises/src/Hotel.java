import java.util.Scanner;

public class Hotel {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String month = console.nextLine();
        double nights = 1;
        nights = Integer.parseInt(console.nextLine());
        switch (month)
        {
            case "May": case "October":
            if (nights > 7)
            {
                if (month.equals("October"))
                {
                    double freeDay = nights;
                    freeDay--;
                    System.out.printf("Studio: %.02f lv.%n",(50 * 0.95 * freeDay));
                }
                else {
                    System.out.printf("Studio: %.02f lv.%n",(50 * 0.95 * nights));
                }
            }
            else
            {
                System.out.printf("Studio: %.02f lv.%n",(50 * nights));
            }
            System.out.printf("Double: %.02f lv.%n",(65 * nights));
            System.out.printf("Suite: %.02f lv.%n",(75 * nights));
            break;
            case "June": case "September":
            if (month.equals("September") && nights > 7)
            {
                double freeDay = nights;
                freeDay--;
                System.out.printf("Studio: %.02f lv.%n",(60 * freeDay));
            }
            else
            {
                System.out.printf("Studio: %.02f lv.%n",(60 * nights));
            }
            if (nights > 14)
            {
                System.out.printf("Double: %.02f lv.%n",(72 * 0.9 * nights));
            }
            else
            {
                System.out.printf("Double: %.02f lv.%n",(72 * nights));
            }
            System.out.printf("Suite: %.02f lv.%n",(82 * nights));
            break;
            case "July": case "August": case "December":
            System.out.printf("Studio: %.02f lv.%n",(68 * nights));
            System.out.printf("Double: %.02f lv.%n",(77 * nights));
            if (nights > 14)
            {
                System.out.printf("Suite: %.02f lv.%n",(89 * 0.85 * nights));
            }
            else
            {
                System.out.printf("Suite: %.02f lv.%n",(89 * nights));
            }
            break;
        }
    }
}
