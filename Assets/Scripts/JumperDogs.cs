using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperDogs : MonoBehaviour
{
    public float jumpForce = 10.0f;
    private DogController dogController;

    public Rigidbody2D rb;

    void OnEnable()
    {
        // dogController.onEat += OnEat;
    }

    void OnDisable()
    {
        // dogController.onEat -= OnEat;
    }

    void OnEat()
    {
        // rb.AddForce(jumpForce);
    }
    void Start()
    {
        // rb = GetComponent<Rigidforce2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
