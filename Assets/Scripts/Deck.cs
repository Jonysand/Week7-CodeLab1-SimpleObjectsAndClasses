using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<int> cards;

    public IEnumerable<int> GetCards(){
        foreach(int i in cards){
            yield return i;
        }
    }

    public void Shuffle(){
        if(cards==null){
            cards = new List<int>();
        }else{
            cards.Clear();
        }
        // init the deck
        for(int i=0;i<30;i++){
            cards.Add(i);
        }
        // shuffle the deck
        int n = cards.Count;
        while(n>1){
            n--;
            int k = Random.Range(0, n);
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }
    private void Awake() {
        Shuffle();
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
