using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;

    private PlayerMotor motor;
    private PlayerLook look;
    private Gun gun;

    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        gun = GetComponent<Gun>();
        onFoot.Jump.performed += ctx => motor.Jump(); // callback function
        onFoot.Shoot.performed += ctx => gun.Shoot(); // callback function
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
        #if UNITY_EDITOR
            if (UnityEditor.EditorApplication.isPlaying)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
        #else
            Application.Quit();
        #endif
        }
    }

    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    
    void LateUpdate()
    {
        look.ProcessLook(Mouse.current.delta.ReadValue());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }
    
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
