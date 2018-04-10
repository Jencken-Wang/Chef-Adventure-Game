using UnityEngine;
using System.Collections;

public class AnimateRL : MonoBehaviour
{

    //public Sprite[] Sprites;
    //public float speed;
    //private SpriteRenderer spriterenderer;
    public Sprite[] sprites;
    //public Sprite[] sprites2;
    public float framesPerSecond;
    private SpriteRenderer spriteRender;
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites.Length;
            spriteRender.sprite = sprites[index];
        }
        //else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //{
        //    int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
        //    index = index % sprites2.Length;
        //    spriteRender.sprite = sprites[index];
        //}
    }
}