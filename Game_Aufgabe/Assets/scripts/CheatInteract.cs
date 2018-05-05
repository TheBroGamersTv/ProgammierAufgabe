using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatInteract : MonoBehaviour
{

    float radius = 2f;
    public Transform player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance < radius)
        {
            if(Input.GetButtonDown("Interact"))
            {
                Debug.Log("hallo");
                //nachsuaen ob rotation auuf die kist schaut
                //dannach invantar machen

            }
        }
    }
}
