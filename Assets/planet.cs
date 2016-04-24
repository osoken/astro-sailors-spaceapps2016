using UnityEngine;
using System.Collections;

public class planet : MonoBehaviour {
    private float diameter;
    private float rotationPeriod;
    private float perihelion;
    private float aphelion;
    private float orbitalPeriod;
    private float orbitalVelocity;
    private float orbitalInclination;

	// Use this for initialization
	void Start () {
	
	}
    public void Set(float d, float r, float per, float aph, float orbp, float orbv, float orbi)
    {
        diameter = d;
        rotationPeriod = r;
        perihelion = per;
        aphelion = aph;
        orbitalPeriod = orbp;
        orbitalVelocity = orbv;
        orbitalInclination = orbi;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(1.0f, 1.1f, 1.0f);
	}
}
