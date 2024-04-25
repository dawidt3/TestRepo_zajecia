using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsControler : MonoBehaviour
{
    
    public TextMeshProUGUI textField;
    public BirdControler birdControler;
    public bool isHighscore;

    void Start()
    {
        textField.text = "0";
    }

    void Update()
    {
        if (isHighscore)
        {
            textField.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
        else
        {
            textField.text = birdControler.Points.ToString();
        }
    }
}
