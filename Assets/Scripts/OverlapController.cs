using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapController : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layerMask;

    void Start()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius, _layerMask);

        foreach (var item in colliders)
        {
            item.gameObject.transform.localScale *= 2f;
            Debug.Log(item.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
