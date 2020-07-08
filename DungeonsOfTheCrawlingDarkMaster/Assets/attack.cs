using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject projectile;
    public float cooldown = 5;
    float timePassed; 
    float speed  = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timePassed += Time.deltaTime;
        
        if(timePassed >= cooldown)
        {
            timePassed = 0;
            
            GameObject.Instantiate(projectile,transform.position, transform.rotation);

            
        }

    }
}

