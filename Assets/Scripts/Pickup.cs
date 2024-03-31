using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject equippedGun = null;
    [SerializeField] private GameObject equippedPistol;
    [SerializeField] Sprite sprite = null;
    [SerializeField] private SpawnHeal healRef;

    private SpriteRenderer playerSprite;
    private Health health;
    private GameObject currentWeapon = null;
    

    public bool hasWeapon = false;
    private void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        health = GetComponent<Health>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Heal"))
        {
            health.RestoreHealth();
            healRef.Spawn();
            collision.gameObject.SetActive(false);
        }
        else if(!hasWeapon && collision.CompareTag("Gun"))
        {
            Destroy(collision.gameObject);
            equippedGun.SetActive(true);
            playerSprite.sprite = sprite;
            hasWeapon = true;
            currentWeapon = equippedGun;
        }
        else if(!hasWeapon && collision.CompareTag("Pistol"))
        {
            Destroy(collision.gameObject);
            equippedPistol.SetActive(true);
            playerSprite.sprite = sprite;
            hasWeapon = true;
            currentWeapon = equippedPistol;
        }
    }

    public bool GetHasWeapon()
    {
        return hasWeapon;
    }

    public GameObject GetCurrentWeapon()
    {
        return currentWeapon;
    }
    

}
