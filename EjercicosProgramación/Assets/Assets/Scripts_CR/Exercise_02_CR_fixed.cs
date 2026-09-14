using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;


public class Exercise_02_CR_fixed : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private int _currentHealth = 100;
    private int _maxHealth = 100;
    private string _playerName = "Player";

    //1.
    public void TakeDamage(int damageAmount)
    {
        _currentHealth = Mathf.Max(0, _currentHealth - damageAmount);
    }

    //2.
    public bool IsAlive()
    {
        return _currentHealth > 0;
    }

    //3.
    public float GetDistance(Vector3 firstPosition, Vector3 secondPosition)
    {
        return Vector3.Distance(firstPosition, secondPosition);
    }

    //4.
    public Vector3 GetDirection(Vector3 originPosition, Vector3 targetPosition)
    {
        return (targetPosition - originPosition).normalized;
    }

    //5.
    public string GetPayerName()
    {
        return _playerName;
    }

    //6.
    public int GetEnemyCount(List<Enemy> enemies)
    {
        return enemies.Count;
    }

    //7.
    public Enemy GetClosestEnemy(List<Enemy> enemies, Vector3 playerPosition)
    {
        Enemy closestEnemy = null;
        float closestDistance = float.MaxValue;

        foreach(Enemy enemy in enemies)
        {
            float distance = Vector3.Distance(playerPosition, enemy.transform.position);

            if(distance < closestDistance)
            {
                closestDistance = distance;
                closestDistance = enemy;
            }
        }
        return closestEnemy;
    }

    //8.
    public void Move(Vector3 direction, float speed)
    {
        transform.position += direction.normalized * speed * Time.deltaTime;
    }

    //9.
    public float DegreesToRadians(float degrees)
    {
        return degrees * Mathf.Deg2Rad;
    }

    //10.
    public bool TryGetClosestPlayer(float searchRange, out Player closestPlayer)
    {
        closestPlayer = null;

        float closestDistance = float.MaxValue;
        Vector3 currentPosition = transform.position;

        foreach (Player player in FindObjectOfType<Player>(FindObjectsSortMode.None))
        {
            float distance = Vector3.Distance(currentPosition, player.transform.position);

            if (distance <= searchRange && distance < closestDistance)
            {
                closestDistance = distance;
                closestPlayer = player;
            }
        }

        return closestPlayer != null;
    }

    //11.
    public bool TryParseInt(string text, out int resultValue)
    {
        return int.TryParse(text, out resultValue);
    }

    //12.
    public Quaternion GetRotation(float angleInDegrees)
    {
        return Quaternion.Euler(0f, angleInDegrees, 0f);
    }

    //13.
    public void GetEnemiesInArea(Vector3 centerPosition, float radius, List<Enemy> enemiesInArea)
    {
        enemiesInArea.clear();

        Collider[] hits = Physics.OverlapSphere(centerPosition, radius);

        foreach(Collider hit in hits)
        {
            GetClosestEnemy enemy = hit.GetComponent<Enemy>();

            if(enemy != null)
            {
                enemiesInArea.Add(enemy);
            }
        }
            
    }

    //14.
    public void ResetPosition(Vector3 spawnPoint)
    {
        transform.position = spawnPoint;
        transform.rotation = Quaternion.identity;

        if(_rigidbody != null)
        {
            _rigidbody.Velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }

    //15.
    public virtual void PerformAction()
    {
        Debug.Log("Character's action");
    }

    //16.
    public class Warrior : Exercise_02_CR_fixed
    {
        public override void PerformAction()
        {
            Debug.Log("Warrior attacks");
        }
    }

    //17.
    public class WarriorWithBaseCall : Exercise_02_CR_fixed
    {
        public override void PerformAction()
        {
            base.PerformAction();
            Debug.Log("Warrior attacks");
        }
    }

    //18.
    public float GetHealthPercent()
    {
        return (float)_currentHealth / _maxHealth * 100f;
    }

    //19.
    public bool CanDodge(float dodgeChance)
    {
        return Random.value <= Mathf.Clamp01(dodgeChance);
    }

    //20.
    public void ApplyForce(Vector3 direction, float forceMagnitude)
    {
        if(_rigidbody == null) { return; }

        _rigidbody.AddForce(direction.normalized * forceMagnitude, ForceMode.Impulse);
    }


    public class Player : MonoBehaviour
    {
    }
    public class Enemy : MonoBehaviour
    {
    }
}
