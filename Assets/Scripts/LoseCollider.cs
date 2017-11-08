﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager.LoadLevel("Win");
	}

	void OnCollisionEnter2D (Collision2D collision) {
	}
}
