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
        heal.transform.position = new Vector2(Random.Range(-52, -26), 11);
        heal.SetActive(true);
    }

    public void SpawnLate()
    {
        Invoke("SpawnHealRandom", 10f);
    }
    private void SpawnHealRandom()
    {
        if (heal.activeInHierarchy == false)
        {
            heal.transform.position = new Vector2(Random.Range(-52, -26), 11);
            heal.SetActive(true);
        }
    }
    
}
