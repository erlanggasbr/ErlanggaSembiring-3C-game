using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    [SerializeField]
    private float _plankSpeed;
    [SerializeField]
    private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= -15)
        {
            transform.position += (Vector3.forward * _plankSpeed * Time.deltaTime);
            _player.transform.position += (Vector3.forward * _plankSpeed * Time.deltaTime);
        }
    }
}
