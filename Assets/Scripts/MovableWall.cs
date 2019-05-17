using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableWall : MonoBehaviour
{
    float offset;

    float time;
    public float interval;
    
    bool isOpen;
    public int direction;
    public bool reverse;

    void Start()
    {
        Collider _collider = GetComponent<Collider>();
        offset = _collider.bounds.size.x + _collider.bounds.size.z;

        time = 0;
        isOpen = false;
        reverse = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > interval)
        {
            time = 0;
            isOpen = !isOpen;

            float _offset = offset;

            if (reverse) {
                _offset = -_offset;
            }

            if (isOpen) {
                if (direction == 1) {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - offset);
                } else if (direction == 2) {
                    transform.position = new Vector3(transform.position.x - offset, transform.position.y, transform.position.z);
                }
                
            } else {
                if (direction == 1) {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);
                } else if (direction == 2) {
                    transform.position = new Vector3(transform.position.x + offset, transform.position.y, transform.position.z);
                }
                
            }
        }

        time += Time.deltaTime;
    }
}
