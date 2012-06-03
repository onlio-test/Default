package ClassLibrary2;

public class Class2 {

    public int Test(String value) {
        if (value == null) throw new IllegalArgumentException("value is null");
        return value.length();
    }
}
