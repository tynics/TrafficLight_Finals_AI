using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderGizsmo : MonoBehaviour
{
    public Vector3 size;
    public Vector3 centerPos;
    public int boxHeight;
    public int box;
    public int boxWidth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Gizmos.DrawWireCube(transform.position, new Vector3(boxWidth,boxHeight,box));
        Gizmos.DrawWireCube(centerPos, size);
    }
}
