using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    private GameObject _elevator;
    [SerializeField]
    private float _elevatorSpeed;
    private bool _isUsed;

    private void Awake()
    {
        _isUsed = false;
    }

    private void FixedUpdate()
    {
        Debug.Log(_isUsed);
        if (_isUsed)
        {
            if (_elevator.transform.position.y >= 0.1f)
            {
                Debug.Log("go down");
                _elevator.transform.position += (Vector3.down * _elevatorSpeed * Time.deltaTime);
            }
        }
        else 
        {
            if (_elevator.transform.position.y <= 5.45f)
            {
                _elevator.transform.position += (Vector3.up * _elevatorSpeed * Time.deltaTime);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _isUsed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _isUsed = false;
        }
    }
}
