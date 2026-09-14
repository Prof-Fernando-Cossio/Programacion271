using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = Unity.Mathematics.Random;

public class Excersize2 : MonoBehaviour
{
    //1
    private void ReduceCurrentPLayerLife(Player player, int damageTaken)
    {
        player.CurrentLife -= damageTaken;
    }
    //2
    private bool IsPlayerAlive(Player player)
    {
        return player.CurrentLife > 0;
    }
    //3
    private float CalculateDistance(Vector3 object1, Vector3 object2)
    {
        float distanceResult = Vector3.Distance(object1, object2);
        Debug.Log("The distance is " + distanceResult);
        return distanceResult;
    }
    //4
    private Vector3 NormalizedDirection(Vector3 origin, Vector3 destination)
    {
        Vector3 direction = new Vector3();
        direction = destination - origin;
        direction.Normalize();
        return direction;
    }
    //5
    private string ReturnPlayerName(Player player)
    {
        return player.CurrentName;
    }
    //6
    private int EnemyQuantityCounter(List<Enemy> enemies)
    {
        return enemies.Count;
    }
    //7
    private Enemy FindClosestEnemy(Player player, List<Enemy> enemies)
    {
        float distance;
        float closestDistance = CalculateDistance(player.CurrentPosition, enemies[0].CurrentPosition);
        Enemy evaluatedEnemy;
        Enemy closestEnemy = enemies[0];
        for (int i = 1; i < enemies.Count; i++)
        {
            evaluatedEnemy = enemies[i];
            distance = CalculateDistance(player.CurrentPosition, evaluatedEnemy.CurrentPosition);
            if (closestDistance > distance)
            {
                closestDistance = distance;
                closestEnemy = evaluatedEnemy;
            }
        }
        return closestEnemy;
    }
    //8
    private void MovePlayer(Player player, float velocity, Vector3 direction)
    {
        Vector3 movement = new Vector3();
        movement = direction * velocity;
        player.CurrentPosition += movement;
    }
    //9
    private float DegreesToRadians(float degrees)
    {
        float radians;
        radians = math.radians(degrees);
        return radians;
    }
    //10
    private bool TrySearchNearestPlayer(Player player, List<Player> players, float range, out Player nearestPlayer)
    {
        bool hasFound = false;
        nearestPlayer = new Player();
        float distance, closestDistance = 0;
        for (int i = 0; i < players.Count; i++)
        {
            distance = CalculateDistance(player.CurrentPosition, players[i].CurrentPosition);
            if (distance <= range)
            {
                if (!hasFound)
                {
                    hasFound = true;
                    nearestPlayer = players[i];
                    closestDistance = distance;
                }
                else if (closestDistance > distance)
                {
                    nearestPlayer = players[i];
                    closestDistance = distance;
                }
            }
        }
        return hasFound;
    }
    //11
    private int TryTextToInt(string text)
    {
        if (int.TryParse(text, out int result))
        {
            Debug.Log($"Successfully parsed value of {result}");
            return result;
        }
        else
        {
            Debug.Log("Could not parse properly");
            return -1;
        }
    }
    //12
    private Quaternion AngleToQuaternionRotation(Vector3 angle)
    {
        float yaw = angle.x, pitch = angle.y, roll = angle.z;
        return Quaternion.Euler(yaw, pitch, roll);
    }
    //13
    private List<Enemy> AddEnemiesInArea(Player player, List<Enemy> enemies, float range)
    {
        List<Enemy> nearbyEnemies = new List<Enemy>();
        float distance;

        foreach (Enemy enemy in nearbyEnemies)
        {
            distance = CalculateDistance(player.CurrentPosition, enemy.CurrentPosition);
            if (distance <= range)
            {
                nearbyEnemies.Add(enemy);
            }
        }
        return nearbyEnemies;
    }
    //14
    private void RestartPlayerPosition(Player player)
    {
        player.CurrentPosition = player.InitialPosition;
    }
    //15
    public class BaseClass : MonoBehaviour
    {
        public virtual int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
    //16
    public class ChildClass : BaseClass
    {
        public override int AddNumbers(int x, int y)
        {
            return y + x + x;
        }

        //17
        public int BaseAdditions(int x, int y)
        {
            return base.AddNumbers(x, y);
        }
    }
    //18
    private float CurrentPlayerLifePercentage(Player player)
    {
        float value;
        value = (float)player.CurrentLife / player.MaximumLife;
        value *= 100;
        return value;
    }
    //19
    private bool CanDodgeEvaluate(float dodgeProbability)
    {
        Random randomNumberGenerator = new Random();
        return dodgeProbability >= randomNumberGenerator.NextFloat(100);
    }
    //20
    private void ApplyForce(Rigidbody rigidbody, Vector3 direction)
    {
        rigidbody.AddForce(direction);
    }
}

public class Player : MonoBehaviour
{
    public string CurrentName;
    public int MaximumLife;
    public int CurrentLife;
    public Vector3 CurrentPosition;
    public Vector3 InitialPosition = new Vector3(10, 0, 45);
}

public class Enemy : MonoBehaviour
{
    public Vector3 CurrentPosition;
}