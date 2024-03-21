using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    struct MyStruct
    {
        public int X;
        public int Y;
    }

    void Start()
    {
        #region ������� 1

        /*1. �������� ���������� ��������� ����� ������:
         * int, float, bool, string. 
         * �������� �� myInt, myFloat, myBool, myString ��������������.
         * ����� �������� ��������� � ���� �� ������ ������ � 
         * �������� �� myConstInt, myConstFloat, myConstBool, myConstString.
         * �������� ������������ � ������������� ����������� ����� � ����� �����������.
        */

        //������������ �����������
        int myInt = 20; // �������� ���������� ���� int
        float myFloat = 1.25f; // �������� ���������� ���� float
        bool myBool = false; // �������� ���������� ���� bool
        string myString = "��������� "; // �������� ���������� ���� string

        /* ������������� �����������
           ���������� ��������
        */

        const int myConstInt = 200; // �������� ���������� ���� const int
        const float myConstFloat = 100.5f; // �������� ���������� ���� const float
        const bool myConstBool = false; // �������� ���������� ���� const bool
        const string myConstString = "�������������"; // �������� ���������� ���� const string

        Debug.Log(myConstString);
        Debug.Log(myString);

        #region �����
        /*
        // ������������ �����������
        int myInt = 10; // ���������� ���������� ���� int
        float myFloat = 20.5f; // ���������� ���������� ���� float
        bool myBool = true; // ���������� ���������� ���� bool
        string myString = "Hello, World!"; // ���������� ���������� ���� string
        */
        /* ������������� �����������
           ���������� �������� 
        const int myConstInt = 100;
        const float myConstFloat = 200.5f;
        const bool myConstBool = false;
        const string myConstString = "Hello, Universe!";
        */

        #endregion

        #endregion

        #region ������� 2

        /*2. ����������� ��������� ���������� � ��������� +, -.
         * ��������� �������� ���������� myInt � myConstInt. ��������� ��������� � ���������� ���� int, �� ����� resultInt.
         * ��������� ��������� ���������� myConstFloat �� ���������� myFloat. ��������� ��������� � ���������� ���� float, �� ����� resultFloat.
         * ��������� �������� (������������) ��������� ���������� myString � myConstString. ��������� ��������� � ���������� ���� string, �� ����� resultString.
        */

        int resultInt = myInt + myConstInt; // �������� int
        float resultFloat = myFloat - myConstFloat; // ��������� float
        string resultString = myString + myConstString; // ������������ �����

        Debug.Log(resultString);

        #region �����
        /*
        int resultInt = myInt + myConstInt; // �������� int
        float resultFloat = myFloat - myConstFloat; // ��������� float
        string resultString = myString + myConstString; // ������������ �����
        */
        #endregion

        #endregion

        #region ������� 3

        /*3. ����������� �������������� ������� Math.Sqrt �� ���������� myInt. ��������� ��������� � ���������� ���� double ��� ��������� sqrtResult.
         * ����������� �������������� ������� Math.Pow �� ���������� myFloat, ��������� myFloat �� ������ �������. ��������� ��������� � ���������� ���� double ��� ��������� powResult.
        */

        double sqrtResult = Math.Sqrt(myInt); // ������ ����������
        double powResult = Math.Pow(myFloat, 2); // ���������� � �������

        Debug.Log(sqrtResult);
        Debug.Log(Math.Sqrt(5));

        #region �����
        /*
        double sqrtResult = Math.Sqrt(myInt); // ������ ����������
        double powResult = Math.Pow(myFloat, 2); // ���������� � �������
        */
        #endregion

        #endregion

        #region ������� 4

        /*4. ����������� ����� � ������� �������������� ����� ������ � ������� �������� � �������.
         * �������� ���������� ���� double ��� ��������� myDouble � �������� ������� �������������� ���������� myInt. �������� � ������� ���������.
         * �������� ���������� ���� int ��� ��������� myNewInt � �������� ����� �������������� ���������� myFloat � ���� int. �������� � ������� ���������.
        */

        // ������� ��������������
        double myDouble = myInt;
        Debug.Log(myDouble);

        // ����� ��������������
        int myNewInt = (int)myFloat;
        Debug.Log(myNewInt);

        #region �����
        /*
        // ������� ��������������
        double myDouble = myInt;
        Debug.Log(myDouble);

        // ����� ��������������
        int myNewInt = (int)myFloat;
        Debug.Log(myNewInt);
        */
        #endregion

        #endregion

        #region ������� 5

        //5. �������� ������ ��� ������ myArray � � ����� ������ string, ��������������� ��� ����� ����������� ��������� ������. ����������� �������� ������� ��� ������ � �������.

        string[] myArray = new string[3] { "����", "���", "���" };
        Debug.Log(myArray[0]);
        Debug.Log(myArray[1]);
        Debug.Log(myArray[2]);

        #region �����
        /*
        string[] myArray = new string[3] {"One", "Two", "Three"};
        Debug.Log(myArray[0]);
        Debug.Log(myArray[1]);
        Debug.Log(myArray[2]);
        */
        #endregion

        #endregion

        #region ������� 6

        /*6. �������� ���� ��� ������ myList � ����� ������ int, �������� � ���� ����� 1, 2, 3, ��������� ������ Add. 
         * �������� � ������� �������� ��������� ������. 
         * ������� ����� �������� ��������� ������� Remove, RemoveAt.
        */

        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Debug.Log(myList[0]);
        Debug.Log(myList[1]);
        Debug.Log(myList[2]);
        myList.Remove(0);
        myList.RemoveAt(2);
        Debug.Log(myList[0]);


        #region �����
        /*
        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Debug.Log(myList[0]);
        Debug.Log(myList[1]);
        Debug.Log(myList[2]);
        myList.Remove(2);
        myList.RemoveAt(0);
        */
        #endregion

        #endregion

        #region ������� 7

        /*7. �������� ��������� ��� ������ MyStruct. �������� � ��������� ���������� ���� int ��� ������ X � ������ Y.
         * �������� ���������� � ����� ��������� MyStruct � ������ myStruct.
         * ������������������ ���������� myStruct, ������� �������� ���������� X � Y.
         * �������� � ������� �������� ���������� X � Y �� ��������� myStruct.
        */

        MyStruct myStruct;
        myStruct.X = 20;
        myStruct.Y = myInt + myConstInt;
        Debug.Log(myStruct.X);
        Debug.Log(myStruct.Y);

        #region �����
        /*
        struct MyStruct
        {
            public int X;
            public int Y;
        }

        MyStruct myStruct;
        myStruct.X = 10;
        myStruct.Y = 20;
        Debug.Log(myStruct.X);
        Debug.Log(myStruct.Y);
        */
        #endregion

        #endregion

        #region ������� 8

        //8. �������� ������� � ������� ����������, ������ �� �������� ���������� myInt ��� 0. ����������� if else � �������� � ������� ������ ������.

        bool condition = true;

        if (myInt > 0 && condition)
        {
            Debug.Log("�������!");
        }
        else
        {
            Debug.Log("�� �������...");
        }

        #region �����
        /*
        if (myInt > 0)
        {
            Debug.Log("myInt is positive.");
        }
        else
        {
            Debug.Log("myInt is not positive.");
        }
        */
        #endregion

        #endregion

        #region ������� 9

        //9. ����������� switch ��� �������� ��� ��������� � ���������� myString. ����������� ��������� case � default. �������� � ������� ������ ������.

        switch (myString)
        {
            case "��������� ":
                Debug.Log("�� �������");
                break;
            case "�������������":
                Debug.Log("�� ���������");
                break;
            default:
                Debug.Log("Unknown greeting.");
                break;
        }

        #region �����
        /*
        switch (myString)
        {
            case "Hello, World!":
                Debug.Log("Greeting the world.");
                break;
            case "Hello, Universe!":
                Debug.Log("Greeting the universe.");
                break;
            default:
                Debug.Log("Unknown greeting.");
                break;
        }
        */
        #endregion

        #endregion

        #region ������� 10

        /* 10. ����������� ���� for ��� ������ ���� �������� ������� myArray.
         * ����������� ���� while ��� �������� ���� ��������� ������ myList � ������� ������ RemoveAt(0).
         * ���������� �������� ���������� myInt ������ 10. ����������� ���� do while ��� ���� ����� ������� �������� ���������� myInt �� 0. �������� �� ������ ���� � ������� �������� myInt. 
        */

        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log(myArray[i]); // ����� ��������� ������� 
        }
        while (myList.Count > 0)
        {
            Debug.Log(myList[0]); // ����� ������� �������� ������ 
            myList.RemoveAt(0); // �������� ������� �������� ������ 
        }

        myInt = 7;
        do
        {
            Debug.Log(myInt); // ����� �������� myInt 
            myInt--; // ���������� �������� myInt �� 1 
        } while (myInt > 0);

        #region �����
        /*
        for (int i = 0; i < myArray.Length; i++) { 
            Debug.Log(myArray[i]); // ����� ��������� ������� 
        } 
        while (myList.Count > 0) { 
            Debug.Log(myList[0]); // ����� ������� �������� ������ 
            myList.RemoveAt(0); // �������� ������� �������� ������ 
        } 
        do { 
            Debug.Log(myInt); // ����� �������� myInt 
            myInt--; // ���������� �������� myInt �� 1 
        } while (myInt > 0); 
        */
        #endregion

        #endregion

        #region ������� 11

        //11. �������� ������� ��� ������������� �������� � ��� ���������� � ������ MyFunction. �������� � ���� ���� ������� ����� ���������� � �������. �������� ��� ������� �� ������ �����.

        void MyFunction()
        {
            Debug.Log("��� ��� ������� -_-"); // ����� ��������� 
        }
        MyFunction(); // ����� ������� 

        #region �����
        /*
        void MyFunction() { 
            Debug.Log("This is my function."); // ����� ��������� 
        } 
        MyFunction(); // ����� ������� 
        */
        #endregion

        #endregion

        #region ������� 12

        //12. �������� ������� ��� ������������� �������� � ����������� � ������ MyFunctionWithParameters. ��������� �������� param1 � param2. param1 ��� ������������� ���, � param2 - ���������. �������� � ������� �������� ���������� � ���� ���� �������. �������� ��� ������� �� ������ �����.

        void MyFunctionWithParameters(string param1, int param2)
        {
            Debug.Log("��� �� ��� ��� �������, �� ��� � �����������: " + param1 + ", " + param2 + " -_-"); // ����� ��������� � ����������� 
        }
        MyFunctionWithParameters(myString, myInt); // ����� ������� � �����������

        #region �����
        /*
        void MyFunctionWithParameters(int param1, string param2) { 
            Debug.Log("This is my function with parameters: " + param1 + ", " + param2); // ����� ��������� � ����������� 
        } 
        MyFunctionWithParameters(myInt, myString); // ����� ������� � �����������
        */
        #endregion

        #endregion

        #region ������� 13
        //13. �������� ������� � ������������ ��������� � ����������� � ������ MyFunctionWithReturnValueAndParameters. ��������� �������� param1 � param2. ��� ��������� �������������. ������� � ������� return ����� ���� ����������.

        Debug.Log(myInt);
        Debug.Log(myConstInt);

        int MyFunctionWithReturnValueAndParameters(int param1, int param2)
        {
            return param1 + param2; // ������� ����� ���������� 
        }
        int result = MyFunctionWithReturnValueAndParameters(myInt, myConstInt); // ����� ������� � ����������� � ���������� ���������� 
        Debug.Log(result); // ����� ����������

        #region �����
        /*
        int MyFunctionWithReturnValueAndParameters(int param1, int param2) { 
            return param1 + param2; // ������� ����� ���������� 
        } 
        int result = MyFunctionWithReturnValueAndParameters(myInt, myConstInt); // ����� ������� � ����������� � ���������� ���������� 
        Debug.Log(result); // ����� ����������
        */
        #endregion
        #endregion

        GetComponent<Rigidbody>().AddForce(Vector3.up * 15, ForceMode.VelocityChange);
    }
}
