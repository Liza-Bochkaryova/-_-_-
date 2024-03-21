using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog("Барс");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        ISwimming duck = new Duck("Элвин");
        duck.Swim();

    }
}
public abstract class Animal
{
    protected string name;

    public Animal(string name)
    {
        this.name = name;
    }
    public virtual void MakeSound()
    {
        Debug.Log($"{name} makes a soind.");
    }

}
public class Dog : Animal
{
    public static int DogCount = 0;

    public Dog(string name) : base(name)
    {
        DogCount++;
    }

    public override void MakeSound()
    {
        Debug.Log($"{name} barks.");
    }

    public static void PrintHowManyDogs()
    {
        Debug.Log($"There are {DogCount} dogs");
    }
}

public interface ISwimming
{
    void Swim();

}

public class Duck : Animal, ISwimming
{
    public Duck(string name) : base(name) { }

    public override void MakeSound()
    {
        Debug.Log($"{name} quaks. ");
    }

    public void Swim()
    {
        Debug.Log($"{name} swims.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Барс");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        Duck duck = new Duck("Элвин");
        duck.MakeSound();
        duck.Swim();
    }

}

/* Задание
1. Создайте абстрактный класс `Animal` с защищенной переменной `name` и конструктором, который принимает имя животного. Добавьте виртуальный метод `MakeSound`, который будет переопределен в дочерних классах.

2. Создайте класс `Dog`, который наследует от `Animal`. В этом классе добавьте статическую переменную `dogCount` и конструктор, который увеличивает `dogCount` при создании нового объекта `Dog`. Переопределите метод `MakeSound` для класса `Dog`. Добавьте статический метод `HowManyDogs`, который выводит количество созданных объектов `Dog`.

3. Создайте интерфейс `ISwimming` с методом `Swim`.

4. Создайте класс `Duck`, который наследует от `Animal` и реализует интерфейс `ISwimming`. Переопределите метод `MakeSound` и реализуйте метод `Swim` для класса `Duck`.

5. В главном методе программы создайте объекты `Dog` и `Duck`, вызовите их методы `MakeSound` и `Swim` (для `Duck`), а также статический метод `HowManyDogs` класса `Dog`.
*/