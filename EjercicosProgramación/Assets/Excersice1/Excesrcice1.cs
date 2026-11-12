

// //1.[SerializeField] private float _movementSpeed = 5f;
// //2.- public int PlayerLevel;
// //3.- protected int _baseDamage = 10;
// //4.- private int _currentHealth;
// //5.-[SerializeField] private Rigidbody _rigidbody;
// //6.- private bool _isAlive;
// //7.- internal int _saveIndex;
// //8.- [Range(0, 100)] [SerializeField]  private int _attackRange;
// //9.- public string PlayerName; 
// //10.- protected float _moveSpeed;
// //11.-private MeshRenderer _meshRenderer;
// //12.- [Tooltip("Volume")] [SerializeField]  private float _masterVolume =1f;
// //13.-private bool canAtack;
// //14.-public static GameManager Instance;
// //15.-private List<GameObject> _inventory = new List<GameObject>();
// //16.-[FormerlySerializedAs("_speed")] [SerializeField] private float _renamedMovementSpeed =5f;
// //17.- private Vector3 _playerPosition;
// //18.-public int MaxPlayers;
// //19.-[SerializeField] protected float _detectionDistance =10f;
// //20.-[SerializeField] private AudioSource _audioSource;


// // 1. Reduce the player's current health
// void ReduceHealth(ref int health, int damage)
// {
//     health -= damage;
// }


// // 2. Check if the player is alive
// bool IsAlive(int health)
// {
//     return health > 0;
// }


// // 3. Calculate the distance between two positions
// float CalculateDistance(Vector3 position1, Vector3 position2)
// {
//     return Vector3.Distance(position1, position2);
// }


// // 4. Get the normalized direction from an origin to a destination
// Vector3 GetDirection(Vector3 origin, Vector3 destination)
// {
//     return (destination - origin).normalized;
// }


// // 5. Get the player's current name
// string GetPlayerName(string name)
// {
//     return name;
// }


// // 6. Count the enemies in a list
// int CountEnemies(List<Enemy> enemies)
// {
//     return enemies.Count;
// }


// // 7. Find the closest enemy to the player
// Enemy GetClosestEnemy(
//     List<Enemy> enemies,
//     Vector3 playerPosition)
// {
//     return enemies
//         .OrderBy(enemy => Vector3.Distance(
//             enemy.Position,
//             playerPosition))
//         .FirstOrDefault();
// }


// // 8. Move the player using speed and direction
// void MovePlayer(
//     ref Vector3 position,
//     float speed,
//     Vector3 direction)
// {
//     position += direction * speed;
// }


// // 9. Convert degrees to radians
// float ConvertDegreesToRadians(float degrees)
// {
//     return degrees * Mathf.Deg2Rad;
// }


// // 10. Try to get the closest player within a given range
// bool TryGetPlayer(
//     List<Player> players,
//     Vector3 position,
//     float range,
//     out Player player)
// {
//     player = players.FirstOrDefault(
//         currentPlayer =>
//             Vector3.Distance(currentPlayer.Position, position) <= range
//     );

//     return player != null;
// }


// // 11. Try to convert text to an integer
// bool TryConvertToInteger(
//     string text,
//     out int number)
// {
//     return int.TryParse(text, out number);
// }


// // 12. Create a rotation from an angle in degrees
// Quaternion CreateRotationFromDegrees(float degrees)
// {
//     return Quaternion.Euler(0f, 0f, degrees);
// }


// // 13. Get all enemies inside a given area
// List<Enemy> GetEnemiesInArea(
//     List<Enemy> allEnemies,
//     Vector3 center,
//     float radius)
// {
//     return allEnemies
//         .Where(enemy =>
//             Vector3.Distance(enemy.Position, center) <= radius)
//         .ToList();
// }


// // 14. Reset the player's position to the spawn point
// void ResetPosition(
//     ref Vector3 position,
//     Vector3 spawnPosition)
// {
//     position = spawnPosition;
// }


// // 15. Base class with a method designed to be overridden
// class Character
// {
//     public virtual void Attack()
//     {
//         Debug.Log("The character attacks.");
//     }
// }


// // 16. Override the method from the base class
// class Warrior : Character
// {
//     public override void Attack()
//     {
//         Debug.Log("The warrior attacks with a sword.");
//     }
// }


// // 17. Call the original behavior from the base class
// class Mage : Character
// {
//     public override void Attack()
//     {
//         base.Attack();
//         Debug.Log("The mage casts a spell.");
//     }
// }


// // 18. Calculate the player's current health percentage
// float CalculateHealthPercentage(
//     int currentHealth,
//     int maximumHealth)
// {
//     return (float)currentHealth / maximumHealth * 100f;
// }


// // 19. Determine whether an enemy can dodge an attack
// bool CanDodge(float probability)
// {
//     return Random.value < probability;
// }


// // 20. Apply a force to a Rigidbody
// void ApplyForce(
//     Rigidbody rigidbody,
//     Vector3 direction,
//     float magnitude)
// {
//     rigidbody.AddForce(direction * magnitude);
// }

using JetBrains.Annotations;

1.- public int Health{get; set;}
2.- public bool IsDead=> Health <= 0;
3.- public string PlayerName{get; init;}
4.- public int Coins{get; set;}
5.- public float HealthPercentage => (float)_currentHealth / _maxHealth * 100f;
6.- private int _movementSpeed; public int movementSpeed => _movementSpeed;
7.- public int Damage{get{return _damage;} set{_damage = Mathf.Clamp(value, 0, 100);}}
8.-public static int OnlinePlayersCount{get; private set;}
9.-public int Shield {get; private set;}
10.-[SerializeField] private float _stamina = 100f;
11.-
12.-public int Volume {get{return _volume;} set{_volume = Mathf.Clamp(value, 0, 100);}}
13.-public int CreationDate {get;} = 10;
14.-
15.-public string  MaxLevel {get; init;}
16.-public bool HorizontalMovement => _rigidBody.velocity.x != 0;
17.-public int Energy { get;private set; }
18.-public Vector3 CurrentPosition => transform.position;
19.-public int _inventoryItems {get;}=;
20.-public bool IsRunning => _rigidBody.velocity.magnitude > 0.1f;
