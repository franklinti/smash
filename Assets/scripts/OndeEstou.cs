using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OndeEstou : MonoBehaviour
{
	public static OndeEstou instance;

	public int level = -1;

	public GameObject gameManager,uiManager,levelManager;
	//adapta o tamanho da camera na scene
//	private float orthosize = 5;
//	private float aspect = 1.0f;

	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (gameObject);
		}
		SceneManager.sceneLoaded += VerificaLevel;
	}
	void VerificaLevel(Scene cena, LoadSceneMode mode){
		level = SceneManager.GetActiveScene ().buildIndex;
		if(level != 1){
			Instantiate (gameManager);
			//Instantiate (uiManager);
		//pega lado direito e esquerdo da camera, up, down 
		//Camera.main.projectionMatrix = Matrix4x4.Ortho (-orthosize * aspect,orthosize * aspect,-orthosize,orthosize,Camera.main.nearClipPlane,Camera.main.farClipPlane);
		}else{
			//Instantiate (levelManager);
		}
	}
}
