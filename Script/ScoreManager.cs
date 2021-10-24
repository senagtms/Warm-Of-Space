using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public Text HingScoreText;
    public int score = 0;
    int hingscore = 0;
    public static ScoreManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        hingscore = PlayerPrefs.GetInt("hingscore", 0);
        ScoreText.text = "Score:" + score.ToString() ;
        HingScoreText.text = "HingScore:" + hingscore.ToString();
    }
    public void Addpoint()
    {
        score += 1;
        ScoreText.text = "Score"+ score.ToString();
        successLevel(score);
        if (hingscore < score)
        {
            PlayerPrefs.SetInt("hingscore", score);
        }
    }
    public void successLevel(int scoree)
    {
        if (scoree == 5)
        {
            SceneManager.LoadScene(2);
        }
    }
}
