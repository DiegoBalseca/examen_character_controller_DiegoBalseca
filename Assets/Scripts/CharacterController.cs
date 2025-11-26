using UnityEngine;
using UnityEngine.InputSystem;


public class CharacterController : MonoBehaviour
{
    private Animator _animator;
    
    private CharacterController _characterController;

    private Vector3 _vector3;

    private float _playerSpeed = 5.5f;

    private float _jumpHeight = 2.5f;

    private float _gravity = -9.81f;

    private float _rotationSpeed = 90.0f;  

    

    void Start()
    {
       // _animator = GetComponent<Animator>();
       // _characterController = GetComponent<CharacterController>();

       _characterController = GetComponent<CharacterController>();

        
    }

    void Update()
    {
        float VelY = Input.GetAxis("Vertical");
        float VelX = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, VelX * _rotationSpeed * Time.deltaTime);

        Vector3 moveDirection = transform.forward * VelY * _playerSpeed;


    }
}


