using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int life;

    // Start is called before the first frame update
    void Start()
    {
        life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(life);
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage)
    {
        life -= damage;
    }
}
