using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupEffect;
    [SerializeField] int pointsForCoinPickup = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinPickupEffect, Camera.main.transform.position);
        FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
        Destroy(gameObject);
    }
}
