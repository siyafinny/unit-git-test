using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //cubeの動作を記述 

	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.right * Time.deltaTime, Space.World);
	
	}
}
