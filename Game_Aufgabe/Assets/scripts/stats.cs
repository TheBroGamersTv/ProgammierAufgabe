﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats {
    //this is a normal c# script for the stats , it is made for enemys and the player.
    //debug
    public int level;
    public int Life;
    public int Maxlife;
    public int Damage;
    public int EXPtoNExtLvl =100;
    public int EXP = 0;


    public void SetStatstoLevel(int setlevel)
    {
        for (int i = 0; i < setlevel; i++)
        {
            level++;
            Maxlife += (Maxlife / 100) * 20 * level;
            EXPtoNExtLvl = (EXPtoNExtLvl / 100) * 20 * level;
            Damage += 5;
        }


    }
    public void EncreaseEXP(int number)
    {
        EXP += number;
    }
	public void TakingDamage(int dmg)
    {
        Life -= dmg;
    }
	
	public void EncreaseLevel()
    {
		if(EXPtoNExtLvl<=EXP)
        {
            level++;
            EXPtoNExtLvl = (EXPtoNExtLvl / 100) * 20 * level;
            Maxlife += (Maxlife / 100) * 20 * level;
            Damage += 5;
            EXP -= EXPtoNExtLvl;
        }
	}
}
