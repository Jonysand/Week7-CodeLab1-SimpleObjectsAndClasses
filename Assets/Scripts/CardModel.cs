using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Sprite[] districts;
    public Sprite cardBack;
    public int cardIndex; // districts[cardIndex]
    public void ToggleFace(bool showface){
        if (showface) {
            // show card face
            spriteRenderer.sprite = districts[cardIndex];
        }else{
            // show card back
            spriteRenderer.sprite = cardBack;
        }
    }
    
    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
