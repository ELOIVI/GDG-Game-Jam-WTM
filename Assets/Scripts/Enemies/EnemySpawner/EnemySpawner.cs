using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public GameObject enemy3Prefab;
    public Transform posPlayer;
    public CharacterStats charStats;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E))
       {
            int numEnemy = Random.Range(0,3);
            createEnemy(numEnemy);
       } 
    }

    private void createEnemy(int enemyType)
    {
        if(enemyType == 0)
        { 
            GameObject instanceEnemy = Instantiate(enemy1Prefab, transform.position, Quaternion.identity);
        
            
            EnemyStats enemyStats = instanceEnemy.GetComponent<EnemyStats>();
            enemyStats.life = 1000;

            EnemyMovement enemyMove = instanceEnemy.GetComponent<EnemyMovement>();

            enemyMove.initObjective(posPlayer, charStats);
            enemyMove.attackDamage = 1;
            enemyMove.attackRange = 2f;
            enemyMove.velocidad = 10f;
            enemyMove.collisionAreaPlayer = 2f;
            enemyMove.timeAttack = 1f;

            
        }
        else if(enemyType == 1)
        { 
            GameObject instanceEnemy = Instantiate(enemy2Prefab, transform.position, Quaternion.identity);
        
            
            EnemyStats enemyStats = instanceEnemy.GetComponent<EnemyStats>();
            enemyStats.life = 1000;

            EnemyMovement enemyMove = instanceEnemy.GetComponent<EnemyMovement>();

            enemyMove.initObjective(posPlayer, charStats);
            enemyMove.attackDamage = 1;
            enemyMove.attackRange = 2f;
            enemyMove.velocidad = 10f;
            enemyMove.collisionAreaPlayer = 2f;
            enemyMove.timeAttack = 1f;

            
        }
        else if(enemyType == 2)
        { 
            GameObject instanceEnemy = Instantiate(enemy3Prefab, transform.position, Quaternion.identity);
        
            
            EnemyStats enemyStats = instanceEnemy.GetComponent<EnemyStats>();
            enemyStats.life = 1000;

            EnemyMovement enemyMove = instanceEnemy.GetComponent<EnemyMovement>();

            enemyMove.initObjective(posPlayer, charStats);
            enemyMove.attackDamage = 1;
            enemyMove.attackRange = 2f;
            enemyMove.velocidad = 10f;
            enemyMove.collisionAreaPlayer = 2f;
            enemyMove.timeAttack = 1f;

            
        }
    }
}
