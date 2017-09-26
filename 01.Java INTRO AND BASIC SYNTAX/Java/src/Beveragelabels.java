import java.text.DecimalFormat;
import java.util.Scanner;

public class Beveragelabels {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String name = console.nextLine();
        double beverageVolume = Double.parseDouble(console.nextLine());
        double energyContentPer100Ml = Double.parseDouble(console.nextLine());
        double sugarContentPer100Ml = Double.parseDouble(console.nextLine());
        DecimalFormat format = new DecimalFormat("#.##");
        System.out.printf("%dml %s:%n", (int)beverageVolume,name);
        System.out.printf(String.format("%skcal, %sg sugars", format.format(((beverageVolume/100)* energyContentPer100Ml)),format.format(((beverageVolume / 100) * sugarContentPer100Ml))));
    }
}
