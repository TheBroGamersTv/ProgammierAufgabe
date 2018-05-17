using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public stats Currentstats;
    public int currentlevel;

    public int VIewangle = 110;
    public bool Playerwasseen;
    public GameObject Player;
    public PlayerStats playerstats;
    public CharacterController Enemy;

	// Use this for initialization
	void Start () {
        Currentstats.SetStatstoLevel(currentlevel);
        Player =  GameObject.FindGameObjectWithTag("Player");
        playerstats = Player.GetComponent<PlayerStats>();
        Enemy = this.GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
        Enemy.Move(new Vector3(0.01f,0,0.01f));

		if(Currentstats.Life<=0)
        {
            Destroy(this.gameObject);
        }
	}
}
