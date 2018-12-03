﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public bool walkable;
    public Vector3 worldPosition;
    public int gridX, gridY;
    public Node parent;

    public int gCost;
    public int hCost;

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }

    public Node (bool _walkable, Vector3 _worldPos, int _gridX, int _gridY)
    {
        this.walkable = _walkable;
        this.worldPosition = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }
}
