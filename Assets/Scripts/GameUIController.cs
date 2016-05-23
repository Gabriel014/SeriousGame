using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
	public GameObject GameOverUI;
	public GameObject ButtonUI;

	public Text gameScore;
    public Text gameHighScore;


    public Text scoreText;
    public Text highScoreText;

    
    void Start()
    {

        GameOverUI.SetActive(false);
		ButtonUI.SetActive(true);

    }

    void Update()
    {
		gameScore.text = Generate.score.ToString();
        gameHighScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }
		

    void OnGUI()
    {
        if (Trash.dead == true)
        {
            GameOverUI.SetActive(true);
			ButtonUI.SetActive(false);
            showScore();
        }
    }

    public void showScore()
    {
        //Svar score = 0;
		scoreText.text = Generate.score.ToString();
       // score = PlayerPrefs.GetInt("highScore");
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }

}