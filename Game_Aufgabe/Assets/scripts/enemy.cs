using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public stats Currentstats;
    public int currentlevel;

    public int VIewangle = 110;
    public float Range = 35f;
    public bool Playerwasseen;
    public GameObject Player;
    public PlayerStats playerstats;
    int MoveSpeed = 4;
    int MaxDist = 25;
    int MinDist = 10;
    float Life;

    // Use this for initialization
    void Start () {
        Currentstats.SetStatstoLevel(currentlevel);
        Player =  GameObject.FindGameObjectWithTag("Player");
        playerstats = Player.GetComponent<PlayerStats>();
        

	}
	
	// Update is called once per frame
	void Update () {
        if (!Playerwasseen)
        {
            Vector3 dir = Player.transform.position - transform.position;
            float angle = Vector3.Angle(dir, transform.forward);
            if (angle < VIewangle * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position + new Vector3(0,0.5f,0), dir.normalized, out hit, Range))
                {
                    if (hit.collider.tag == "Player")
                    {
                        Playerwasseen = true;
                        Collider[] colliders = Physics.OverlapSphere(transform.position, 100);
                        foreach(Collider hited in colliders)
                        {
                            if(hited.tag=="Enemy")
                            {
                                 hited.GetComponent<enemy>().Playerwasseen=true;
                            }
                        }
                    }
                }

            }
        }
        else
        {
            Movetoplayer();
        }
        if (Currentstats.Life <= 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Life = Currentstats.Life;
        }
    }
    public void Movetoplayer()
    {
        transform.LookAt(Player.transform);

        if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
            {
                Shoot();
            }
            else
            {
                Shoot();
            }

        }

    }
    public void Shoot()
    {

    }
}
