using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public UIManager uiManager;
    public  GameManager gameManager;
    public float strenght=4;
    public float gravity = -9.8f;
    private Vector3 direction;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;
    public int Scores;
    public int highScore;
    
    private void Awake()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }
    void Update()
    {
        
        
        if(Input.GetMouseButton(0))
        {
            direction = Vector3.up * strenght;

        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction*Time.deltaTime;
    }
    private void AnimateSprite()
    {
        spriteIndex++;
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag=="Finish")
        {
            Destroy(gameObject);
            uiManager.GameOver();
        }
        else if (other.gameObject.tag == "Score")
        {
            Scores++;
            if(highScore<=Scores)
            {
                highScore = Scores;
            }
            
        }
    }
    
    
}
