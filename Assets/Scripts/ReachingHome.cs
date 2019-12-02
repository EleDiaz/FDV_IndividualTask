using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachingHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D) {
        DogController dogController = collider2D.GetComponent<DogController>();
        if (dogController != null) {
            Application.Quit();
        }
    }
}
