using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public LayerMask groundLayer;
    Rigidbody2D rigidbody2d;
    bool colliderGutter;
    public float JumpSpeed;
    //死亡与完成窗口跳出
    public bool booldie = false;
    public GameObject playerdie;
    public GameObject playerok;
    //用于跳跃判断
    bool action = false;

    bool ground = true;
    // 移动速度
    private Vector2 speed = new Vector2(2, 40);

    //判断人物是否在地面上
    bool IsGrounded()
    {
        Vector2 position1 = transform.position;
        Vector2 position2 = transform.position;
        Vector2 direction = Vector2.down;
        position1.x = transform.position.x - 0.08f;
        position2.x = transform.position.x + 0.1f; 
        float distance = 0.3f;
        Debug.DrawRay(position1, direction, Color.green);
        Debug.DrawRay(position2, direction, Color.green);
        RaycastHit2D hit1 = Physics2D.Raycast(position1, direction, distance, groundLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(position2, direction, distance, groundLayer);
        if (hit1.collider != null || hit2.collider!=null)
        {
            Debug.Log("在地面上");
            
            return true;
        }
            Debug.Log("不在地面上");
        
       
        return false;
    }
    /**人物移动函数**/
    //private void move(float a, float b)
    //{
    //    if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    //    {
    //        rigidbody2d.AddForce(Vector2.right * a);
    //    }
    //    else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    //    {
    //        rigidbody2d.AddForce(Vector2.left * a);
    //    }
    //    rigidbody2d.AddForce(Vector3.up * b);
    //    //upwarddis = new Vector2(a, b);
    //    //rigidbody2d.AddForce(Vector3.up * b);
    //   // jumpdis = new Vector2(c, d);
    //    //rigidbody2d.velocity = upwarddis;
    //}

    /**人物碰撞物体死亡见FoodScore**/
    /**人物掉落死亡函数**/
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "gutter")
        {
            colliderGutter = true;
            //死亡,调出死亡窗口
            Time.timeScale = 0;
            booldie = true;
            playerdie.SetActive(true); 
        }
        else if (other.gameObject.tag == "ok")
        {
            this.gameObject.tag = "ok";
            Debug.Log("游戏通关！！！");
            //游戏通关窗口
            Time.timeScale = 0;
            playerok.SetActive(true);
            //游戏通关
        }
    }

    void Start()
    {

        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            action = true;
        }
        
    }
    void FixedUpdate()
    {

        move(30);
            

        if (!IsGrounded())
        {
            return;
        }
        else 
        if (action)
        {
            Debug.Log("按下空格");
            float jump = Input.GetAxis("Jump");
            rigidbody2d.velocity = new Vector2(0, jump * JumpSpeed);
            action = false;
        }
        Debug.Log("断点");
//
    }
    private void move(float a)
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.AddForce(Vector2.right * a);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.AddForce(Vector2.left * a);
        }
    }
}