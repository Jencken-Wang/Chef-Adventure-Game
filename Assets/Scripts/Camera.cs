using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public float start = -2.3f;
    public float end = 24.0f;
	public Transform target;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = target.position - this.transform.position;
        //Debug.Log(offset);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position - offset;

        if (this.transform.position.x <= start)//设置相机跟随边界
        {
            this.transform.position =new Vector3(start,transform.position.y,transform.position.z);
        }
        else if (this.transform.position.x >= end)
        {
            this.transform.position = new Vector3(end, transform.position.y, transform.position.z);
        }
    }
	
	
}
