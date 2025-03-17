using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]
    private GameObject _onButton;
    [SerializeField]
    private GameObject _offButton;
    [SerializeField]
    private GameObject _portal;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _onButton.SetActive(false);
            _offButton.SetActive(true);
            _portal.SetActive(true);
        }
    }
}
