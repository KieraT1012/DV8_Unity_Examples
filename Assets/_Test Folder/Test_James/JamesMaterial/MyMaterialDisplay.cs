using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMaterialDisplay : MonoBehaviour
{

    Transform sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        sphere.transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
