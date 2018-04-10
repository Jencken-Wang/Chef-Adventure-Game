using UnityEngine;
using System.Collections;

public class AnimateLeft : MonoBehaviour
{

    //public Sprite[] Sprites;
    //public float speed;
    //private SpriteRenderer spriterenderer;

    public Sprite[] sprites2;
    public float framesPerSecond;
    private SpriteRenderer spriteRender;
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites2.Length;
            spriteRender.sprite = sprites2[index];
        }
    }
}