using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 size;
    private MeshRenderer renderer;
    public int counter = 0;
    public Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        
        // Debug.Log(size);
    }

    // Update is called once per frame
    void Update()
    {
        size = renderer.bounds.size;
        if (size[0] >= 1 && counter == 0)
        {
            transform.localScale -= scaleChange;
            Debug.Log("scaled. Size:" + size);
        }
        if (size[0] < 1)
        {
            counter += 1;
        }
    // Debug.Log(size);
    }
}