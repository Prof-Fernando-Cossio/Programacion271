using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using static UnityEditor.Progress;

public class Exercise_03_CR : MonoBehaviour
{
    private float _health;
    private float _maxHealth;
    private float _damage;
   [SerializeField] private float _enemyDistance;
   [SerializeField] private float _eemyAttackRange;
   [SerializeField] private float _volume;
   [SerializeField] private  Rigidbody _rigidbody;


    //1.
    public int Health {  get; private set; }

    //2.
    public bool IsDead => Health <= 0;

    //3.
    public string PlayerName { get; init; }

    //4.
    public int CoinsCollector { get; set; }

    //5.
    public float HealthPercent => (float) _health / _maxHealth * 100f;
    // public float HealthPercent => 0 ? (float) _health / _maxHealth * 100f : 0f;

    //6.
    private float _movementSpeed;
    public float MovementSpeed => _movementSpeed;
    //public int MovementSpeed => value;

    //7.
    public float Damage { get { return _damage; } set { _damage = Mathf.Clamp(value, 0, 100); } }

    //8.
    public static int PlayersConected { get; private set; }

    //9.
    public float Experience {  get; private set; }

    //10.
    [SerializeField] private float _currentStamina;
    public float CurrentStamina => _currentStamina;
    /*
     * public float Stamina
     * {
     *    get => _stamina
     *    private set => = value;
     * }
    */

    //11.
    public bool CanAttack => _enemyDistance <= _eemyAttackRange;

    //12.
    public float Volume { get { return _volume; } set { Mathf.Clamp(value, 0, 1f); } }

    //13.
    public DateTime CharacterCreationDate { get; } = DateTime.Now;

    //14.
    public bool IsInventoryFull => _inventoryItems <= 99;

    //15.
    public int MaxLevel {  get; init; }

    //16.
    public float HorizontalVelocity { get;} _rigidbody.linearVelocity.magnitude * Time.DeltaTime;
    // public float HorizontalVelocity => new Vector3/_rigidbody.velocity.x, 0f, _rigidbody.velocity.z).magnitude;

    //17.
    public float Energy { get; private set; }

    //18.
    public Vector3 CurrentPosition => transform.position;

    //19.
    public List<Item> _inventoryItems { get; } = new List<Item>();
    /*
     * public List<Item> InventoryItems {get; private set;}
     * public List<Item> InventoryItems => _inventoryItems;
     * public IReadOnlyList<Item> InventoryItems => _inventoryItems;
    */

    //20.
    public bool IsRunning => _rigidbody.horizontalVelocity.magnitude > 1f;



    public class Item
    {
        public string name;
    }

}
