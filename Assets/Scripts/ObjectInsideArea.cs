using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ObjectInsideArea : MonoBehaviour
{
    private BoxCollider _areaCollider;
    private bool _droveInto;

    private void Awake()
    {
        _areaCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (_areaCollider.bounds.Contains(other.bounds.min) && _areaCollider.bounds.Contains(other.bounds.max) && !_droveInto)
        {
            _droveInto = true;
        }
    }
}
