using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject card;

    private void Awake() {
        cardModel = card.GetComponent<CardModel>();
        flipper = card.GetComponent<CardFlipper>();
    }

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnGUI() {
        if(GUI.Button(new Rect(10, 10, 100, 28), "Hit me")){
            if(cardIndex>0){
                flipper.FlipCard(cardModel.districts[cardIndex-1], cardModel.districts[cardIndex],cardIndex);
            }else{
                flipper.FlipCard(cardModel.cardBack, cardModel.districts[cardIndex],cardIndex);
            }
            cardIndex++;
            if(cardIndex>cardModel.districts.Length-1){
                cardIndex = 0;
                flipper.FlipCard(cardModel.districts[cardModel.districts.Length-1], cardModel.cardBack,-1);
            }
        }
    }
}
