using NUnit.Framework;
using System;
using System.Reflection.Metadata.Ecma335;
using Unity.Mathematics;
using UnityEngine;

public class Exercise_02_CR : MonoBehaviour
{
    //1.
    public void PlayerTakeDamage(int damageAmount, int currentLife)
    {
        currentLife = currentLife - damageAmount;
        if(currentLife < 0 ) { currentLife = 0; }
    }

    //2.
    public bool IsPlayerAlive(int currentLife)
    {
        if (currentLife > 0) { return true; }
        else { return false; }
    }

    //3.
    public float DistanceBetween(Vector3 playerPosition, Vector3 city)
    {
        return math.distance(playerPosition, city);
    }

    //4. 
    public void NormalizeDistance(Vector3 distanceBetween)
    {
        math.normalize(distanceBetween);
    }

    //5.
    public string PlayerName(string playerName)
    {
        playerName = Console.ReadLine();
        return playerName;
    }


    //6.
    public int EnemyList(Array enemyArray)
    {
        return enemyArray.Length;
    }

    //7.
    public Vector3 NearestEnemy(Vector3 playerPosition, Vector3[] enemyArray)
    {
        float nearestDistance = float.MaxValue;
        Vector3 nearestEnemy = Vector3.zero;

        foreach (Vector3 enemy in enemyArray)
        {
            float distance = Vector3.Distance(playerPosition, enemy);

            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestEnemy = enemy;
            }
        }

        return nearestEnemy;
    }

    //8.
    public void PlayerSpeed(float movementSpeed, Vector3 playerDirection)
    {
        transform.position = playerDirection * movementSpeed * Time.deltaTime;
    }

    //9.
    public void AnglesConverter(float angle)
    {
        float radian = Mathf.Rad2Deg * angle;
    }

    //10.
    public bool TryFindPlayer(string playerName, Vector3 position, float maxDistance = 10f, LayerMask layermask = default, out Player foundPlayer, out float distance)
    {
        
    }

    public class Player {}

}
