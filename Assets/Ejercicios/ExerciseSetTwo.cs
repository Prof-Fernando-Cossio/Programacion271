using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;

public class ExerciseSetTwo : MonoBehaviour
{
    #region Methods

    // 1. Cuenta los números positivos del arreglo; el cero no es positivo.
    // Resultado esperado: 3
    //COMPLETADO
    private int CountPositiveNumbers(int[] numbers = null)
    {
        if (numbers == null) { numbers = new int[] { 4, -1, 0, 8, 2 }; }

        int totalOfNumbers = 0;
        foreach(int number in numbers)
        {
            if (number > 0)
            {
                totalOfNumbers++;
            }
        }

        Debug.Log($"Total de números positivos: {totalOfNumbers}");
        return totalOfNumbers;
    }

    // 2. Calcula el factorial de un entero no negativo. El factorial de 0 es 1.
    // Trabaja con valores entre 0 y 12 para que el resultado quepa en un int.
    // Resultado esperado: 120
    //COMPLETADO
    private int CalculateFactorial(int number = 5)
    {
        int finalNumber = 1;

        for(int i = 1; i <= number; i++)
        {
            finalNumber *= i;
        }

        Debug.Log($"Número factorial: {finalNumber}");
        return finalNumber;
    }

    // 3. Cuenta las vocales inglesas (a, e, i, o, u) de un texto, sin distinguir mayúsculas.
    // El texto siempre es distinto de null; no cuentes vocales acentuadas.
    // Resultado esperado: 5
    //COMPLETADO
    private int CountVowels(string text = "Murcielago")
    {
        char vocal = ' ';
        int totalOfVocals = 0;

        for(int i = 0; i < text.Length; i++)
        {
            vocal = text[i];

            if(vocal == 'a' || vocal == 'A')
            {
                totalOfVocals++;
            }
            if (vocal == 'e' || vocal == 'E')
            {
                totalOfVocals++;
            }
            if (vocal == 'i' || vocal == 'I')
            {
                totalOfVocals++;
            }
            if (vocal == 'o' || vocal == 'O')
            {
                totalOfVocals++;
            }
            if (vocal == 'u' || vocal == 'U')
            {
                totalOfVocals++;
            }
            vocal = ' ';
        }

        Debug.Log($"Número de vocales encontradas: {totalOfVocals}");
        return totalOfVocals;
    }

    // 4. Comprueba si un texto es palíndromo, leyendo igual de izquierda a derecha y viceversa.
    // El texto no contiene espacios, siempre es distinto de null y distingue mayúsculas.
    // Una cadena vacía también es palíndromo.
    // Resultado esperado: true
    //COMPLETADO
    private bool IsPalindrome(string text = "radar")
    {
        List<char> originalText = new List<char>();
        List<char> backwardsText = new List<char>();

        foreach (char c in text)
        {
            originalText.Add(c);
            backwardsText.Add(c);
        }
        backwardsText.Reverse();

        if (originalText.SequenceEqual(backwardsText)) { return true; }
        else { return false; }
    }

    // 5. Devuelve una lista nueva con los números pares de la lista recibida, en su orden original.
    // No modifiques la lista recibida. Cero es par y se conservan los valores repetidos.
    // Resultado esperado: [2, 4, 2]
    //COMPLETADO
    private List<int> GetEvenNumbers(List<int> numbers = null)
    {
        if (numbers == null) { numbers = new List<int> { 1, 2, 3, 4, 2 }; }

        List<int> evenNumbers = new List<int>();
        foreach(int number in numbers)
        {
            if(number % 2 == 0 || number == 0)
            {
                evenNumbers.Add(number);
            }
        }
        return evenNumbers;
    }

    // 6. Atiende a la primera persona de la cola: quítala y devuelve su nombre.
    // Si la cola está vacía, devuelve null sin modificarla.
    // Resultado esperado: "Ana"; la cola queda ["Luis", "Sofía"].
    //COMPLETADO
    private string ServeNextPerson(Queue<string> people = null)
    {
        if (people == null) { people = new Queue<string>(new[] { "Ana", "Luis", "Sofía" }); }

        if (people.Count() == 0)
        {
            return null;
        }

        string dequeuedPerson = people.Dequeue();
        return dequeuedPerson;
    }

    // 7. Agrega la persona indicada al final de la cola y devuelve esa misma cola.
    // El nombre siempre es distinto de null. Modifica la cola recibida.
    // Resultado esperado: ["Ana", "Luis", "Sofía"].
    //COMPLETADO
    private Queue<string> AddPersonToQueue(Queue<string> people = null, string person = "Sofía")
    {
        if (people == null) { people = new Queue<string>(new[] { "Ana", "Luis" }); }

        people.Enqueue(person);
        return people;
    }

    // 8. Cuenta cuántas veces aparece el número objetivo en el arreglo.
    // Resultado esperado: 3
    //COMPLETADO
    private int CountOccurrences(int[] numbers = null, int target = 2)
    {
        if (numbers == null) { numbers = new int[] { 2, 4, 2, 1, 2 }; }

        int totalOfTargetedNumber = 0;
        foreach(int number in numbers)
        {
            if(number == target)
            {
                totalOfTargetedNumber++;
            }
        }
        return totalOfTargetedNumber;
    }

    // 9. Suma los números enteros desde 1 hasta el número indicado, incluyéndolo.
    // El número es no negativo; para 0 devuelve 0. Usa valores entre 0 y 65535.
    // Resultado esperado: 15
    //COMPLETADO
    private int SumUpTo(int number = 5)
    {
        int SumOfNumbers = 0;
        for(int i = 0; i <= number; i++)
        {
            SumOfNumbers = SumOfNumbers + i;
        }
        return SumOfNumbers;
    }

    // 10. Devuelve una nueva cadena con los caracteres del texto en orden inverso.
    // El texto siempre es distinto de null.
    // Resultado esperado: "aloH"
    //COMPLETADO
    private string ReverseText(string text = "Hola")
    {
        List<char> reversedText = new List<char>();
        foreach(char c in text)
        {
            reversedText.Add(c);
        }
        reversedText.Reverse();
        string newText = string.Join("",reversedText);
        return newText;
    }

    #endregion Methods
}
