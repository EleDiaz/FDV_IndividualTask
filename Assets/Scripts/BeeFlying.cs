using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeFlying : MonoBehaviour
{
    public float horizontalDisp = 5.0f;
    public float verticalDisp = 5.0f;
    public float speed = 1.0f;

    private Vector2 fixedPosition;
    private Vector2 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        fixedPosition = new Vector2(transform.position.x, transform.position.y);
        StartCoroutine("CalculateNewPostition");
    }

    public IEnumerator CalculateNewPostition() {
        newPosition = new Vector2(Random.Range(-horizontalDisp, horizontalDisp), Random.Range(-verticalDisp, verticalDisp));
        yield return new WaitForSeconds(speed / newPosition.sqrMagnitude);
        CalculateNewPostition();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 aux = newPosition.normalized * Time.deltaTime * speed;
        transform.position += new Vector3(aux.x, aux.y, transform.position.z);
    }
}
