using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterAnimationScript : MonoBehaviour
{
    private float currentNumber = 0;
    public float desiredNumber;
    public float initialNumber = 8;
    private float animationTime = 1.5f;
    private TMP_Text numberText;
    public bool isChangableText = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = initialNumber.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if(isChangableText)
        {
            if (currentNumber != desiredNumber)
            {
                if (initialNumber < desiredNumber)
                {
                    currentNumber += (animationTime * Time.deltaTime) * (desiredNumber - initialNumber);
                    if (currentNumber >= desiredNumber)
                    {
                        currentNumber = desiredNumber;
                        initialNumber = currentNumber;
                    }
                }
                else
                {
                    currentNumber -= (animationTime * Time.deltaTime) * (-desiredNumber + initialNumber);
                    if (currentNumber <= desiredNumber)
                    {
                        currentNumber = desiredNumber;
                        initialNumber = currentNumber;
                    }
                }
                gameObject.GetComponent<TextMeshProUGUI>().text = currentNumber.ToString("0");
            }
            else
            {
                isChangableText = false;
            }
        }
    }
    public void SetNums(int a)
    {
        desiredNumber = initialNumber + a;
    }
    public void SetChangable()
    {
        isChangableText = true;
    }
}
