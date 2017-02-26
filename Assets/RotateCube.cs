using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            transform.Rotate(0, 0, -120 * Time.deltaTime);
        }
        
	}
}
