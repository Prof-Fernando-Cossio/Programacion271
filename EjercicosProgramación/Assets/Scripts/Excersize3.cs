using UnityEngine;

//Code to make sure init; works
//taken from https://www.mking.net/blog/error-cs0518-isexternalinit-not-defined
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit { }
}//end of external code

public class Excersize3 : MonoBehaviour
{
    //Variable Declaration
    private int _currentHealth;
    private int _maxHealth;
    private float _movementSpeed;
    private int _damage;
    [SerializeField]private int _stamina;
    [SerializeField] private Player _player;
    private float _volume;
    private int _inventoryCount;
    private int _maxInventory;
    private Rigidbody _rigidbody;
    private List<ItemAlex> _inventoryItems=new List<ItemAlex>();
    private Rigidbody _character;


    //1
    public int Health { get; private set; }
    //2
    public bool IsDead => Health <= 0;
    //3
    public string PlayerName { get; init; }
    //4
    public int Coins {  get; set; }
    //5
    public float HealthPercent => (float)_currentHealth / _maxHealth * 100f;
    //6
    public float MovementSpeed => _movementSpeed;
    //7
    public int Damage { get { return _damage; } set { _damage = Mathf.Clamp(value, 0, 100); } }
    //8
    public static int PlayerCount {  get; private set; }
    //9
    public int Experience {  get; private set; }
    //10
    public int Stamina => _stamina;
    //11
    public bool CanAttack => Vector3.Distance(_player.transform.position,transform.position) < 10;
    //12
    public float Volume { get { return _volume; } set { _volume=Mathf.Max(value, 0); }  }
    //13
    //public string CharacterCreationDate { get; } = "09/07/2026"; what I've originally done
    public DateTime CharacterCreationDate { get; } = DateTime.Today;
    //14
    public bool IsInventoryFull => _inventoryCount >= _maxInventory;
    //15
    public int MaxLevel { get; init; }
    //16
    public float HorizontalVelocity => _rigidbody.linearVelocity.z;
    //17
    public int Energy { get;private set; }
    //18
    public Vector3 CurrentPosition => transform.position;
    //19
    //public List<Item> ReadOnlyInventoryItems { get; } = _inventoryItems;
    public IReadOnlyList<ItemAlex> ReadOnlyInventoryItems => _inventoryItems;
    //20
    public bool IsRunning=>_character.linearVelocity.magnitude > 0;
}

