using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {

    public float speed = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        //循环时间来位移
        //float MovePos = Mathf.Repeat(Time.time, 2.0f);
        //transform.position = Vector3.right * MovePos * speed;
        //直接改变position.x
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (transform.position.x > 25)
        {
            transform.position = new Vector3(-5.1f, transform.position.y, 0);
        }

        //Debug.Log("x=" + transform.position.x);
    }
    void FixedUpdate()
    {
        //transform.position = Vector3.right * Time.deltaTime * speed;
        //
    }
}
