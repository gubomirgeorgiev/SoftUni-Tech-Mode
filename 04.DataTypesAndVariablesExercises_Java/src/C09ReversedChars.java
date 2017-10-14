import java.util.Scanner;

public class C09ReversedChars {
    public static void main(String[] args) {
    Scanner console = new Scanner(System.in);
    StringBuilder charsToReverse = new StringBuilder();
        charsToReverse.insert(0,console.nextLine().charAt(0));
        charsToReverse.insert(1,console.nextLine().charAt(0));
        charsToReverse.insert(2,console.nextLine().charAt(0));
        charsToReverse.reverse();
        System.out.println(charsToReverse);
    }
}
