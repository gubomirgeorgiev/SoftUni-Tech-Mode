import java.util.Scanner;

public class P03PracticeCharsAndStrings {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String firslLine = console.nextLine();
        char secondLine = console.next().charAt(0);
        char thirdLine = console.next().charAt(0);
        char fourthlLine = console.next().charAt(0);console.nextLine();
        String fifthlLine = console.nextLine();
        System.out.printf("%s%n%s%n%s%n%s%n%s",firslLine,secondLine,thirdLine,fourthlLine,fifthlLine);
    }
}
