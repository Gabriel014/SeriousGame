using UnityEngine;
using System.Collections;

public class Thrash : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-3, 0);
	public float bound;
	
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

	void GameOver(){
		Application.LoadLevel(Application.loadedLevel);
	}
}