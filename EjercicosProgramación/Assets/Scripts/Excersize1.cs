using UnityEngine;
using UnityEngine.Serialization;

public class Excersize1 : MonoBehaviour
{
    //madeby Carlos Takeda Sosa
    [SerializeField] private float _velocity /*= 5f*/;//1
    public int CurrentLevel;//2
    protected int _baseDamage = 10;//3
    private int _currentPlayerLife;//4
    [SerializeField] private Rigidbody _rigidbody;//5
    private bool _isAlive;//6
    internal int SavedData;//7
    //[Range(0, 100)]
    [SerializeField] private float _attackRange;//8
    public string CurrentPlayerName;//9
    protected float _movementSpeed;//10
    [HideInInspector] private MeshRenderer _meshRenderer;//11
    [Tooltip("Changes the in-game volume")]
    [SerializeField] private float _gameVolume;//12
    private bool canAttack;//13
    public static GameManager Instance;//14
    //private List<InventoryObjects> _inventoryObjectsList=new List<InventoryObjects>();//15
    [FormerlySerializedAs("_speed")]
    [SerializeField] private float _rapidness;//16
    private Vector3 _playerPosition;//17
    public int MaximumPlayers;//18
    [SerializeField] protected float _enemyDetectionDistance;//19
    [SerializeField] private AudioSource _audioSource;//20
}

public class GameManager : MonoBehaviour
{

}
[System.Serializable]
public class InventoryObjects
{
    public string Name;
}