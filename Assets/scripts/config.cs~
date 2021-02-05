using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class config : MonoBehaviour
{
	Animator anImgButtons,anIconeConfig,anInfo;
	private bool cliqueButton;
	private AudioSource ASmusic,ASconfig;
	public Sprite musicOn, musicOff;
	private  Button btnMusic;
	public GameObject info;

	void Start(){
		ASmusic = GameObject.Find("AudioManager").GetComponent<AudioSource>() as AudioSource;
		btnMusic = GameObject.Find ("BtnMusic").GetComponent<Button> ()as Button;
		ASconfig = GameObject.Find("AudioManager").GetComponent<AudioSource>() as AudioSource;
		info = GameObject.Find ("Info") as GameObject;
		info.SetActive (false);

	}
	public void AnimeConfig()
	{
		anImgButtons = GameObject.Find("ImgButtons").GetComponent<Animator>();

		if (cliqueButton == false) {

			anImgButtons.Play ("Config");
			cliqueButton = true;
			AudioManager.instance.audioConfig.Play ();
			anIconeConfig = GameObject.Find ("IconeConfig").GetComponent<Animator> ();
			anIconeConfig.Play ("IconeConfig");
		} else {
			anImgButtons.Play ("Configdown");
			anIconeConfig.Play ("IconeConfigDown");
			cliqueButton = false;
		}
	}
	public void OnOffMusic(){
		ASmusic.mute = !ASmusic.mute;
		if(ASmusic.mute == true){
			btnMusic.image.sprite = musicOff;
			AudioManager.instance.audioConfig.Play ();
		}else{
			btnMusic.image.sprite = musicOn;
			AudioManager.instance.audioConfig.Play ();
		}
	}
	public void Info(){
		if (cliqueButton == false) {
			anInfo.Play ("Info");
			cliqueButton = true;
			AudioManager.instance.audioConfig.Play ();
			//info.SetActive (false);
		} else {
			info.SetActive (true);
			anInfo = GameObject.Find("Info").GetComponent<Animator>();
			anInfo.Play ("Infodown");
			cliqueButton = false;
			AudioManager.instance.audioConfig.Play ();

		}


	}
}

