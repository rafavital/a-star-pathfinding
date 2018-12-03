using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekerBehaviour : MonoBehaviour {

    [SerializeField] private Grid grid;
    private int nodeIndex;
    private void Start()
    {
        nodeIndex = 0;
    }
    private void Update()
    {
        if (nodeIndex > grid.path.Count -1)
            nodeIndex = 0;

        MoveToPosition(nodeIndex);
        nodeIndex++;
        
    }

    private void MoveToPosition(int nodeIndex)
    {
        Vector3 nextPosition = grid.path[nodeIndex].worldPosition;
        transform.position = Vector3.Lerp(transform.position, nextPosition + Vector3.up, 0.1f);
    }

}
