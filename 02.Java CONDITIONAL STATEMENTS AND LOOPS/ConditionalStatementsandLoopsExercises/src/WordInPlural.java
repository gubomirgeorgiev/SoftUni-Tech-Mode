import java.util.Scanner;

public class WordInPlural {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        String output="";
        int i = input.length();
        if (input.endsWith("y"))
        {
            output = input.replace("y","ies") ;
        }
        else if (input.endsWith("o") ||  input.endsWith("s") ||  input.endsWith("x") || input.endsWith("z") || input.endsWith("ch") || input.endsWith("sh"))
        {
            output = input + "es";
        }
        else
        {
            output = input + "s";
        }
        System.out.println(output);
    }
}
