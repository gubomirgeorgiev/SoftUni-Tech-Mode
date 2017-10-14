import java.util.Scanner;

public class C12RectangleProperties {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double width = Double.parseDouble(console.nextLine());
        double height = Double.parseDouble(console.nextLine());
        if (((2*width)+(2*height))%1==0){
            int resultInInt = (int) ((2*width)+(2*height));
            System.out.println(resultInInt);
        }else{
            System.out.println((2*width)+(2*height));
        }
        if ((width* height)%1==0){
            int resultInInt = (int) (width* height);
            System.out.println(resultInInt);
        }else{
            System.out.println(width* height);
        }
        if ((Math.sqrt(Math.pow(width,2)+Math.pow(height, 2)))%1==0){
            int resultInInt = (int) (Math.sqrt(Math.pow(width,2)+Math.pow(height, 2)));
            System.out.println(resultInInt);
        }else{
            System.out.printf("%.12f",(double)(Math.sqrt(Math.pow(width,2)+Math.pow(height, 2))));
        }
    }
}
