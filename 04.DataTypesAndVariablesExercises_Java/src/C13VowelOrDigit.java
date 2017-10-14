import java.util.Scanner;

public class C13VowelOrDigit {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        char symbol = console.nextLine().charAt(0);
        String vowel = "aeiouy";
        if (vowel.contains(Character.toString(symbol))) {
            System.out.println("vowel");
        } else {
            try {
                int symbolIsNumber = Integer.parseInt(Character.toString(symbol));
                System.out.println("digit");
            } catch (Exception e) {
                System.out.println("other");
            }
        }
    }
}
