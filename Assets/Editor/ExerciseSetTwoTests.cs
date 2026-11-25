using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;

// Coloca este archivo en Assets/Editor; comprueba ExerciseSetTwo.
public class ExerciseSetTwoTests
{
    #region Variables

    private GameObject _gameObject;
    private ExerciseSetTwo _exercises;

    #endregion Variables

    on Methods

    [SetUp]
    public void SetUp()
    {
        _gameObject = new GameObject("Exercise set two tests");
        _exercises = _gameObject.AddComponent<ExerciseSetTwo>();
    }

    [TearDown]
    public void TearDown()
    {
        Object.DestroyImmediate(_gameObject);
    }

    [Test]
    public void CountPositiveNumbers_HandlesEmptyZerosAndNegatives()
    {
        Assert.AreEqual(3, InvokeDefault<int>("CountPositiveNumbers"));
        Assert.AreEqual(0, Invoke<int>("CountPositiveNumbers", new int[0]));
        Assert.AreEqual(0, Invoke<int>("CountPositiveNumbers", new int[] { -2, 0, -1 }));
        Assert.AreEqual(2, Invoke<int>("CountPositiveNumbers", new int[] { 3, -9, 3 }));
    }

    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(5, 120)]
    [TestCase(7, 5040)]
    [TestCase(12, 479001600)]
    public void CalculateFactorial_ReturnsProduct(int number, int expected)
    {
        Assert.AreEqual(expected, Invoke<int>("CalculateFactorial", number));
    }

    [TestCase("Murcielago", 5)]
    [TestCase("AEIOU", 5)]
    [TestCase("xyz", 0)]
    [TestCase("", 0)]
    [TestCase("áéíóú", 0)]
    [TestCase("Aa", 2)]
    public void CountVowels_CountsEnglishVowelsIgnoringCase(string text, int expected)
    {
        Assert.AreEqual(expected, Invoke<int>("CountVowels", text));
    }

    [TestCase("radar", true)]
    [TestCase("", true)]
    [TestCase("a", true)]
    [TestCase("abba", true)]
    [TestCase("hola", false)]
    [TestCase("Aa", false)]
    public void IsPalindrome_ChecksBothDirections(string text, bool expected)
    {
        Assert.AreEqual(expected, Invoke<bool>("IsPalindrome", text));
    }

    [Test]
    public void GetEvenNumbers_PreservesOrderDuplicatesAndInput()
    {
        List<int> input = new List<int> { -2, 3, 0, 4, -2 };
        List<int> result = Invoke<List<int>>("GetEvenNumbers", input);

        CollectionAssert.AreEqual(new[] { -2, 0, 4, -2 }, result);
        CollectionAssert.AreEqual(new[] { -2, 3, 0, 4, -2 }, input);
        Assert.AreNotSame(input, result);
        CollectionAssert.IsEmpty(Invoke<List<int>>("GetEvenNumbers", new List<int>()));
        CollectionAssert.AreEqual(new[] { 2, 4, 2 }, InvokeDefault<List<int>>("GetEvenNumbers"));
    }

    [Test]
    public void ServeNextPerson_RemovesAndReturnsFront()
    {
        Queue<string> people = new Queue<string>(new[] { "Marta", "Luis", "Ana" });
        Assert.AreEqual("Marta", Invoke<string>("ServeNextPerson", people));
        CollectionAssert.AreEqual(new[] { "Luis", "Ana" }, people);
        Assert.AreEqual("Luis", Invoke<string>("ServeNextPerson", people));
        CollectionAssert.AreEqual(new[] { "Ana" }, people);
    }

    [Test]
    public void ServeNextPerson_HandlesEmptyAndDefaultQueues()
    {
        Queue<string> empty = new Queue<string>();
        Assert.IsNull(Invoke<string>("ServeNextPerson", empty));
        Assert.IsEmpty(empty);
        Assert.AreEqual("Ana", InvokeDefault<string>("ServeNextPerson"));
    }

    [Test]
    public void AddPersonToQueue_AddsToEndOfSameQueue()
    {
        Queue<string> people = new Queue<string>(new[] { "Luis", "Ana" });
        Queue<string> result = Invoke<Queue<string>>("AddPersonToQueue", people, "Marta");

        Assert.AreSame(people, result);
        CollectionAssert.AreEqual(new[] { "Luis", "Ana", "Marta" }, people);
        Queue<string> empty = new Queue<string>();
        Assert.AreSame(empty, Invoke<Queue<string>>("AddPersonToQueue", empty, "Eva"));
        CollectionAssert.AreEqual(new[] { "Eva" }, empty);
        CollectionAssert.AreEqual(new[] { "Ana", "Luis", "Sofía" }, InvokeDefault<Queue<string>>("AddPersonToQueue"));
    }

    [Test]
    public void CountOccurrences_CountsMatchingNumbers()
    {
        Assert.AreEqual(3, InvokeDefault<int>("CountOccurrences"));
        Assert.AreEqual(0, Invoke<int>("CountOccurrences", new int[0], 2));
        Assert.AreEqual(0, Invoke<int>("CountOccurrences", new int[] { 1, 3 }, 2));
        Assert.AreEqual(2, Invoke<int>("CountOccurrences", new int[] { -1, 0, -1 }, -1));
    }

    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(5, 15)]
    [TestCase(10, 55)]
    [TestCase(65535, 2147450880)]
    public void SumUpTo_ReturnsSum(int number, int expected)
    {
        Assert.AreEqual(expected, Invoke<int>("SumUpTo", number));
    }

    [TestCase("Hola", "aloH")]
    [TestCase("", "")]
    [TestCase("a", "a")]
    [TestCase("a b", "b a")]
    [TestCase("abba", "abba")]
    public void ReverseText_ReturnsReversedCharacters(string text, string expected)
    {
        Assert.AreEqual(expected, Invoke<string>("ReverseText", text));
    }

    [Test]
    public void ScalarDefaults_ReturnOriginalExamples()
    {
        Assert.AreEqual(120, InvokeDefault<int>("CalculateFactorial"));
        Assert.AreEqual(5, InvokeDefault<int>("CountVowels"));
        Assert.IsTrue(InvokeDefault<bool>("IsPalindrome"));
        Assert.AreEqual(15, InvokeDefault<int>("SumUpTo"));
        Assert.AreEqual("aloH", InvokeDefault<string>("ReverseText"));
    }

    private T InvokeDefault<T>(string methodName)
    {
        MethodInfo method = GetExercise<T>(methodName);
        ParameterInfo[] parameters = method.GetParameters();
        object[] arguments = new object[parameters.Length];

        for (int i = 0; i < arguments.Length; i++) { arguments[i] = System.Type.Missing; }

        return (T)method.Invoke(_exercises, arguments);
    }

    private T Invoke<T>(string methodName, params object[] arguments)
    {
        MethodInfo method = GetExercise<T>(methodName);
        return (T)method.Invoke(_exercises, arguments);
    }

    private MethodInfo GetExercise<T>(string methodName)
    {
        MethodInfo method = typeof(ExerciseSetTwo).GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.IsNotNull(method, "No se encontró el método " + methodName);
        Assert.AreEqual(typeof(T), method.ReturnType, "El tipo de retorno no coincide.");
        return method;
    }

    #endregion Methods
}
