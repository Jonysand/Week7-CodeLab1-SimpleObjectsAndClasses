using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject card;

    private void Awake() {
        cardModel = card.GetComponent<CardModel>();
    }

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnGUI() {
        if(GUI.Button(new Rect(10, 10, 100, 28), "Hit me")){
            cardModel.cardIndex = cardIndex;
            cardModel.ToggleFace(true);
            cardIndex++;
            if(cardIndex>cardModel.districts.Length-1){
                cardIndex = 0;
                cardModel.ToggleFace(false);
            }
        }
    }
}
