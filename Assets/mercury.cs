using UnityEngine;
using System.Collections;

public class mercury : MonoBehaviour {
    private float rotSpeed;
    private float orbSpeed;
    private float orbRadius;
	// Use this for initialization
	void Start () {
        rotSpeed = 100000.0f / 1407.6f;
        orbRadius = 88.134f;
    }
	
	// Update is called once per frame
	void Update () {
        //        transform.Rotate(0.0f, 1.0f, 0.0f, rotSpeed);
        transform.Rotate(0.0f, rotSpeed*Time.deltaTime, 0.0f);

    }
}
