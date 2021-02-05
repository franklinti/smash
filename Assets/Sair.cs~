using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Sair : MonoBehaviour
{
	private bool clickButton =  false;

	void Update(){
		if (clickButton) {
			
			Quit ();
		}
	}
	public void Quit(){
		#if UNITY_EDITOR 
		EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}
	public void End(){
		clickButton = true;
		AudioManager.instance.audioConfig.Play ();

	}
}
