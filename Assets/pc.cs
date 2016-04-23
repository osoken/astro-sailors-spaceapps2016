using UnityEngine;
using System.Collections;

public class pc : MonoBehaviour {
    private float hp;
    private float maxHP;
	// Use this for initialization
	void Start () {
        maxHP = 200.0f;
        hp = 200.0f;
	}
	void modPCHhealth(float v)
    {
        hp += v;
        if (hp < 0.0f)
        {
            hp = 0.0f;
        }
        if (hp > maxHP)
        {
            hp = maxHP;
        }
    }
	// Update is called once per frame
	void Update () {
        	
	}
}
