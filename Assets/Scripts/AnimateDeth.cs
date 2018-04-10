
using UnityEngine;
using System.Collections;

public class AnimateDeth : MonoBehaviour
{
    public Player die1;
    public Hit die2;
    public Hit die3;
    public Hit die4;


    public Sprite[] sprites;
    public float framesPerSecond;
    private SpriteRenderer spriteRender;
    // Use this for initialization
    void Start()
    {
         spriteRender = GetComponent<SpriteRenderer>();
         Debug.Log(die2.colliderdie);
    }

    // Update is called once per frame
    void Update()
    {
        if (die1.booldie || die2.colliderdie || die3.colliderdie || die4.colliderdie)
        {
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites.Length;
            spriteRender.sprite = sprites[index];
        }
        
    }
}
