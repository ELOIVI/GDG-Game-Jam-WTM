using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Timeline;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform objetive;
    public CharacterStats charStats;

    public float velocidad;
    public float collisionAreaPlayer;
    public float attackRange;
    public int attackDamage;
    public float timeAttack;

    private bool isAttackTime = true;


    void Start()
    {
        /*velocidad = 5f;
        collisionAreaPlayer = 2f;
        attackRange = 2f;
        attackDamage = 1;
        timeAttack = 1f;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(objetive != null)
        {
            Vector3 distV = (objetive.position - transform.position);
            float dist = distV.magnitude;
            if(objetive != null && dist >= collisionAreaPlayer)
            {
                Vector3 dir = distV.normalized;
                transform.position += dir * velocidad * Time.deltaTime;
            }

            if(dist <= attackRange) 
            {
                if(isAttackTime)
                {
                    isAttackTime = false;
                    attack();
                }
            }
        }
    }

    public void initObjective(Transform newObjective, CharacterStats stats)
    {
        objetive = newObjective;
        charStats = stats;

    }

    private void attack()
    {
        if(charStats != null)
        {
            charStats.takeDamage(attackDamage); 
            StartCoroutine(timerAttack());
        }
    }

    private IEnumerator timerAttack()
    {
        yield return new WaitForSeconds(timeAttack);
        isAttackTime = true;
    }
}
