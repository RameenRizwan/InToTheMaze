using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoring : MonoBehaviour
{
    public TMP_Text score;
    private int NumberScore;
    private static int scorenow;
    private int total;
    // Start is called before the first frame update
    void Start()
    {
        scoringsys();
        NumberScore = PlayerPrefs.GetInt("Total");

        score.SetText(NumberScore.ToString());
    }

    void scoringsys()
    {
        if (scorenow == 10)
        {
            total = PlayerPrefs.GetInt("Total");
            total += 10;
            PlayerPrefs.SetInt("Total", total);
            PlayerPrefs.Save();

        }
        scorenow += 10;
        PlayerPrefs.SetInt("Total", scorenow);
        PlayerPrefs.Save();
       
    }

}


