using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveAsteroide : MonoBehaviour {

	public float vel;
	public bool r;
	void Update(){
		transform.Translate(0, -vel * Time.deltaTime, 0);
		if (r) {
			Reposicionar ();
		}

	}
    void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.CompareTag ("bala")) {
			r = true;
			print ("ok");

		}
	}

	public  void Reposicionar()
	{
		float x = Random.Range(-2, 0);
		transform.position = new Vector2(x, 3);
	}

/*  
	public static MoveAsteroide instance;

    public float vel= 5f;
   // float alturaDoSprite;
    float posup;
    float larguraTela;

    public GameObject explosao;
	bool ap = false;
	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
       // alturaDoSprite = GetComponent<SpriteRenderer>().bounds.size.y;
		posup = Camera.main.orthographicSize;
		transform.position = new Vector2(2, posup);

        float tamanhotela = (float)Screen.width / (float)Screen.height;
		larguraTela = Camera.main.orthographicSize * tamanhotela;
	}
	
	// Update is called once per frame
	void Update () {
       
      
		if(transform.position.y < -Camera.main.orthographicSize)
       {
            Reposicionar();
        }
	
		if (ap) {
			//Instantiate(explosao);
			Reposicionar ();
			//ap = false;
			//Destroy (GameObject.FindWithTag ("asteroide"));

		}

	}
   public  void Reposicionar()
    {
        float x = Random.Range(-larguraTela, 0);
        transform.position = new Vector2(x, posup);
    }
	public void Explosao(){
		 
		//obj.transform.position = transform.position;
		//PontoManager.pontos += 1;

	}
	public void Apertar(){
		ap = true;
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag ("asteroide")) {
			Destroy (gameObject);
		}
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            VidaManager.vidas -= 1;

		}
		switch(VidaManager.vidas){
		case 0:
			SceneManager.LoadScene ("GameOver");
			break;
		}
        if(collision.tag == "bullet")
        {
            GameObject obj = Instantiate(explosao);
            obj.transform.position = transform.position;
			PontoManager.pontos += 1;
        }
		switch(PontoManager.pontos){
		//Ganha uma vida com sem asteroides destruidos
		case 5:
			VidaManager.vidas += 1;
			SceneManager.LoadScene ("Stage01");
			break;
		}
       
        reposicionar();
    }
    */
    
}
