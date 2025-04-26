using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int damage;
    public Rigidbody rb;

    void Start()
    {
        rb.velocity = transform.forward * speed;
        StartCoroutine(timerMuerte(2));
        speed = 20f;
        damage = 20;
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision hitInfo)
    {

        if(hitInfo.gameObject.CompareTag("EnemyTag"))
        {
            EnemyStats enemyStats = hitInfo.gameObject.GetComponent<EnemyStats>();
            if(enemyStats != null)
            {
                enemyStats.takeDamage(damage);
            }
        }

        if(!hitInfo.gameObject.CompareTag("BulletTag"))
        {
            Destroy(gameObject);
        }

    }

    private IEnumerator timerMuerte(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);

        Destroy(gameObject);

    }
}
