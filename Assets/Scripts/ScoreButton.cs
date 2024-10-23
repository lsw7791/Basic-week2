using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;

    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp); // 메소드를 연결할 때는 () 안붙임.
    }

    void PointUp()
    {
        score++;
    }
}
