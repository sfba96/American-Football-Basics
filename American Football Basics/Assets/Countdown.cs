using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeStart = 15;
    public Text textBox;
    public Color endColor;

    public Text score;
    public Text quarters;
    public Text winner;
    public Text scoreDirection;
    public GameObject offense;
    public GameObject defense;
    public GameObject special;
    public GameObject field;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
        Invoke("showScore", 4.5f);
        Invoke("showTimer", 5.5f);
        
        Invoke("showWinner", 18f);
        Invoke("showField", 17f);
        Invoke("showOffense", 19.3f);
        Invoke("showDefense", 20.5f);
        Invoke("showSpecial", 24.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("updateTimer", 5.7f);

    }

    public void updateTimer()
    {

        timeStart -= Time.deltaTime;
        textBox.text = timeStart.ToString("F2");

        if (timeStart <= 4f)
        {
            textBox.color = endColor;
            if (timeStart < 0.2f)
            {
                textBox.text = 0.ToString("F2");
            }
        }

        if (timeStart > 11)
        {
            quarters.text = "1st";
        }
        else if (timeStart > 7 && timeStart < 11)
        {
            quarters.text = "2nd";
        }
        else if (timeStart > 4 && timeStart < 7)
        {
            quarters.text = "3rd";
        }
        else
        {
            quarters.text = "4th";
        }


        if (timeStart > 13)
        {
            score.text = "0 - 0";
        }
        else if (timeStart > 11 && timeStart < 13)
        {
            score.text = "0 - 6";
        }
        else if (timeStart > 10 && timeStart < 11)
        {
            score.text = "0 - 7";
        }
        else if (timeStart > 8 && timeStart < 10)
        {
            score.text = "7 - 7";
        }
        else if (timeStart > 6 && timeStart < 8)
        {
            score.text = "10 - 7";
        }
        else if (timeStart > 4 && timeStart < 6)
        {
            score.text = "17 - 7";
        }
        else if (timeStart > 2 && timeStart < 4)
        {
            score.text = "17 - 14";
        }
        else
        {
            score.text = "20 - 17";
        }

    }

    public void showScore()
    {
        score.enabled = true;
    }

    public void showTimer()
    {
        textBox.enabled = true;
        quarters.enabled = true;
    }

    public void showWinner()
    {
        winner.enabled = true;
        scoreDirection.enabled = true;
    }

    public void showField()
    {
        field.SetActive(true);
    }

    public void showOffense()
    {
        offense.SetActive(true);
    }

    public void showDefense()
    {
        defense.SetActive(true);
    }

    public void showSpecial()
    {
        special.SetActive(true);
    }

}
