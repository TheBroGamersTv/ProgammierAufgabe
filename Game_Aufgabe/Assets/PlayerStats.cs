using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public stats playerstats;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        Player = GetComponent<GameObject>();
        playerstats.SetStatstoLevel(1);
	}
    public void HealLife(int Heal)
    {
        playerstats.Life += Heal;
        if(playerstats.Life>=playerstats.Maxlife)
        {
            playerstats.Life = playerstats.Maxlife;
        }
    }
    public int DoneDamage()
    {
        return playerstats.Damage;
    }
    public void TakeDamage(int dmg)
    {
        playerstats.TakingDamage(dmg);
    }

    public void GetEXP(int number)
    {
        playerstats.EncreaseEXP( number);
    }
	
	// Update is called once per frame
	void LateUpdate () {

        playerstats.EncreaseLevel();
	}
}
