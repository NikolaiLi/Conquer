using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private AttributesManager playerAtm;
    private AttributesManager enemyAtm;

    void Start() {
        playerAtm = player.GetComponent<AttributesManager>();
        enemyAtm = enemy.GetComponent<AttributesManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            playerAtm.DealDamage(enemy);
        }
        if(Input.GetKeyDown(KeyCode.F12))
        {
            enemyAtm.DealDamage(player);
        }
    }
}
