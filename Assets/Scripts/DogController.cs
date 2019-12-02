using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public enum DogState {
        Happy,
        Sad,
        Normal
    }

    // public DogState dogState = DogState.Happy;
    public float dogLife = 100.0f;
    public float movementSpeed = 1.0f;
    public Camera camera;

    private Vector2 _movement; 

    private Animator _animator;
    private Rigidbody2D _rb;

    void Awake() {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
    }

    void FixedUpdate()
    {
        // float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        // if (horizontal < 0.0f) {
        // // TODO: hacer mirror de todas las animaciones
        // }
        _rb.MovePosition(transform.position +
            new Vector3(horizontal, 0.0f, 0.0f).normalized * movementSpeed * Time.fixedDeltaTime);
    }

    void Update() {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) < 0.01) {
            _animator.SetBool("isWalking", false);
        }
        else {
            _animator.SetBool("isWalking", true);
        }


        Vector2 camPos = new Vector2(camera.transform.position.x, camera.transform.position.y);
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 smoothedCameraPosition = 
            Vector2.Lerp(camPos, playerPos, 0.0525f);

        camera.transform.position = 
            new Vector3(smoothedCameraPosition.x, smoothedCameraPosition.y, camera.transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collider2D) {
        LifeRemover lifeRemover = collider2D.GetComponent<LifeRemover>();
        BoneAction boneAction = collider2D.GetComponent<BoneAction>();
        if (lifeRemover != null) {
            _animator.SetBool("isEuforico", false);
            _animator.SetBool("isDesanimado", true);
        }
        else if (boneAction != null) {
            _animator.SetBool("isDesanimado", false);
            _animator.SetBool("isEuforico", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider2D) {
        LifeRemover lifeRemover = collider2D.GetComponent<LifeRemover>();
        BoneAction boneAction = collider2D.GetComponent<BoneAction>();
        if (lifeRemover != null) {
            _animator.SetBool("isDesanimado", false);
        }
        else if (boneAction != null) {
            _animator.SetBool("isEuforico", false);
        }
    }
}
