using UnityEngine;
using System.Collections;

public class Trash : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-3, 0);
	public float bound;
	public static bool dead = false;
	// This method adds velocity to the object
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
	}

	// This method destroys the object when it pass across a previously defined bound
	void Update()
	{
		if (gameObject.transform.position.y < bound){
			Destroy(this.gameObject);
			GameOver ();
		}
	}

	public static void GameOver(){
		dead = true;
		Trash.SaveScore();
//		Time.timeScale = 0;
//		Application.LoadLevel(Application.loadedLevel);
	}

	public static void SaveScore(){
		PlayerPrefs.SetInt("currentScore", Generate.score);
		if (PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highScore")){
			PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("currentScore"));
		}
	}
}