using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
    public float TimeRange ,TimeRange2 ;
    public float KnifeSpeed, SpoonSpeed;
    private float SJ;
    private float x,y;
    public bool colliderdie = false;
    /*碰撞死亡所需object*/
    public GameObject playerdie;
    //bool Judge;
    Collider2D collision;
    //Transform transform;
	// Use this for initialization
	void Start () {
        TimeRange = 3.1f;
        KnifeSpeed = 0.7f;
        TimeRange2 = 2.0f;
        SpoonSpeed = 0.3f;
        x = transform.position.x;
        y = transform.position.y;
        //Judge = false;
        collision = GetComponent<Collider2D>();
        Debug.Log(gameObject.name + x);
	}
	
	// Update is called once per frame
	void Update () {
        
        if (gameObject.name == "knife")
        {
            //Debug.Log("运行1");
            Move(x - SJ * KnifeSpeed, y, TimeRange);
        }
        else if (gameObject.name == "spoon")
        {
            //Debug.Log("运行2"+gameObject.transform.position);
            Move(x, y - SJ * SpoonSpeed, TimeRange2);
            
        }
	}
    void Move(float a,float b,float time)
    {  
        SJ = Mathf.Repeat(Time.time, time);//时间自动增加，循环移动的时间

        //Debug.Log("时间：" + Time.time);
        transform.position = new Vector3(a, b, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Hit destroy collision:" + other);
        //在被碰撞物体的脚本上销毁人物
        //Destroy(collision.gameObject);
        Time.timeScale = 0;
        playerdie.SetActive(true);
        colliderdie = true;
    }
}
