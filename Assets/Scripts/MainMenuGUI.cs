using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuGUI : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Click_test()
    {
        Debug.Log("点击测试");
        //Application.LoadLevel();
        SceneManager.LoadScene("Stage1");
        Time.timeScale = 1f;
    }
}
