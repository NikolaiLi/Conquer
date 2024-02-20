using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSound : MonoBehaviour
{
    public AudioSource footstepsSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            footstepsSound.enabled = true;
         }
         else
         {
            footstepsSound.enabled = false;
         }
    }
}