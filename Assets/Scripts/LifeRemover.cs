using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeRemover : MonoBehaviour
{
    private float _damageAmount;
    public float minDamageAmount = 10.0f;
    public float maxDamageAmount = 30.0f;

    void Awake() {
        _damageAmount = Random.Range(minDamageAmount, maxDamageAmount);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D) {
        DogController dogController = collider2D.GetComponent<DogController>();
        if (dogController != null) {
            dogController.dogLife -= _damageAmount;
        }
    }
}
