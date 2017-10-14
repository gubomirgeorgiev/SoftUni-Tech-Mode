public class P06StringsAndObjects {
    public static void main(String[] args) {
        String helloStr = "Hello";
        String worldStr = "World";
        Object concatenateStringsinObject = helloStr + " " + worldStr;
        String result = concatenateStringsinObject.toString();
        System.out.println(result);
    }
}
