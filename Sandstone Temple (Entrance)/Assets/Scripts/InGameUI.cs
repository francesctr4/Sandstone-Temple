using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    public CollisionCounter cCounter;
    public TextMeshProUGUI textMeshPro1;
    public TextMeshProUGUI textMeshPro2;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the TextMeshProUGUI component to textMeshPro variable
        textMeshPro1 = GetComponent<TextMeshProUGUI>();
        textMeshPro2 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro1.text = "1. Pick up 2 keys to open the door (" + cCounter.collisionCount + "/2)";

        if (cCounter.collisionCount == 2)
        {
            textMeshPro2.text = "2. Open the door and proceed to the Sandstone Temple";
        }
        
    }
}
