using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public Text scoreText;
    public Text levelText;
    int score = 0;
    int level = 1;

    private void Awake() {
        instance = this;
    }
    void Start()
    {
        scoreText.text ="Score : " + score.ToString();
        levelText.text = "Level : " + level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int value){
        score += value;
        scoreText.text = "Score: " + score.ToString();
        if (score % 10  == 0 && level < 2)
        {
            level += 1;
            levelText.text = "Level: " + level.ToString();
        }
    }
    public int GetScore(){
       return score;
    }
}
