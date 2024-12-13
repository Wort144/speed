using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float SpeedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //увеличение скорости бега
        other.GetComponent<FirstPersonMovement>().runSpeed *= SpeedFactor;
    }
    
    void Ontriggerexit(Collider other)
    {
       //понижение скорости бега
       other.GetComponent<FirstPersonMovement>().runSpeed /= SpeedFactor;
    }
}
