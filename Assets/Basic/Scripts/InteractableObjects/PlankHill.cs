using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankHill : MonoBehaviour
{
    [SerializeField]
    private float _plankSpeed;
    [SerializeField]
    private GameObject _player;
    private bool isOnBoard = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isOnBoard = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 90 && isOnBoard)
        {
            transform.position += (Vector3.right * _plankSpeed * Time.deltaTime);
            _player.transform.position += (Vector3.right * _plankSpeed * Time.deltaTime);
        }
    }
}
