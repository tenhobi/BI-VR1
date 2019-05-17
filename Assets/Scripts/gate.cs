using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    bool isOpen;
    private Vector3 startingPosition;
    public int requiredCount;
    HashSet<GameObject> activatedButtons;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        startingPosition = transform.position;
        activatedButtons = new HashSet<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Toggle(GameObject button) {
        activatedButtons.Add(button);

        if (activatedButtons.Count < requiredCount) {
            return;
        }

        isOpen = !isOpen;

        if (!isOpen) {
            transform.position = startingPosition;
        } else {
            transform.position = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
        }        
    }
}
