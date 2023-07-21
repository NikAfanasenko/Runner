using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField]
    [Range(1, 5)]
    private float _jump = 1;

    private PlayerInputSystem _inputSystem;

    private Vector3 _spawnPosition;

    private void Awake()
    {
        _inputSystem = new PlayerInputSystem();
    }
    private void OnEnable()
    {
        _inputSystem.Enable();
    }
    public void Init(Vector3 position)
    {
        _spawnPosition = position;
    }
    private void Update()
    {
        Vector2 diraction = _inputSystem.Player.Move.ReadValue<Vector2>();
        //Debug.Log(diraction);
        Jump(diraction);
    }
    private void OnDisable()
    {
        _inputSystem.Disable();
    }

    private void Jump(Vector2 diraction)
    {        
        transform.position = new Vector3(-10f, diraction.y * _jump, 0f) ;        
    }

}
