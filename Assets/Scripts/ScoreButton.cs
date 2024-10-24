using UnityEngine;
using UnityEngine.UI;


public class ScoreButton : MonoBehaviour
{
    public int score;    

    public void OnClickPointUp()
    {
        score++;
    }
}
