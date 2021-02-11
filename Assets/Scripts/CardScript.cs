using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardScript : MonoBehaviour
{
   
    [SerializeField] public List<TMP_Text> texts;
    
    
    public bool isChangable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if(isChangable)
        {
            int changeValue = Random.Range(-2, 10);
            int propIndex = Random.Range(0, 3);
            texts[propIndex].GetComponent<CounterAnimationScript>().SetChangable();
            texts[propIndex].GetComponent<CounterAnimationScript>().SetNums(changeValue);
            isChangable = false;
        }
    }
    public void SetChangable()
    {
        isChangable = true;
    }
}
