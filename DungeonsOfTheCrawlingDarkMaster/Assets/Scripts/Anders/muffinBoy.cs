using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muffinBoy : MonoBehaviour
{

    public float cooldown = 5;
    public Animator animator;
    int animToPlay;
    float timePassed; 
    float speed  = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("actions", 0);
        timePassed += Time.deltaTime;
        

        if(timePassed >= cooldown)
        {
            timePassed = 0;
            animToPlay += 1;

            animator.SetInteger("actions", animToPlay);

            if (animToPlay >= 2) animToPlay = 0;
        }

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (move.magnitude > 0)
        {
            transform.position += move * speed * Time.deltaTime;
            animator.SetInteger("actions", 3);
            if (Input.GetAxis("Horizontal") > 0)
            {
                transform.rotation = Quaternion.AngleAxis(-180, transform.up);
            }
              if (Input.GetAxis("Horizontal") < 0)
            {
                transform.rotation = Quaternion.AngleAxis(0, transform.up);
            }
  
        }



    }
}
