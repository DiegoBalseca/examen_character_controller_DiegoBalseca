using UnityEngine;
using UnityEngine.InputSystem;


public class CharacterController : MonoBehaviour
{
    private Animator _animator;
    
    private CharacterController _characterController;

    Vector3 _vector3;

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
        float VelYInput = Input.GetAxis("VelY");
        float VelXInput = Input.GetAxis("VelX");

        transform.Rotate(Vector3.up, VelXInput * _rotationSpeed * Time.deltaTime);

        Vector3 moveDirection = transform.forward * VelYInput * _playerSpeed;

        //Vector3 VelXVelocity = _characterController.velocity; 
        //VelXVelocity = new Vector3 (_characterController.velocity.x, 0, _characterController.z);

    }

    
}


