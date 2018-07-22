using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    public GameObject obstacle;
    public GameObject Player;
    public float timeBetween = 3.0f;
    public float nextOblectDiatant = 30.0f;
    public float nextObjectTime;

    // Use this for initialization
    private void Start()
    {
        nextObjectTime = Time.time;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > nextObjectTime)
        {

            Instantiate(obstacle, new Vector3(Player.transform.position.x, -4, Player.transform.position.z + nextOblectDiatant), Quaternion.identity);
            nextObjectTime = Time.time + timeBetween;
        }

        //TODO1 Instantiate the object here
        //Quaternion.Euler is the rotation of your object

        //

        //TODO2 Use an if statment to control when the object spawns

        /* There are two main ways of spawning objects
        *    
        * One version is to spawn a new one every few seconds. 
        * You can find the number of seconds since your game started by using Time.time
        * 
        * The other version is to spawn a new one after the player has travelled a certain distance.
        * To do this you will need the z position of the player
        */


    }

}
