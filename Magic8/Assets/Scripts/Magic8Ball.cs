using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Magic8Ball : MonoBehaviour
{
    public TextMeshProUGUI AnswersText;
    public List<string> ballAnswers;
    public Slider mySlider;

    void Awake()
    {
        float currentValue = mySlider.value; 
    }
  
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SliderValue();
        }
    }

    public void ButtonPress() 
    {
        SliderValue();
    }

    public void SliderValue() 
    {
        if (mySlider.value >= 0 && mySlider.value <= .2)
        {
            int index = Random.Range(0, 3);

            AnswersText.text = ballAnswers[index];
        }
        else if (mySlider.value > .2 && mySlider.value <= .4)
        {
            int index = Random.Range(4, 7);

            AnswersText.text = ballAnswers[index];
        }
        else if (mySlider.value > .4 && mySlider.value <= .6)
        {
            int index = Random.Range(8, 11);

            AnswersText.text = ballAnswers[index];
        }
        else if (mySlider.value > .6 && mySlider.value <= .8)
        {
            int index = Random.Range(12, 15);

            AnswersText.text = ballAnswers[index];
        }
        else if (mySlider.value > .8 && mySlider.value <= 1)
        {
            int index = Random.Range(16, 19);

            AnswersText.text = ballAnswers[index];
        }
    }
}
