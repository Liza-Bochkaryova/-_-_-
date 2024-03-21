using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog("����");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        ISwimming duck = new Duck("�����");
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
        Dog dog = new Dog("����");
        dog.MakeSound();
        Dog.PrintHowManyDogs();

        Duck duck = new Duck("�����");
        duck.MakeSound();
        duck.Swim();
    }

}

/* �������
1. �������� ����������� ����� `Animal` � ���������� ���������� `name` � �������������, ������� ��������� ��� ���������. �������� ����������� ����� `MakeSound`, ������� ����� ������������� � �������� �������.

2. �������� ����� `Dog`, ������� ��������� �� `Animal`. � ���� ������ �������� ����������� ���������� `dogCount` � �����������, ������� ����������� `dogCount` ��� �������� ������ ������� `Dog`. �������������� ����� `MakeSound` ��� ������ `Dog`. �������� ����������� ����� `HowManyDogs`, ������� ������� ���������� ��������� �������� `Dog`.

3. �������� ��������� `ISwimming` � ������� `Swim`.

4. �������� ����� `Duck`, ������� ��������� �� `Animal` � ��������� ��������� `ISwimming`. �������������� ����� `MakeSound` � ���������� ����� `Swim` ��� ������ `Duck`.

5. � ������� ������ ��������� �������� ������� `Dog` � `Duck`, �������� �� ������ `MakeSound` � `Swim` (��� `Duck`), � ����� ����������� ����� `HowManyDogs` ������ `Dog`.
*/