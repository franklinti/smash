using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaManager : MonoBehaviour {
    public static int vidas;
    Text txtVida;
	// Use this for initialization
	void Start () {

        txtVida = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        txtVida.text = "Life: " + vidas;
	}
}
