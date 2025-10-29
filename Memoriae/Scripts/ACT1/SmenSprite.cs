using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmenSprite : MonoBehaviour
{
public SpriteRenderer spriteRenderer;
public GameObject gameObjects;
public Sprite[] spriteArray;
public int currentSprite;
void Start() 
{
    spriteRenderer.sprite = spriteArray[ Random.Range(0, spriteArray.Length)]; 
}
void OnMouseDown()
   {
    spriteRenderer.sprite = spriteArray[currentSprite];
    currentSprite++;

    if(currentSprite >= spriteArray.Length)
    {
        currentSprite = 0;
    }
   }
   void update()
   {
        
   }
}

