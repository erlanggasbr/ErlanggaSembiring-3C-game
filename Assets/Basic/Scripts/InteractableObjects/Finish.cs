using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private GameObject _ui;
    private void OnCollisionEnter(Collision collision)
    {
        _ui.SetActive(true);
    }
}
