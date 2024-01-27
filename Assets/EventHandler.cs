using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventHandler : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI text;

    private int objectsCounter = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        objectsCounter--;
        text.SetText($"Counter: {objectsCounter} objects not on plane");
        Debug.Log(objectsCounter);
    }
}
