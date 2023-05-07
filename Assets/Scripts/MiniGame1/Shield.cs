using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public Transform[] transforms;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transforms[0].position;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90f));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transforms[1].position;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90f));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transforms[2].position;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0f));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transforms[3].position;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0f));
        }
    }
}
