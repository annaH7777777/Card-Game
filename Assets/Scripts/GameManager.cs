using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> cards;
    int curCardIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        Fullfill();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fullfill()
    {
        for(int i = 0; i < cards.Count; i++)
        {
            cards[i].gameObject.SetActive(true);
        }
    }
    public void OnClick()
    {
        cards[curCardIndex].GetComponent<CardScript>().SetChangable();
        cards[curCardIndex].GetComponent<CardScript>().OnClick();
        if (curCardIndex <= cards.Count - 2)
            curCardIndex++;
        else
            curCardIndex = 0;
    }

}
