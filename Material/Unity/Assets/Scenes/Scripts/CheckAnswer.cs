using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public int Right, Wrong;
    public GameObject ScoreText;


    public void CountRight()
    {
        Right++;
        ScoreText.GetComponent<Text>().text = Right.ToString();
    }
    public void CountWrong()
    {
        Wrong++;
        ScoreText.GetComponent<Text>().text = Wrong.ToString();

    }

}