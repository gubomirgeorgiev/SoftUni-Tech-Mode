import java.util.Scanner;

public class CharacterStats {
    static String repeatStr(String strToRepeat, int count) {
        String text = "";
        for (int i = 0; i < count; i++) {
            text = text + strToRepeat;
        }
        return text;
    }
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String name = console.nextLine();
        int currentHealth = Integer.parseInt(console.nextLine());
        int maximumHealth = Integer.parseInt(console.nextLine());
        int currentEnergy = Integer.parseInt(console.nextLine());
        int maximumEnergy = Integer.parseInt(console.nextLine());
        System.out.println("Name: "+name);
        System.out.printf("Health: |");System.out.printf(repeatStr("|",currentHealth));System.out.printf(repeatStr(
                ".",(maximumHealth - currentHealth)));System.out.println("|");
        System.out.printf("Energy: |");System.out.printf(repeatStr("|",currentEnergy));System.out.printf(repeatStr(
                ".",(maximumEnergy - currentEnergy)));System.out.println("|");
    }
}
