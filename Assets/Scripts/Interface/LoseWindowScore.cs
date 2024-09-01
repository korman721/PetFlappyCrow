
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoseWindowScore : MonoBehaviour
{
    public TextMeshProUGUI scoreTxet;
    public TextMeshProUGUI bestScoreTxt;

    public void PlayerLose()
    {
        int score = ScoreManeger.Instance.score;
        scoreTxet.text = "Score: " + score.ToString();
        int bestscore = PlayerPrefs.GetInt("BestScore");
        if (score > bestscore)
        {
            bestscore = score;
        }

        bestScoreTxt.text = "Best: " + bestscore.ToString();
        PlayerPrefs.SetInt("BestScore", bestscore);

    }
}
