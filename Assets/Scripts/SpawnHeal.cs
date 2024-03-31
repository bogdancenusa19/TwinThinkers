using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnHeal : MonoBehaviour
{
    [SerializeField] private GameObject heal;

    private void Start()
    {
        Invoke("ChangeHealPosition", 5f);
    }
    
    public void Spawn()
    {
        if (heal.activeInHierarchy == false)
        {
            Invoke("ChangeHealPosition", 10f);
        }
    }

    private void ChangeHealPosition()
    {
        heal.transform.position = new Vector2(Random.Range(-52, -26), 11);
        heal.SetActive(true);
    }
}
