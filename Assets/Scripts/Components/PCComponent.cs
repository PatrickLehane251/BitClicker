using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCComponent
{
    public string componentName;
    public int cost;
    public string type;
    public int performanceScore;

    // Constructor
    public PCComponent(string name, int cost, string type, int score)
    {
        this.componentName = name;
        this.cost = cost;
        this.type = type;
        this.performanceScore = score;
    }


// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
