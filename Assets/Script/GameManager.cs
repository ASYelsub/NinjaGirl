using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Model theModel;
    void Start()
    {
        theModel = new Model();
        theModel.SetView(GetComponent<View>());
    }
}
