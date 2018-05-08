using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats {

    public int level;
    public int Life;
    public int Damage;
    public int EXPtoNExtLvl =100;
    public int EXP = 0;
    

	public void SetStatstoLevel(int setlevel)
    {
        for (int i = 0; i < setlevel; i++)
        {
            level++;
            Life += (Life / 100) * 20 * level;
            Damage += 5;
        }
    }
	public void TakingDamage(int dmg)
    {
        Life -= dmg;
    }
	// Update is called once per frame
	public void EncreseLevel()
    {
		if(EXPtoNExtLvl<=EXP)
        {
            level++;
            EXPtoNExtLvl = (EXPtoNExtLvl / 100) * 20 * level;
            Life += (Life / 100) * 20 * level;
            Damage += 5;
            EXP -= EXPtoNExtLvl;
        }
	}
}
