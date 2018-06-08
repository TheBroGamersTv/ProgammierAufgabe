using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class stats : MonoBehaviour
{
    //this is a normal c# script for the stats , it is made for enemys and the player.
    //debug
    public int level;
    public float Life = 120;
    public float Maxlife = 100;
    public int Damage;
    public int EXPtoNExtLvl = 100;
    public float EXP = 0;


    public void SetStatstoLevel(int setlevel)
    {
        for (int i = 0; i < setlevel; i++)
        {
            level++;
            Maxlife += (Maxlife / 100) * 20 * level;
            EXPtoNExtLvl = (EXPtoNExtLvl / 100) * 20 * level;
            Damage += 5;
            Debug.Log(level);
        }
        Life = Maxlife;

    }
    public void EncreaseEXP(int number)
    {
        EXP += number;
    }
<<<<<<< HEAD
<<<<<<< HEAD
	public  void TakingDamage(int dmg)
    {
        Life -= dmg;
    }
	
	 public void EncreaseLevel()
=======
    public void TakingDamage(int dmg)
    {
        Life -= dmg;
    }

    public void EncreaseLevel()
>>>>>>> c9c505698378a6c81881a567111e326e1b20b26c
=======
    public void TakingDamage(int dmg)
    {
        Life -= dmg;
    }

    public void EncreaseLevel()
>>>>>>> c9c505698378a6c81881a567111e326e1b20b26c
    {
        if (EXPtoNExtLvl <= EXP)
        {
            level++;
            EXPtoNExtLvl = (EXPtoNExtLvl / 100) * 20 * level;
            Maxlife += (Maxlife / 100) * 20 * level;
            Damage += 5;
            EXP -= EXPtoNExtLvl;
        }
    }
}
