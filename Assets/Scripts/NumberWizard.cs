using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	public int guessMax = 10;
	int guessCount = 0;


	public Text text;

	void Start () {

		StartGame ();

	}

	void StartGame () {

		max = 1000;
		min = 1;

		NextGuess ();

	}
		
	public void GuessHigher(){
		
		min = guess;
		NextGuess ();
		++ guessCount;

	}

	public void GuessLower(){
		
		max = guess;
		NextGuess ();

	}

	void NextGuess () {

		if (guessCount >= guessMax) {
			SceneManager.LoadScene ("Win");
		} else {
			guess = Random.Range (min, max);
			text.text = guess.ToString ();
		}

		}
	}

