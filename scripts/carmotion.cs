using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmotion : MonoBehaviour
{
   public float zspd = 0.05f;
    public float xspd = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, -0.4f ,0);
            transform.position -= new Vector3(xspd, 0, 0);
        }
       
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, 0.4f ,0);
            transform.position += new Vector3(xspd, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.C))
        {
            transform.position -= new Vector3(0, 0, zspd);
        }
        if (Input.GetKey(KeyCode.V))
        {
             transform.position += new Vector3(0, 0, zspd);
        }
          if (Input.GetKey(KeyCode.B))
        {
             transform.position -= new Vector3(xspd, 0, 0);
        }
          if (Input.GetKey(KeyCode.N))
        {
              transform.position += new Vector3(xspd, 0, 0);
        }

    }

  }