using UnityEngine;
using UnityEngine.UI;


public class ScoreUi : MonoBehaviour
{
    public ScoreButton scoreButton;
    public Text ScoreText;

    private void Update()
    {
        ScoreText.text = scoreButton.score.ToString();
    }

}
