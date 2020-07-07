using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muffinBoy : MonoBehaviour
{

    public float cooldown = 5;
    public Animator animator;
    int animToPlay;
    float timePassed; 

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

            if (animToPlay >= 3) animToPlay = 0;
        }

    }
}
