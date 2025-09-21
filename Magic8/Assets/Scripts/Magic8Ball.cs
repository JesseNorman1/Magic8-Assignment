using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magic8Ball : MonoBehaviour
{
    public TextMeshProUGUI AnswersText;
    public List<string> ballAnswers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, ballAnswers.Count);

            AnswersText.text = ballAnswers[index];
        }
    }

    public void ButtonPress() 
    {
        int index = Random.Range(0, ballAnswers.Count);

        AnswersText.text = ballAnswers[index];
    }
}
