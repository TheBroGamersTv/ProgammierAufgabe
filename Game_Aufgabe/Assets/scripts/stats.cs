using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour {

    public int level;
    public int Life;
    public int Damage;
    public int EXPtoNExtLvl =100;
    public int EXP = 0;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(EXPtoNExtLvl<=EXP)
        {
            level++;
            EXPtoNExtLvl = (EXPtoNExtLvl / 100) * 20 * level;
            Life += (Life / 100) * 20 * level;
            Damage += 5;
        }
        if (Life == 0)
        {
            //sterbens sequenz;
        }
	}
}
