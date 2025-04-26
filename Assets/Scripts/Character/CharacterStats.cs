using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int life;
    public int water;
    public int maxWater;
    public float inmortalityTime;
    private bool isInmortal;

    // Start is called before the first frame update
    void Start()
    {
       life = 5; 
       maxWater = 500;
       water = maxWater;
       isInmortal = false;
       inmortalityTime = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public int getLife()
    {
        return life;
    }

    public int getWater()
    {
        return water;
    }

    public void spendWater(int amount)
    {
        water -= amount;
    }

    public void fillWater(int amount)
    {
        int diffWater = maxWater - water;
        if(amount > diffWater)
        {
            water += diffWater;
        }
        else
        {
            water += amount;
        }

    }

    public void takeDamage(int damage)
    {
        if(!isInmortal)
        {
            isInmortal = true;
            life -= damage;
            StartCoroutine(timerInmortality());
        }
    }

    private IEnumerator timerInmortality()
    {
        yield return new WaitForSeconds(inmortalityTime);
        isInmortal = false;
    }
}
