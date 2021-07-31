using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    void Start()
    {
        if (!instance)
        {
            instance = this;
        }
    }

}
