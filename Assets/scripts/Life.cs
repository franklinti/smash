using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Life : MonoBehaviour
{
	public  static Life instance;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
		
    }

    
}
