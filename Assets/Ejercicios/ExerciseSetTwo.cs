using System;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseSetTwo : MonoBehaviour
{
    #region Methods

    // 1. Cuenta los números positivos del arreglo; el cero no es positivo.
    // Resultado esperado: 3
    private int CountPositiveNumbers(int[] numbers = null)
    {
        if (numbers == null) { numbers = new int[] { 4, -1, 0, 8, 2 }; }

        int counter=0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) { counter++; }
        }
        return counter;
    }

    // 2. Calcula el factorial de un entero no negativo. El factorial de 0 es 1.
    // Trabaja con valores entre 0 y 12 para que el resultado quepa en un int.
    // Resultado esperado: 120
    private int CalculateFactorial(int number = 5)
    {
        //if (number < 0) { throw Exception; }
        int x=1;
        for(int i = 2; i <= number; i++)
        {
            x *= i;
        }
        return x;
    }

    // 3. Cuenta las vocales inglesas (a, e, i, o, u) de un texto, sin distinguir mayúsculas.
    // El texto siempre es distinto de null; no cuentes vocales acentuadas.
    // Resultado esperado: 5
    private int CountVowels(string text = "Murcielago")
    {
        int counts=0;
        foreach(char caracter in text)
        {
            if(caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' || caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U')
            {
                counts++;
            }
        }
        return counts;
    }

    // 4. Comprueba si un texto es palíndromo, leyendo igual de izquierda a derecha y viceversa.
    // El texto no contiene espacios, siempre es distinto de null y distingue mayúsculas.
    // Una cadena vacía también es palíndromo.
    // Resultado esperado: true
    private bool IsPalindrome(string text = "radar")
    {
        bool isActuallyPalindrome = true;
        for(int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length-(i + 1)]) { isActuallyPalindrome = false; }
            Debug.Log(text[i] + " " + text[text.Length-(i + 1)]);
        }
        return isActuallyPalindrome;
    }

    // 5. Devuelve una lista nueva con los números pares de la lista recibida, en su orden original.
    // No modifiques la lista recibida. Cero es par y se conservan los valores repetidos.
    // Resultado esperado: [2, 4, 2]
    private List<int> GetEvenNumbers(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 1, 2, 3, 4, 2 }; }

        List<int> evenNumbers = new List<int>();
        foreach(int number in numbers)
        {
            if (number % 2 == 0) { evenNumbers.Add(number); }
        }
        return evenNumbers;
    }

    // 6. Atiende a la primera persona de la cola: quítala y devuelve su nombre.
    // Si la cola está vacía, devuelve null sin modificarla.
    // Resultado esperado: "Ana"; la cola queda ["Luis", "Sofía"].
    private string ServeNextPerson(Queue<string> people = null)
    {
        if (people == null) { people = new Queue<string>(new[] { "Ana", "Luis", "Sofía" }); }

        if (people.Count == 0) { return null; }
        string person = people.Peek();
        people.Dequeue();
        return person;
    }

    // 7. Agrega la persona indicada al final de la cola y devuelve esa misma cola.
    // El nombre siempre es distinto de null. Modifica la cola recibida.
    // Resultado esperado: ["Ana", "Luis", "Sofía"].
    private Queue<string> AddPersonToQueue(Queue<string> people = null, string person = "Sofía")
    {
        if (people == null) { people = new Queue<string>(new[] { "Ana", "Luis" }); }

        people.Enqueue(person);
        return people;
    }

    // 8. Cuenta cuántas veces aparece el número objetivo en el arreglo.
    // Resultado esperado: 3
    private int CountOccurrences(int[] numbers = null, int target = 2)
    {
        if (numbers == null) { numbers = new int[] { 2, 4, 2, 1, 2 }; }

        int counter=0;
        foreach (int number in numbers)
        {
            if (number == target) { counter++; }
        }
        return counter;
    }

    // 9. Suma los números enteros desde 1 hasta el número indicado, incluyéndolo.
    // El número es no negativo; para 0 devuelve 0. Usa valores entre 0 y 65535.
    // Resultado esperado: 15
    private int SumUpTo(int number = 5)
    {
        int sum = 0;
        for(int i = 0; i <= number; i++) { sum += i; }
        return sum;
    }

    // 10. Devuelve una nueva cadena con los caracteres del texto en orden inverso.
    // El texto siempre es distinto de null.
    // Resultado esperado: "aloH"
    private string ReverseText(string text = "Hola")
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        string reversedText=new string(chars);
        return reversedText;
    }

    #endregion Methods
}
