using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform : MonoBehaviour
{

    [SerializeField] private Transform targetA;
    [SerializeField] private Transform targetB;
    private bool switching = false;
    [SerializeField] private int speed;

    private void Update()
    {
        if (switching == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetB.position, speed * Time.deltaTime);
        }
        else if (switching == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetA.position, speed * Time.deltaTime);
        }
        if (transform.position == targetB.position)
        {
            switching = true;
        }
        else if (transform.position == targetA.position)
        {
            switching = false;
        }

    }




}