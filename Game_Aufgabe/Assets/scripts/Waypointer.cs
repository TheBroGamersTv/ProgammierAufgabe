﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Waypointer : MonoBehaviour {

    //public Image OnScreenSprite; // can use gameobject with spriterenderer, or reference a Sprite here, and create a new gameobject, add a sprite renderer to it.
    //public Image OffScreenSprite;
    //public List<GameObject> objects;
    

    //public Vector3 objectPoolPos;
    //Vector3 screenCenter = new Vector3(Screen.width, Screen.height, 0) * .5f;
    //public object markpoint;

    //// Use this for initialization
    //void Start()
    //{
    //    //onScreenSprites = new GameObject[objects.Count];
    //    //offScreenSprites = new GameObject[objects.Count];
    //    //Debug.Log ("Center: " + screenCenter);
    //    //create the sprites at load time
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    PlaceIndicators();
    //}

    //void PlaceIndicators()
    //{
    //    GameObject objects = GameObject.FindGameObjectWithTag("markpoint"); //find objects by type (might ahve to find by gameobejct, and then filter for AI)
       

        
    //        Vector3 screenpos = Camera.main.WorldToScreenPoint(objects.transform.position);

    //        //if onscreen
    //        if (screenpos.z > 0 && screenpos.x < Screen.width && screenpos.x > 0 && screenpos.y < Screen.height && screenpos.y > 0)
    //        {

    //            //int index = objects.IndexOf(go); // get an index to use for our sprite, based on the objects index in the objects list // we should make an objectpool manager
    //            OnScreenSprite.rectTransform.position = screenpos;
    //            //Debug.Log("OnScreen: " + screenpos);
    //        }
    //        else
    //        {
    //            PlaceOffscreen(screenpos);
    //        }
        

    //}

    //void PlaceOffscreen(Vector3 screenpos)
    //{
    //    float x = screenpos.x;
    //    float y = screenpos.y;
    //    float offset = 10;

    //    if (screenpos.z < 0)
    //    {
    //        screenpos = -screenpos;
    //    }

    //    if (screenpos.x > Screen.width)
    //    {
    //        x = Screen.width - offset;
    //    }
    //    if (screenpos.x < 0)
    //    {
    //        x = offset;
    //    }

    //    if (screenpos.y > Screen.height)
    //    {
    //        y = Screen.height - offset;
    //    }
    //    if (screenpos.y < 0)
    //    {
    //        y = offset;
    //    }

    //    OffScreenSprite.rectTransform.position = new Vector3(x, y, 0);

    //}


}

