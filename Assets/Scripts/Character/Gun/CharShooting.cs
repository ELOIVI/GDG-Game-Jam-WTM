using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public CharacterStats caracterStats;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            shoot();
        }
    }

    private void shoot()
    {
        //shooting logic
        Debug.Log(caracterStats.getWater());
        if(caracterStats.getWater() > 0)
        {
            caracterStats.spendWater(1);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
