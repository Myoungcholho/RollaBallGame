using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTEST : MonoBehaviour
{
    private string name;
    public string GetterName()
    {
        return name;
    }    

    public void SetterName(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Name2
    {
        get => name;
        set => name = value;
    }

    private void Start()
    {
        Name = "hello";         //Set
        string myName = Name;   //Get
    }

    
}
