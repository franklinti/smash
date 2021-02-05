using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGOScript : MonoBehaviour {
	// Update is called once per frame
	void DestroyGO() {
		
        Destroy(gameObject,0.05f);
	}


}
