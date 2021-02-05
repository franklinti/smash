using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroPlayerScript : MonoBehaviour {

    public GameObject projetilPrefab;
    private float alturaDoSprite;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        alturaDoSprite = GetComponent<SpriteRenderer>().bounds.size.y;
        offset = new Vector3(0, alturaDoSprite/2, 0);
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Tiro"))
        {
            Vector3 vetorPosicao = transform.rotation * offset;
            Object projetil = Instantiate(projetilPrefab, transform.position + vetorPosicao, transform.rotation);

        }

	}
    
}
