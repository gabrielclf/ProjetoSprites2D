﻿using UnityEngine;
using System.Collections;

public class MoveFofura: MonoBehaviour
{
	public Vector3 moveSpeed;
	public float spawnTime = 2f;
	public float spawnDelay = 2f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		moveSpeed = Vector3.left * Time.deltaTime;
		//InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
	}

	void ChangeSpeed()
	{
		moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += moveSpeed;
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.name == "Felpudo_Idle") {
			moveSpeed = Vector3.zero;//alteração
			//collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
			//Time.timeScale = 0;
		}
		
	}
}