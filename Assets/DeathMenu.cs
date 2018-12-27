﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {
	public Text scoreText;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleEndMenu(float score){
		gameObject.SetActive (true);
		scoreText.text = ((int)(score)).ToString ();
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Debug.Log ("restarting..");
	}
}
