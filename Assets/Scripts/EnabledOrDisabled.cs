using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledOrDisabled : MonoBehaviour
{
    public GameObject laser;

    private bool active = false;
    public float activeTime = 0.5f;
    private float timer = 0;

    void Update() {
        if(Input.GetKey(KeyCode.Space)){
            laser.SetActive(true);
            active = true;
            timer = activeTime;
        }
        if(active) {
            timer -= Time.deltaTime;
        }
        if(active && timer <= 0) {
            active = false;
            laser.SetActive(false);
        }
    }
}