using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject top;

    private Vector3 takipedecegiYer = new Vector3(0, 3, -9);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = top.transform.position + takipedecegiYer;
    }
}
