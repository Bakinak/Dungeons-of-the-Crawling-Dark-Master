using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public Transform firePoint;
    public GameObject arrowPrefab;

    public float arrowForce = 20f;

    // Update is called once per frame
    void Update()
    {
     
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

        rb.AddForce(firePoint.up * arrowForce, ForceMode2D.Impulse);
    }
}
