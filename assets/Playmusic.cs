using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Audio))]
public class Playmusic : NetworkBehaviour 
{
   
    private Audio audiosync;
    // public int z;
    
    // Use this for initialization
    void Start () {
        audiosync= this.GetComponent<Audio>();
        
    }
	
	// Update is called once per frame
	void Update () {

		if(isLocalPlayer)
        {
            
            //if (GM.z == 1)
             
            
        }
         
}
}
