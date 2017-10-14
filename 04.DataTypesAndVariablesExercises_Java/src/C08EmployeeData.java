import java.util.Scanner;

public class C08EmployeeData {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String firstName = console.nextLine();
        String lastName = console.nextLine();
        int age = Integer.parseInt(console.nextLine());
        char gender = console.nextLine().charAt(0);
        long personalId = Long.parseLong(console.nextLine());
        int uniqueEmployeeNumber = Integer.parseInt(console.nextLine());
        System.out.printf("First name: %s%nLast name: %s%nAge: %d%nGender: %s%nPersonal ID: %d%nUnique Employee " +
                "number: %d",firstName,lastName,age,gender,personalId,uniqueEmployeeNumber);
    }
}
