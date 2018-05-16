using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public stats Currentstats;
    public int currentlevel;
	// Use this for initialization
	void Start () {
        Currentstats.SetStatstoLevel(currentlevel);
	}
	
	// Update is called once per frame
	void Update () {


		if(Currentstats.Life<=0)
        {
            Destroy(this.gameObject);
        }
	}
}
