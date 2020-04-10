using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Model aModel;
    void Awake()
    {
        aModel = new Model();
        aModel.SetView(GetComponent<View>());
    }
}
