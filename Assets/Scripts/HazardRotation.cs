using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardRotation : MonoBehaviour
{
    
    public float multiplier;

    void Update()
    {
        transform.Rotate(multiplier*Time.deltaTime, 0f ,0f);
    }

}
