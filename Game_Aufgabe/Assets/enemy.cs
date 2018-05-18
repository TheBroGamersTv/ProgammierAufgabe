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
    int MoveSpeed = 4;
    int MaxDist = 25;
    int MinDist = 10;

    // Use this for initialization
    void Start () {
        Currentstats.SetStatstoLevel(currentlevel);
        Player =  GameObject.FindGameObjectWithTag("Player");
        playerstats = Player.GetComponent<PlayerStats>();
        

	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player.transform);

        if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
            {
                Shoot();
            }

        }

        if (Currentstats.Life<=0)
        {
            Destroy(this.gameObject);
        }
	}
    public void Shoot()
    {

    }
}
