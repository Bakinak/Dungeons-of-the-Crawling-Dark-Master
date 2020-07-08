using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{

    float muffin_x, muffin_y;
    Vector3 move;
    float timePassed; 
    // Start is called before the first frame update
    float speed = 3.0f;
    void Start()
    {
        muffin_x = GameObject.Find("muffinenemy").transform.position.x;
        muffin_y = GameObject.Find("muffinenemy").transform.position.y;
        Debug.Log("pos of muffin was"+muffin_x+", "+muffin_y);
        move = new Vector3(muffin_x, muffin_y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        transform.Translate(Vector2.up * Time.deltaTime*speed);
    }
}
