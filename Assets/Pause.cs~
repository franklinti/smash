using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pause : MonoBehaviour
{
	GameObject pauseUI;
	Button btnPause, btnSair,btnContinue;

    // Start is called before the first frame update
    void Start()
    {
		//bntPause = GameObject.Find ("BtnPause").GetComponent<Button> ();
		pauseUI = GameObject.Find ("Pause") as GameObject;
		pauseUI.SetActive (false);
		btnPause = GameObject.Find ("BtnPause").GetComponent<Button> ();
    }
	public void PauseUI(){
		pauseUI.SetActive (true);
		pauseUI.GetComponent<Animator> ().Play ("Pause");
		AudioManager.instance.audioConfig.Play ();
		btnPause.GetComponent<Button> ().interactable = false;
		Time.timeScale = 0;	
	}

	public void UnPaused(){
		pauseUI.GetComponent<Animator> ().Play ("Unpaused");
		AudioManager.instance.audioConfig.Play ();
		btnPause.GetComponent<Button> ().interactable = true;
		Time.timeScale = 1;
		StartCoroutine (Unpaused());

	}
		IEnumerator Unpaused(){
		yield return new WaitForSeconds (0.8f);
		pauseUI.SetActive (false);
	}
   
}
