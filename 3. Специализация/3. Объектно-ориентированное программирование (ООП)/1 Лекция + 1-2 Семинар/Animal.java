
public class Animal {
  private String name;
  private Integer age;
  private String vaccination; // прививка
  private String color;
  private String species; // вид
  private String owner;// хозятг
  private Integer legsCount; // кол-во лапок

  public Animal(String name, Integer age,
      String vaccination, String color,
      String species, String owner, 
      Integer legsCount) {

    this.name = name;
    this.age = age;
    this.vaccination = vaccination;
    this.color = color;
    this.species = species;
    this.owner = owner;
    this.legsCount = legsCount;
  }

  public Animal(String color, String species,
      Integer legsCount) {
    this(null, null, null,
        color, species, null, legsCount);
    // выделяем память в комп под отд обьект. Это как new Animal - создание
  }

  public Integer getAge() {
    int count = 0;
    return age;
  }

  public void setAge(Integer age) {
    this.age = age;
  }

  public static void foo() {
    System.out.println("I'm Foo");
  }

}