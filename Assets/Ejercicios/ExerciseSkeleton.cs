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
    // COMPLETADO
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
    // [COMPLETADO]
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
    // [COMPLETADO]
    private List<int> CreateCountdown(int start = 5)
    {

        // Escribe tu solución aquí y devuelve el resultado.    
        List<int> countdown = new List<int>();
        
        while (start >= 0)
        {
            countdown.Add(start);
            start--;
        }
        Debug.Log("Cuenta regresiva: " + countdown);
        return countdown;
    }

    // 4. Recorre el arreglo y muestra la suma de todos sus elementos.
    // Resultado esperado: 19
    // Ejemplo: "La suma es 19".
    // [COMPLETADO}
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
    // [COMPLETADO]
    private bool ContainsNumber(int[] numbers = null, int target = 2)
    {
        if (numbers == null) { numbers = new int[] { 4, 9, 2, 7 }; }

        // Escribe tu solución aquí y devuelve el resultado.
        bool isCorrectNumber = false;

        foreach(int number in numbers)
        {
            if(number == target)
            {
                isCorrectNumber = true;
            }
        }

        Debug.Log($"¿Número objetivo encontrado? -> {isCorrectNumber}");
        return isCorrectNumber;
    }

    // 6. Cuenta cuántas veces aparece "Ana" y muestra el resultado.
    // Resultado esperado: 2
    // [COMPLETADO]
    private int CountNames(string[] names = null)
    {
        if (names == null) { names = new string[] { "Ana", "Luis", "Ana", "Sofía" }; }

        // Escribe tu solución aquí y devuelve el resultado.
        int repeatedName = 0;

        foreach (string name in names)
        {
            if(name == "Ana")
            {
                repeatedName++;
            }
        }

        return repeatedName;
    }

    // 7. Muestra cada número en orden inverso, sin modificar la lista original.
    // Resultado esperado: [3, 2, 1]
    // [COMPLETADO]
    private List<int> CreateReversedList(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 1, 2, 3 }; }

        // Escribe tu solución aquí y devuelve el resultado.
        List<int> reversedList = new List<int>(numbers);
        reversedList.Reverse();
        Debug.Log("Lista inversa: " +  reversedList.Count);
        return reversedList;
    }

    // 8. Recorre el diccionario y muestra cada objeto con su cantidad.
    // Resultado esperado: { "Pociones": 3, "Llaves": 2, "Espadas": 1 }
    // Ejemplo: "Pociones: 3".
    // [COMPLETADO]
    private Dictionary<string, int> GetInventory(Dictionary<string, int> inventory = null)
    {
        if (inventory == null) { inventory = new Dictionary<string, int> { { "Pociones", 3 }, { "Llaves", 2 }, { "Espadas", 1 } }; }

        // Escribe tu solución aquí y devuelve el resultado.
        Debug.Log(inventory.Count);
        return inventory;
    }

    // 9. Encuentra y muestra el número mayor de la lista no vacía.
    // Resultado esperado: 12
    // [COMPLETADO]
    private int FindLargestInList(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { -4, 12, 7, 12, 3 }; }

        // Escribe tu solución aquí y devuelve el resultado.
        int maximunNumber = -9999; // No recuerdo si hay una manera de no inicializar la variable local, pero Unity me lo pide si no no arranca, entonces lo tengo que dejan en un Magic Number =(
        foreach(int number in numbers)
        {
            if(maximunNumber < number)
            {
                maximunNumber = number;
            }
        }
        Debug.Log("El número mayor es: " +  maximunNumber);
        return maximunNumber;
    }

    // 10. Agrega los números sin repetir a la lista uniqueNumbers y muestra sus elementos.
    // Resultado esperado: [3, 1, 2, 4]
    // Conserva el orden de la primera aparición. Ejemplo: 3, 1, 2, 4.
    // [COMPLETADO]
    private List<int> GetUniqueNumbers(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 3, 1, 3, 2, 1, 4 }; }
        List<int> uniqueNumbers = new List<int>();

        // Escribe tu solución aquí y devuelve el resultado.
        int unnecesaryNumber = 0;
        foreach(int number in numbers)
        {
            if(uniqueNumbers.Contains(number))
            {
                unnecesaryNumber = number;
            }
            else
            {
                uniqueNumbers.Add(number);
            }
        }
        unnecesaryNumber = 0;
        Debug.Log("La lista sin números repetidos es: " + uniqueNumbers.Count);
        return uniqueNumbers;
    }

    #endregion Methods
}
