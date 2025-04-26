using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    private int life;
    private int water;
    private int maxWater;

    // Start is called before the first frame update
    void Start()
    {
       life = 100; 
       maxWater = 1000;
       water = maxWater;
    }

    // Update is called once per frame
    void Update()
    {
        
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

        Debug.Log(water);
    }

    public void takeDamage(int damage)
    {
        life -= damage;
    }
}
