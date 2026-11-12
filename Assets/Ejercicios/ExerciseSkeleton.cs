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
    // returnear el resultado - mandarlo en debug
    private bool IsEven(int number = 7)
    {

        // Escribe tu solución aquí y devuelve el resultado.
        
        //METODO DE PROFESOR
        bool isEven = number % 2 == 0;
        Debug.Log(isEven ? "Par" : "Impar");
        return isEven;


        // isEven? es un operador terniario, es una pregunta, simepre la primera pregunta es si es "true"

        /* MI METODO
        float currentNumber;
        bool isEven;

        if(number % 2 == 0)
        {
            number = currentNumber;
            isEven = true;
        }
        else
        {
            number = currentNumber;
            isEven = false;
        }

        Debug.Log(currentNumber + ", " + isEven);
        return currentNumber, isEven;

        */
    }

    // 2. Muestra el mayor de los tres números. Considera que pueden ser iguales.
    // Resultado esperado: 12
    private int FindLargestOfThree(int firstNumber = 12, int secondNumber = 12, int thirdNumber = 5)
    {

        // Escribe tu solución aquí y devuelve el resultado.
        int highestNumber = firstNumber;

        if (highestNumber < secondNumber)
        { 
            highestNumber = secondNumber;
        }
        if (highestNumber < thirdNumber)
        {
            highestNumber = thirdNumber;
        }

        Debug.Log(highestNumber);
        return highestNumber;

    }

    // 3. Muestra una cuenta regresiva desde el valor inicial no negativo hasta cero, un mensaje por número.
    // Resultado esperado: [5, 4, 3, 2, 1, 0]
    private List<int> CreateCountdown(int start = 5)
    {

        // Escribe tu solución aquí y devuelve el resultado.
        throw new System.NotImplementedException();
        //List<int> listOfNumbers = new List<int>();
    }

    // 4. Recorre el arreglo y muestra la suma de todos sus elementos.
    // Resultado esperado: 19
    // Ejemplo: "La suma es 19".
    private int CalculateSum(int[] numbers = null)
    {
        int totalOfNumbers = 0;

        if (numbers == null) { numbers = new int[] { 3, 5, 2, 8, 1 }; }


        // Escribe tu solución aquí y devuelve el resultado.
        foreach(int number in numbers)
        {
            totalOfNumbers += number;
        }

        Debug.Log($"La suma es: {totalOfNumbers}");
        return totalOfNumbers;
    }

    // 5. Busca el objetivo en el arreglo y muestra si se encuentra o no.
    // Resultado esperado: true (indica que se encontró el número).
    private bool ContainsNumber(int[] numbers = null, int target = 2)
    {
        if (numbers == null) { numbers = new int[] { 4, 9, 2, 7 }; }

        // Escribe tu solución aquí y devuelve el resultado.
        bool isCorrectNumber = false;

        foreach(int number in numbers)
        {
            if(number == target)
            {
                return isCorrectNumber = true;
            }
            else
            {
                return isCorrectNumber = false;
            }
        }

        Debug.Log(isCorrectNumber);
        return isCorrectNumber;
    }

    // 6. Cuenta cuántas veces aparece "Ana" y muestra el resultado.
    // Resultado esperado: 2
    private int CountNames(string[] names = null)
    {
        if (names == null) { names = new string[] { "Ana", "Luis", "Ana", "Sofía" }; }

        // Escribe tu solución aquí y devuelve el resultado.
        throw new System.NotImplementedException();
    }

    // 7. Muestra cada número en orden inverso, sin modificar la lista original.
    // Resultado esperado: [3, 2, 1]
    private List<int> CreateReversedList(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 1, 2, 3 }; }

        // Escribe tu solución aquí y devuelve el resultado.
        throw new System.NotImplementedException();
    }

    // 8. Recorre el diccionario y muestra cada objeto con su cantidad.
    // Resultado esperado: { "Pociones": 3, "Llaves": 2, "Espadas": 1 }
    // Ejemplo: "Pociones: 3".
    private Dictionary<string, int> GetInventory(Dictionary<string, int> inventory = null)
    {
        if (inventory == null) { inventory = new Dictionary<string, int> { { "Pociones", 3 }, { "Llaves", 2 }, { "Espadas", 1 } }; }

        // Escribe tu solución aquí y devuelve el resultado.
        throw new System.NotImplementedException();
    }

    // 9. Encuentra y muestra el número mayor de la lista no vacía.
    // Resultado esperado: 12
    private int FindLargestInList(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { -4, 12, 7, 12, 3 }; }

        // Escribe tu solución aquí y devuelve el resultado.
        throw new System.NotImplementedException();
    }

    // 10. Agrega los números sin repetir a la lista uniqueNumbers y muestra sus elementos.
    // Resultado esperado: [3, 1, 2, 4]
    // Conserva el orden de la primera aparición. Ejemplo: 3, 1, 2, 4.
    private List<int> GetUniqueNumbers(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 3, 1, 3, 2, 1, 4 }; }
        List<int> uniqueNumbers = new List<int>();

        // Escribe tu solución aquí y devuelve el resultado.
        throw new System.NotImplementedException();
    }

    #endregion Methods
}
