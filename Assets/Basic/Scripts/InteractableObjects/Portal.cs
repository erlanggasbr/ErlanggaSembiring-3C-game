using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Vector3 _portalTarget;
    [SerializeField]
    private Quaternion _rotateTarget;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = _portalTarget;
            collision.gameObject.transform.rotation = _rotateTarget;
        }
    }
}
