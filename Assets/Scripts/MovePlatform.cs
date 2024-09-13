using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(4,0,0) * Time.deltaTime; //* Time.deltaTime to equalize the speed
    }
}
