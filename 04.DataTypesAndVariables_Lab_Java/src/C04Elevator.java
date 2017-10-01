import java.util.Scanner;

public class C04Elevator {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double numberOfPeople = Double.parseDouble(console.nextLine());
        double elevatorsCapacity = Double.parseDouble(console.nextLine());
        int courses = (int)Math.ceil(numberOfPeople / elevatorsCapacity);
        System.out.println(courses);
    }
}
