import java.util.Scanner;
public class C01CenturiesToMinutes {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.print("Centuries=");
        int centuries = Integer.parseInt(console.nextLine());
        int years = centuries* 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;
        System.out.printf("%s centuries = %s years = %s days = %s hours = %s minutes", centuries, years, days, hours,
                minutes);
    }
}
