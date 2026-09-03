using UnityEngine;

public class CleanCode2 : MonoBehaviour
{
    //1
    public void TakePlayerLife(float damagePlayer, float playerLife)
    {
        playerLife=playerLife-damagePlayer;
        Debug.Log("Player is taking damage");

    }

    //2
    public bool IsPlayerAlive(float playerLife)
    {
        bool playerState=playerLife>0;
        Debug.Log("Player is alive");

        return playerState;
    }

    //3
    public float PositionDistance(Vector3 positionA,Vector3 positionB)
    {
        float distance =Vector3.Distance(positionA,positionB);
        Debug.Log($"The distance of position a and position b is {distance}");

        return distance;
    }

    //4
    public Vector3 NormalizedDirection(Vector3 origin, Vector3 destination)
    {
        Vector3 direction=destination-origin;
        Vector3 directionNormalized= direction.normalized;
        Debug.Log("Direction is normalized");

        return directionNormalized;

    }

    //5
    public string CurrentPlayerName(string playerName)
    {
        string currentPlayerName=playerName;
        Debug.Log($"Player name is:{currentPlayerName}");


        return currentPlayerName;
    }

    //6
    public int EnemyCount(List<int> enemies) 
    {
        int currentEnemies=enemies.Count;
        Debug.Log($"Current enemies:{currentEnemies}");

        return currentEnemies;
    }
    
    

    /*//6.5
    public void EnenyCount2(int enemiesSpawn)
    {
        int currentEnemies=0;
        List <int> enemies2=new List <int>();
        while (currentEnemies<enemiesSpawn)
        {
            enemies2.Add(currentEnemies);
            currentEnemies++;
        }
        Debug.Log($"Current enemies:{currentEnemies}");
    }
    */

    //7
    public GameObject ClosestEnemy(List <GameObject> enemies, Vector3 playerPosition)
    {
        float minimunDistance = enemies[0].transform.position;
        GameObject closestEnemy = enemies[0];

        for (int currentEnemy=0; currentEnemy<enemies.Count;currentEnemy++)
        {
            float distance= Vector3.Distance(playerPosition, enemies[currentEnemy].transform.position);
            if (distance<= minimunDistance)
            {
                minimunDistance=distance;
                closestEnemy=enemies[currentEnemy];
            }
        }
        Debug.Log($"Closest enemy is: {closestEnemy.name}");

        return closestEnemy;
    }

    //8
    public void PlayerMovement(float speed, Vector3 direction)
    {
        transform.position= transform.position+(direction*speed*Time.deltaTime);
        Debug.Log("Player is moving");

    }

    //9
    public float DegreesToRadians(float degrees)
    {
        float radians= degrees*Mathf.Deg2Rad;
        Debug.Log("Degrees and Radians coversion done");

        return radians;
    }

    //10
    public bool TryGetClosestPlayer(List<GameObject> players, Vector3 playerPosition, float range, out GameObject closestPlayer)
    {
        float minimunDistance=range;
        closestPlayer=null;

        for (int currentPlayer=0;currentPlayer<players.Count; currentPlayer++)
        {
            float distance=Vector3.Distance(playerPosition, players[currentPlayer].transform.position);

            if (distance<=minimunDistance)
            {
                minimunDistance=distance;
                closestPlayer=players[currentPlayer];
            }
        }

        return closestPlayer!=null;
    }


    //11
    public bool TryConvertToInt(string text, out int value)
    {
        bool conversionSuccessful= int.Try....;
        Debug.Log("Conversion successful");
        
        return conversionSuccessful;
    }

    //12
    public Quaternion DegreesToQUaternion(float degrees)
    {
        Quaternion rotation=Quaternion.Euler(0,degrees,0);
         Debug.Log($"Rotation created");

        return rotation;
    }

    //13 (ni idea)

    //14
    public void PlayertoSpawnPoint(Vector3 spawnPoint)
    {
        transform.position=spawnPoint;
        Debug.Log("Player position has been reset");
    }

    //15
    public class Student: MonoBehaviour
    {
        public virtual void Write()
        {
            Debug.Log("Student is writing");

        }
    }

    //16
    public class ProgrammerStudent : Student
    {
        public override void Write()
        {
            Debug.Log("Programer student is coding");
        }
    }

    //17
    public class MarketingStudent : Student
    {
        public override void Write()
        {
            base.Write();
            Debug.Log("Marketing student is writing");
        }
    }

    //18
    public float PlayerCurrentLifePercentage(float currentHealth, float maxHealth)
    {
        float healthPercentage=currentHealth/maxHealth*100;
        Debug.Log($"Player health percentage: {healthPercentage}%");

        return healthPercentage;
    }

    //19 (ni idea)

    //20
    public void ApplyForce(Rigidbody rigidbody, Vector3 direction, float force)
    {
        rigidbody.AddForce(direction*force);
        Debug.Log("Force applied");
    }

}

