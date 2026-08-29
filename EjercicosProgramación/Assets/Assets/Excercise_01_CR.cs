using NUnit.Framework;
using System;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Serialization;

public class Excercise_01_CR : MonoBehaviour 
{
    //1.
    [SerializeField] private float _movementSpeed = 5f;

    //2.
    public float PlayerExperience = 1f;

    //3.
    protected int _baseDamage = 10;

    //4.
    private int _currentPlayerLife = 70;

    //5.
    [SerializeField] private Rigidbody _rigidBody;

    //6.
    private bool _isDead = false;

    //7.
    protected List _saveIndex;

    //8.
    [UnityEngine.Range(0f, 100f)]
    [SerializeField] private float _attackRange;

    //9.
    public string PlayerName;

    //10.
    protected float _nonPlayableCharacterSpeed = 3f;

    //11.
    private MeshRenderer _meshRenderer;

    //12.
    [Tooltip("Slider that modifies game's general volume")]
    [SerializeField] private float _gameVolume = 1f;

    //13.
    private bool _canAttack = true;

    //14.
    public class GameManager
    {
        public GameManager Instance;
    }

    //15.
    private List _itemList;

    //16.
    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _vehicleSpeed;

    //17.
    private Vector3 _playerPosition;

    //18.
    internal int LimitOfPlayers;

    //19.
    [SerializeField] protected float _enemyDetection;

    //20.
    [SerializeField] private AudioSource _audioSource;

}
