using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;

// Coloca este archivo en Assets/Editor. Las pruebas revisan ExerciseSkeleton.
public class ExerciseTests
{
    #region Variables

    private GameObject _gameObject;
    private ExerciseSkeleton _exercises;

    #endregion Variables

    #region Methods

    [SetUp]
    public void SetUp()
    {
        _gameObject = new GameObject("Exercise tests");
        _exercises = _gameObject.AddComponent<ExerciseSkeleton>();
    }

    [TearDown]
    public void TearDown()
    {
        Object.DestroyImmediate(_gameObject);
    }

    [TestCase(7, false)]
    [TestCase(0, true)]
    [TestCase(-4, true)]
    [TestCase(-3, false)]
    public void IsEven_ReturnsParity(int number, bool expected)
    {
        Assert.AreEqual(expected, RunExercise<bool>("IsEven", number));
    }

    [TestCase(12, 12, 5, 12)]
    [TestCase(-7, -2, -9, -2)]
    [TestCase(1, 2, 8, 8)]
    [TestCase(4, 4, 4, 4)]
    public void FindLargestOfThree_ReturnsLargest(int first, int second, int third, int expected)
    {
        Assert.AreEqual(expected, RunExercise<int>("FindLargestOfThree", first, second, third));
    }

    [TestCase(0, new int[] { 0 })]
    [TestCase(3, new int[] { 3, 2, 1, 0 })]
    public void CreateCountdown_ReturnsCountdown(int start, int[] expected)
    {
        CollectionAssert.AreEqual(expected, RunExercise<List<int>>("CreateCountdown", start));
    }

    [Test]
    public void CalculateSum_ReturnsSumForDifferentArrays()
    {
        Assert.AreEqual(19, RunExercise<int>("CalculateSum", new int[] { 3, 5, 2, 8, 1 }));
        Assert.AreEqual(0, RunExercise<int>("CalculateSum", new int[0]));
        Assert.AreEqual(-3, RunExercise<int>("CalculateSum", new int[] { -5, 2 }));
    }

    [Test]
    public void ContainsNumber_SearchesDifferentArrays()
    {
        Assert.IsTrue(RunExercise<bool>("ContainsNumber", new int[] { 4, 9, 2, 7 }, 2));
        Assert.IsFalse(RunExercise<bool>("ContainsNumber", new int[] { 4, 9, 7 }, 2));
        Assert.IsFalse(RunExercise<bool>("ContainsNumber", new int[0], 0));
        Assert.IsTrue(RunExercise<bool>("ContainsNumber", new int[] { -3, 4 }, -3));
    }

    [Test]
    public void CountNames_CountsOnlyAna()
    {
        Assert.AreEqual(2, RunExercise<int>("CountNames", (object)new string[] { "Ana", "Luis", "Ana" }));
        Assert.AreEqual(0, RunExercise<int>("CountNames", (object)new string[0]));
        Assert.AreEqual(0, RunExercise<int>("CountNames", (object)new string[] { "ana", "Luis" }));
    }

    [Test]
    public void CreateReversedList_ReturnsReverseWithoutChangingInput()
    {
        List<int> input = new List<int> { 1, 2, 3 };
        CollectionAssert.AreEqual(new[] { 3, 2, 1 }, RunExercise<List<int>>("CreateReversedList", input));
        CollectionAssert.AreEqual(new[] { 1, 2, 3 }, input);
        CollectionAssert.IsEmpty(RunExercise<List<int>>("CreateReversedList", new List<int>()));
        CollectionAssert.AreEqual(new[] { -4 }, RunExercise<List<int>>("CreateReversedList", new List<int> { -4 }));
    }

    [Test]
    public void GetInventory_ReturnsSuppliedEntries()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int> { { "Llaves", 4 }, { "Mapa", 0 } };
        CollectionAssert.AreEquivalent(inventory, RunExercise<Dictionary<string, int>>("GetInventory", inventory));
        CollectionAssert.IsEmpty(RunExercise<Dictionary<string, int>>("GetInventory", new Dictionary<string, int>()));
    }

    [Test]
    public void FindLargestInList_HandlesDifferentNonemptyLists()
    {
        Assert.AreEqual(12, RunExercise<int>("FindLargestInList", new List<int> { -4, 12, 7, 12, 3 }));
        Assert.AreEqual(-2, RunExercise<int>("FindLargestInList", new List<int> { -8, -2, -5 }));
        Assert.AreEqual(7, RunExercise<int>("FindLargestInList", new List<int> { 7 }));
    }

    [Test]
    public void GetUniqueNumbers_PreservesFirstOccurrenceOrder()
    {
        CollectionAssert.AreEqual(new[] { 3, 1, 2, 4 }, RunExercise<List<int>>("GetUniqueNumbers", new List<int> { 3, 1, 3, 2, 1, 4 }));
        CollectionAssert.AreEqual(new[] { -1, 0 }, RunExercise<List<int>>("GetUniqueNumbers", new List<int> { -1, -1, 0, -1 }));
        CollectionAssert.IsEmpty(RunExercise<List<int>>("GetUniqueNumbers", new List<int>()));
    }

    [Test]
    public void DefaultParameters_ReturnOriginalExamples()
    {
        Assert.IsFalse(RunDefault<bool>("IsEven"));
        Assert.AreEqual(12, RunDefault<int>("FindLargestOfThree"));
        CollectionAssert.AreEqual(new[] { 5, 4, 3, 2, 1, 0 }, RunDefault<List<int>>("CreateCountdown"));
        Assert.AreEqual(19, RunDefault<int>("CalculateSum"));
        Assert.IsTrue(RunDefault<bool>("ContainsNumber"));
        Assert.AreEqual(2, RunDefault<int>("CountNames"));
        CollectionAssert.AreEqual(new[] { 3, 2, 1 }, RunDefault<List<int>>("CreateReversedList"));
        CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "Pociones", 3 }, { "Llaves", 2 }, { "Espadas", 1 } }, RunDefault<Dictionary<string, int>>("GetInventory"));
        Assert.AreEqual(12, RunDefault<int>("FindLargestInList"));
        CollectionAssert.AreEqual(new[] { 3, 1, 2, 4 }, RunDefault<List<int>>("GetUniqueNumbers"));
    }

    private T RunDefault<T>(string methodName)
    {
        MethodInfo method = GetExercise<T>(methodName);
        ParameterInfo[] parameters = method.GetParameters();
        object[] arguments = new object[parameters.Length];
        for (int i = 0; i < arguments.Length; i++) { arguments[i] = System.Type.Missing; }
        return (T)method.Invoke(_exercises, arguments);
    }

    private T RunExercise<T>(string methodName, params object[] arguments)
    {
        MethodInfo method = GetExercise<T>(methodName);
        return (T)method.Invoke(_exercises, arguments);
    }

    private MethodInfo GetExercise<T>(string methodName)
    {
        MethodInfo method = typeof(ExerciseSkeleton).GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
        Assert.IsNotNull(method, "No se encontró el método " + methodName);
        Assert.AreEqual(typeof(T), method.ReturnType, "El tipo de retorno no coincide.");
        return method;
    }

    #endregion Methods
}

