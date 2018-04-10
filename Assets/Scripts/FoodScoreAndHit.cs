using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FoodScoreAndHit : MonoBehaviour
{
    //显示分数所需变量
    public Text ScoreText;
    private int Score;
    private bool b;
    Collider2D collision;
    GameObject gameobject;
    bool judge;


	// Use this for initialization
	void Start () { 
        judge = false;
        collision = GetComponent<Collider2D>();
        Debug.Log("名字"+collision);
	}
	


	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("触发器"+"  触发了："+other);
        gameobject = other.gameObject;
       //判断角色是否碰撞food
       if (gameobject.tag == "food")
       {
           Debug.Log("销毁food");
           Destroy(other.gameObject);
           Score += 1;
           ScoreText.text = Score.ToString();
       }
       //判断角色时候碰撞Hit
       if (gameobject.tag == "Hit")
       {
           judge = true;
       }
    }


	void Update () {
        //角色碰撞Hit死亡
        if (judge == true)
        {
            Debug.Log("销毁角色");
            //Destroy(gameObject);
        }

	}

    
}
