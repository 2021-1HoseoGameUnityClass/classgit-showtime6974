using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{

    private static DataManager _instance = null;
    public static DataManager instance { get { return _instance; } }

    public int playerHP = 3;

    
    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
