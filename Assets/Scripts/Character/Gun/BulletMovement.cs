using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public Rigidbody rb;

    void Start()
    {
        rb.velocity = transform.forward * speed;
        StartCoroutine(timerMuerte(1));
    }

    void OnTriggerEnter(Collider hitInfo)
    {



        if(!hitInfo.CompareTag("BulletTag"))
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
