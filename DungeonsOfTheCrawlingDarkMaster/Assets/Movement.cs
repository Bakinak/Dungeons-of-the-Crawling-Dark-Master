using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

 
    float timePassed; 
    float speed = 1.0f;
    Vector3 move;
    Random random = new Random();
    public GameObject muffin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        muffin = GameObject.Find("muffinenemy");
        var x = muffin.transform.position.x-transform.position.x;
        var y = muffin.transform.position.y-transform.position.y;
        var angle = Mathf.Atan2(x,y)*Mathf.Rad2Deg;
        //Debug.Log("x "+x);
        //Debug.Log("y "+y);
        //Debug.Log("atan "+angle);
        transform.rotation = Quaternion.AngleAxis(-angle, transform.forward);
        //transform.Rotate(new Vector3(0,0,1));
        //if(Mathf.Round(transform.eulerAngles.z)==180) { transform.Rotate(new Vector3(0,0,-180)); }

        if(timePassed >= 2)
        {
        timePassed = 0;
        

        move = new Vector3(Random.Range(-2.0f+Mathf.Clamp(x,-1,0), 2.0f+Mathf.Clamp(x,0,1)), Random.Range(-2.0f+Mathf.Clamp(y,-1,0), 2.0f+Mathf.Clamp(y,0,1)), 0);
        }
        transform.position += move * speed * Time.deltaTime;
        




    }
}