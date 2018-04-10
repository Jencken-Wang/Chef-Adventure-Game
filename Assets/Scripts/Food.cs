using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
    
    //GameObject tomato;
    public int Score;
    private bool b;
    Collider2D collision;
	// Use this for initialization
	void Start () {
        //tomato = GameObject.Find("tomato1");
        b = false;
        collision = GetComponent<Collider2D>();
       Debug.Log("名字"+collision);
	}
	
	// Update is called once per frame
   public void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("触发器"+"  触发了："+collision);
        b = true;
    }
	void Update () {
        Debug.Log("already2" + "判断"+b);
        if (b == true)
        {
            Debug.Log("销毁");
           // OnTriggerEnter2D(collision);
            Destroy(gameObject);
            Score += 1;
        }
	}

    
}
