using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float tiempoEntreDisparo = 0.005f;
    private float tiempoSiguienteDisparo = 0f;

    public CharacterStats caracterStats;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time >= tiempoSiguienteDisparo)
        {
            shoot();
            tiempoSiguienteDisparo = Time.time + tiempoEntreDisparo;
        }
    }

    private void shoot()
    {
        //shooting logic
        if(caracterStats.getWater() > 0)
        {
            caracterStats.spendWater(1);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
