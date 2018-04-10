//背景移动层次感效果
using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour
{
    //public float a = 2.0f;
    public Transform  target;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = target.position - this.transform.position;
    }
    void Update()
    {
        //transform.Translate(Vector3.right * Time.deltaTime * a);
        //if (transform.position.x >= 10)
        //{
        //    transform.position = new Vector3(
        //    0,
        //    transform.position.y,
        //    transform.position.z);
        //}
        this.transform.position = Vector3.right * (target.position.x - offset.x)*0.2f;
    }
}
