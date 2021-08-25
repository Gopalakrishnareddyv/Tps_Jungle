using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] float turnSpeed;
    [SerializeField] float gravity;
    CharacterController character;
    Animator animator;
    public static PlayerMovement instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizotal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizotal, 0, vertical);
        //movement.y += Physics.gravity.y * gravity;
        animator.SetFloat("Blend", vertical);
        transform.Rotate(Vector3.up, horizotal * turnSpeed * Time.deltaTime);
        character.SimpleMove(transform.forward*vertical  * playerSpeed * Time.deltaTime);
    }

}
