using UnityEngine;

public class CleanCode3 : MonoBehaviour
{
    //1
    public int PlayerHealth 
    { 
        get; 
        private set; 
    }
    
    //2
    public bool IsPlayerDead
    {
        get
        {
            return PlayerHealth <= 0;
        }
    }

    //3
    public string PlayerName    
    { 
        get; 
        init; 
    }

    //4
    public int Coins 
    { 
        get; 
        set; 
    }

    5//
    public float HealthPercentage
    {
        get
        {
            return (float)_currentHealth / _maxHealth * 100f;
        }
    }

    //6
    private float _movementSpeed;

    public float MovementSpeed
    {
        get
        {
            return _movementSpeed;
        }

        set
        {
            _movementSpeed = value;
        }
    }

    //7
    private int _damage;
    
    public int DamageLimit
    {
        get
        {
            return _damage;
        }

        set
        {
            _damage = Mathf.Clamp(value, 0, 100);
        }
    }

    //8
    public static int PlayersConected
    {
        get;
        private set;
    }

    //9
    public int Experience
    {
        get;
        private set;
    }

    //10
    [SerializeField] private float _stamina;

    public float Stamina
    {
        get
        {
            return _stamina;
        }
    }

    //11
    private float _distance;
    private float _attackRange;
    public bool CanEnemyAttack
    {
        get
        {
            return _distance <= _attackRange;
        }
    }
    
    //12
    private float _volume;
    
    public float NoNegativeVolume
    {
        get
        {
            return _volume;
        }

        set
        {
            _volume = Mathf.Max(0, value);
        }
    }

    //13
    public System.DateTime CharacterCreationDate
    {
        get;
    }

    //14
    private int _inventoryItems;
    private int _maxInventory;

    public bool IsInventoryFull
    {
        get
        {
            return _inventoryItems.Count >= _maxInventory;
        }
    }

    //15
    public int MaxLevel
    {
        get;
        init;
    }

    //16
    public float HorizontalVelocity
    {
        get
        {
            return _rigidbody.velocity.x;
        }
    }

    //17
    public float Energy
    {
        get;
        private set;
    }

    //18
    public Vector3 CurrentPosition
    {
        get
        {
            return transform.position;
        }
    }

    //19
    public Item[] InventoryItems
    {
        get
        {
            return _inventoryItems;
        }
    }

    //20
    public bool IsCharacterRunning
{
    get
    {
        return _rigidbody.velocity.magnitude > 0;
    }
}
}
