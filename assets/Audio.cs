﻿using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class Audio : NetworkBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;
   
    // Use this for initialization
    void Start () {
        source = this.GetComponent<AudioSource>();
    }
    public void PlaySound(int id)
    {
        if (id >= 0 && id < clips.Length)
        {
            CmdSendServerSoundID(id);
        }
    }

   // [Command]
    void CmdSendServerSoundID(int id)
    {
        RpcSendSoundIDToClients(id);
    }
   // [ClientRpc]
    void RpcSendSoundIDToClients(int id)
    {
            source.PlayOneShot(clips[id]);
         
    }
    // Update is called once per frame
    void Update () {
        //source.PlaySound(0);
	}
}
