using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public
        float speed = 70f;
    public float dmg = 2f;
    public enemy HitEnemy;
    public GameObject Player;
   
    public void Getdmg(int damage)
    {
        dmg = (float)damage;
    }
	// Use this for initialization
	void Start () {
        
        
	}
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            Player.GetComponent<PlayerStats>().playerstats.Life-=dmg;
           

        }
        if(other.gameObject.tag=="Enemy")
        {
            HitEnemy = other.gameObject.GetComponent<enemy>() ;
            HitEnemy.Currentstats.Life -= dmg;
            Destroy(gameObject,0.2f);
        }
    }
    // Update is called once per frame
    void Update () {

        this.GetComponent<Rigidbody>().velocity = this.transform.forward * speed;
        
        Destroy(gameObject, 5.0f);
    }
}
