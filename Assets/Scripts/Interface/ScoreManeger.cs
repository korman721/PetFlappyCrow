using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManeger : MonoBehaviour
{
    public static ScoreManeger Instance { get; set; }
    [SerializeField] private TextMeshProUGUI ScoreText;
    public int score { get; set; }

    private void Start()
    {
        Instance = this;
    }

    public void SetScore(int score)
    {
        this.score += score;
        ScoreText.text = this.score.ToString();
    }
}
