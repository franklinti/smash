using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaPrefab : MonoBehaviour {
	//script gera objetos com points definidos 
	//inicio
	public Player player;
	public GameObject enemy;
	public float spawntime =10f;
	public Transform[] spawnPoints;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating ("Spawn",spawntime,spawntime);
	}
	void Spawn()
	{
		if(player.life <= 0f){
			return;			
		}
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (enemy,spawnPoints[spawnPointIndex].position,spawnPoints[spawnPointIndex].rotation);
	}
	//fim



}
