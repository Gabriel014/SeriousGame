﻿using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject paper;
		public Sprite paper1;
		public Sprite paper2;
		public Sprite paper3;

	public GameObject plastic;
		public Sprite plastic1;
		public Sprite plastic2;
		public Sprite plastic3;

	public GameObject metal;
		public Sprite metal1;
		public Sprite metal2;
		public Sprite metal3;

	public GameObject glass;
		public Sprite glass1;
		public Sprite glass2;
		public Sprite glass3;

	int next;
	int sprite;

	// Randomize values to the variables that will randomize the thrash and its sprite
	void Start () {
		next = Random.Range(1, 5);
		sprite = Random.Range (1, 4);
		InvokeRepeating("ThrashRandomizer", 1f, 0.5f);
	}
	
	// This method randomizes the next thrash to be showed in the screen
	void ThrashRandomizer () {
		SpriteRandomizer ();

		switch (next){
			case 1: 
				Instantiate(paper);
				break;
			case 2:	
				Instantiate (plastic);
				break;
			case 3:	
				Instantiate(metal);
				break;
			case 4:	
				Instantiate(glass);
				break;
		}

		next = Random.Range(1, 5);
		sprite = Random.Range (1, 4);

	}


	// This method randomizes the sprite of the next thrash to be showed in the screen
	void SpriteRandomizer (){
		switch (next){
		case 1:
			if (sprite == 1) paper.GetComponent<SpriteRenderer>().sprite = paper1;
			if (sprite == 2) paper.GetComponent<SpriteRenderer>().sprite = paper2;
			if (sprite == 3) paper.GetComponent<SpriteRenderer>().sprite = paper3;
			break;

		case 2:
			if (sprite == 1) plastic.GetComponent<SpriteRenderer>().sprite = plastic1;
			if (sprite == 2) plastic.GetComponent<SpriteRenderer>().sprite = plastic2;
			if (sprite == 3) plastic.GetComponent<SpriteRenderer>().sprite = plastic3;
			break;

		case 3:
			if (sprite == 1) metal.GetComponent<SpriteRenderer>().sprite = metal1;
			if (sprite == 2) metal.GetComponent<SpriteRenderer>().sprite = metal2;
			if (sprite == 3) metal.GetComponent<SpriteRenderer>().sprite = metal3;
			break;

		case 4:
			if (sprite == 1) glass.GetComponent<SpriteRenderer>().sprite = glass1;
			if (sprite == 2) glass.GetComponent<SpriteRenderer>().sprite = glass2;
			if (sprite == 3) glass.GetComponent<SpriteRenderer>().sprite = glass3;
			break;
		}
	}
}