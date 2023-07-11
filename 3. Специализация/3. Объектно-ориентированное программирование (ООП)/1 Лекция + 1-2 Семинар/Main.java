
public class Main {
  public static void main(String[] args) {
    Animal animal = new Animal("Slon", 32, "true", "Write", "Mamal", "Stas", 4);

    Animal animal1 = new Animal("Black", "Bird", 2);
    System.out.println(animal.getAge());
    animal.setAge(3);
    System.out.println(animal.getAge());
    Animal.foo();
    
  }
}