using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ---> to access Slider

public class PlayerStats : MonoBehaviour
{

    public stats playerstats;
    public GameObject Player;
    public Slider LifeSlider;
    public Slider XPSlider;
    public float Life;
    public float XP;

<<<<<<< HEAD
	// Use this for initialization
	void Start () {
        Player = this.GetComponent<GameObject>();
=======
    // Use this for initialization
    void Start()
    {
        // Player = GetComponent<GameObject>();
>>>>>>> c9c505698378a6c81881a567111e326e1b20b26c
        playerstats.SetStatstoLevel(1);
    }
    public void HealLife(int Heal)
    {
        playerstats.Life += Heal;
        if (playerstats.Life >= playerstats.Maxlife)
        {
            playerstats.Life = playerstats.Maxlife;
        }
        
    }

    void Update()//Updating
    {
        Life = playerstats.Life / playerstats.Maxlife * 100;
        SetHealth();

        XP = playerstats.EXP;
        SetXP();

    }
    public void SetHealth()//setting the Healthbar UI to the Health
    {
       // Life= Life / playerstats.Maxlife * 100;
        LifeSlider.value = Life;
        Debug.Log(Life);
    }
    public void SetXP()//setting the EXPbar UI to the XP
    {
        XPSlider.value = XP;
        Debug.Log(XP);
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
        playerstats.EncreaseEXP(number);
    }

    // Update is called once per frame
   /* void LateUpdate()
    {

        playerstats.EncreaseLevel();
    }*/
}
