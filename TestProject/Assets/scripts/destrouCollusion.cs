using UnityEngine;
using System.Collections;

public class destrouCollusion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision coll) 
    {
	    if(coll.gameObject.tag =="test01")
        {
            Destroy(coll.gameObject);
        }
	}
}
