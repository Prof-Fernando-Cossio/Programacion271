using System.Collections.Generic;
using UnityEngine;

// Agrega este componente a un GameObject para ejecutar tus soluciones.
public class ExerciseSkeleton : MonoBehaviour
{
    #region Unity Methods

    private void Start()
    {
        IsEven();
        FindLargestOfThree();
        CreateCountdown();
        CalculateSum();
        ContainsNumber();
        CountNames();
        CreateReversedList();
        GetInventory();
        FindLargestInList();
        GetUniqueNumbers();
    }

    #endregion Unity Methods

    #region Methods

    // 1. Determina si el número entero es par o impar. Muestra el resultado.
    // Resultado esperado: false (true indica que el número es par).
    // Ejemplo: "7 es impar".
    private bool IsEven(int number = 7)
    {
        bool result = number % 2 == 0;
        Debug.Log(result ? "Es par" : "es impar");
        return result;
    }

    // 2. Muestra el mayor de los tres números. Considera que pueden ser iguales.
    // Resultado esperado: 12
    private int FindLargestOfThree(int firstNumber = 12, int secondNumber = 12, int thirdNumber = 5)
    {
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            Debug.Log(firstNumber);
            return firstNumber;
        } else if (secondNumber>=thirdNumber)
        {
            Debug.Log(secondNumber);
            return secondNumber;
        }
        else
        {
            Debug.Log(thirdNumber);
            return thirdNumber;
        }
        throw new System.Exception();
    }

    // 3. Muestra una cuenta regresiva desde el valor inicial no negativo hasta cero, un mensaje por número.
    // Resultado esperado: [5, 4, 3, 2, 1, 0]
    private List<int> CreateCountdown(int start = 5)
    {
        List<int> numberList = new List<int>();
        for(int i = start; i > -1; i--)
        {
            numberList.Add(i);
            Debug.Log(i);
        }
        return numberList;
    }

    // 4. Recorre el arreglo y muestra la suma de todos sus elementos.
    // Resultado esperado: 19
    // Ejemplo: "La suma es 19".
    private int CalculateSum(int[] numbers = null)
    {
        if (numbers == null) { numbers = new int[] { 3, 5, 2, 8, 1 }; }

        int counter = 0;
        for(int i = 0; i < numbers.Length;i++)
        {
            counter += numbers[i];
        }
        return counter;
    }

    // 5. Busca el objetivo en el arreglo y muestra si se encuentra o no.
    // Resultado esperado: true (indica que se encontró el número).
    private bool ContainsNumber(int[] numbers = null, int target = 2)
    {
        if (numbers == null) { numbers = new int[] { 4, 9, 2, 7 }; }

        for (int i=0;i<numbers.Length;i++)
        {
            if (numbers[i] == target) { return true; }
        }
        return false;
    }

    // 6. Cuenta cuántas veces aparece "Ana" y muestra el resultado.
    // Resultado esperado: 2
    private int CountNames(string[] names = null)
    {
        if (names == null) { names = new string[] { "Ana", "Luis", "Ana", "Sofía" }; }

        string nameToCheck = "Ana";
        int counter = 0;
        for(int i = 0; i < names.Length; i++)
        {
            if (names[i] == nameToCheck) { counter++; }
        }
        return counter;
    }

    // 7. Muestra cada número en orden inverso, sin modificar la lista original.
    // Resultado esperado: [3, 2, 1]
    private List<int> CreateReversedList(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 1, 2, 3 }; }

        List<int> reversedList = new List<int>();
        for(int i = numbers.Count-1; i >= 0; i--)
        {
            reversedList.Add(numbers[i]);
        }
        return reversedList;
    }

    // 8. Recorre el diccionario y muestra cada objeto con su cantidad.
    // Resultado esperado: { "Pociones": 3, "Llaves": 2, "Espadas": 1 }
    // Ejemplo: "Pociones: 3".
    private Dictionary<string, int> GetInventory(Dictionary<string, int> inventory = null)
    {
        if (inventory == null) { inventory = new Dictionary<string, int> { { "Pociones", 3 }, { "Llaves", 2 }, { "Espadas", 1 } }; }

        Dictionary<string, int> inventoryDict = new Dictionary<string, int>();
        foreach(var element in inventory)
        {
            Debug.Log($"{element.Key}: {element.Value}");
            inventoryDict.Add(element.Key,element.Value);
        }
        return inventoryDict;
    }

    // 9. Encuentra y muestra el número mayor de la lista no vacía.
    // Resultado esperado: 12
    private int FindLargestInList(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { -4, 12, 7, 12, 3 }; }

        int largest = numbers[0];
        for(int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > largest) { largest = numbers[i]; }
        }
        return largest;
    }

    // 10. Agrega los números sin repetir a la lista uniqueNumbers y muestra sus elementos.
    // Resultado esperado: [3, 1, 2, 4]
    // Conserva el orden de la primera aparición. Ejemplo: 3, 1, 2, 4.
    private List<int> GetUniqueNumbers(List<int> numbers = null)
    {
        bool isRepeated;
        if (numbers == null) { numbers = new List<int> { 3, 1, 3, 2, 1, 4 }; }
        List<int> uniqueNumbers = new List<int>();

        for(int i = 0; i < numbers.Count; i++)
        {
            if (uniqueNumbers.Count == 0) {
                uniqueNumbers.Add(numbers[i]);
            } else
            {
                isRepeated = false;
                for(int j = 0; j < uniqueNumbers.Count; j++)
                {
                    if (uniqueNumbers[j] == numbers[i])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if (!isRepeated) { uniqueNumbers.Add(numbers[i]); }
            }
        }
        return uniqueNumbers;
    }

    #endregion Methods
}
