using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public AudioSource select;

	private void Start(){
		select = GetComponent<AudioSource>();
	}

	public void NextScene(){
		select.Play ();
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void MainMenu(){
		select.Play ();
		SceneManager.LoadScene (0);
	}
}


