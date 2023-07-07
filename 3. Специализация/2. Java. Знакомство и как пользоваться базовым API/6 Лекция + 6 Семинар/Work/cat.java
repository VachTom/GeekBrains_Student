package Work;
// Реализовать класс Cat для вет. клиники

// Добавить в него поля:
// Имя, возраст, Привит ли кот (boolean), дефолт - false, пол
// Добавить методы:
// Кот Имя мяукнул n раз
// Прививка кота, если был привит - сообщить об этом
// Так же придумать 1-2 своих метода

public class cat {
  String name = "";
  Integer age;
  Boolean vaccine = false;
  Boolean sex = false;
  Integer lives_limit = 9;

  public int car_accident() {
    if (lives_limit != 0) {
      lives_limit--;
    }
    if (lives_limit == 0) {
      System.out.println("R.I.P.");
    }
    return age;
  }

  public void vaccine() {
    if (!vaccine) {
      this.vaccine = true;
      System.out.println(this.name + "Is vaccinated! PAY!");
    } else {

    }
    System.out.println(this.name + "Is vaccinated! FEED!");
  }
}