using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentShopManager : MonoBehaviour
{
    private List<PCComponent> availableComponents = new List<PCComponent>();

    // Start is called before the first frame update
    void Start()
    {
        // Create component instances using the constructor
        PCComponent cpu = new PCComponent("SuperFast CPU", 500, "CPU", 90);
        PCComponent gpu = new PCComponent("Ultra GPU", 700, "GPU", 95);

        // add to the list of available components
        availableComponents.Add(cpu);
        availableComponents.Add(gpu);

        // logic to display these components in the shop UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
