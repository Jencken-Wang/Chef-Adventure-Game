using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {
    public GameObject ingamemenu;
    public GameObject diemenu;
    public GameObject playerdie;
    public GameObject playerok;
    public string scene;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //if (player.tag == "die")
        //{
        //    Time.timeScale = 0;
        //    playerdie.SetActive(true);
        //    Debug.Log("tagedie");
        //}
        //if (player.tag == "ok")
        //{
        //    Time.timeScale = 0;
        //    playerok.SetActive(true);
        //    Debug.Log("tageok");
        //}
	}
    /**打开选关菜单**/
    public void menu()
    {
        Debug.Log("点击打开菜单测试");
        Time.timeScale = 0;
        ingamemenu.SetActive(true);
    }
    public void diemenu1()
    {
        diemenu.SetActive(true);
    }
    /**恢复功能**/
    public void resume()
    {
        Time.timeScale = 1f;
        ingamemenu.SetActive(false);
    }
    /**重开功能**/
    public void restart()
    {
        SceneManager.LoadScene(scene);
        ingamemenu.SetActive(false);
        playerdie.SetActive(false);
        playerok.SetActive(false);
        Time.timeScale = 1f;
    }
    /**跳转场景1234**/
    public void stage1()
    {
        SceneManager.LoadScene("Stage1");
        Time.timeScale = 1f;
    }
    public void stage2()
    {
        SceneManager.LoadScene("Stage2");
        Time.timeScale = 1f;
    }
    public void stage3()
    {
        SceneManager.LoadScene("Stage3");
        Time.timeScale = 1f;
    }
    public void stage4()
    {
        SceneManager.LoadScene("Stage4");
        Time.timeScale = 1f;
    }
    /**回到开始界面**/
    public void gotoMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
        Time.timeScale = 1f;
    }
}
