using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Color color;

    public Transform[] cubos;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = color;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z)) {

            if (cubos[0].position.x < 4)
            {
                cubos[0].transform.position += Vector3.right;
            }
            else if(cubos[0].position.x <= 4)
            {
                cubos[0].transform.position =  Vector3.zero;
            }
            
  
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            if (cubos[1].position.x < 4)
            {
                cubos[1].transform.position += Vector3.right;
            }
            else if (cubos[1].position.x <= 4)
            {
                cubos[1].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            if (cubos[2].position.x < 4)
            {
                cubos[2].transform.position += Vector3.right;
            }
            else if (cubos[2].position.x <= 4)
            {
                cubos[2].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            if (cubos[3].position.x < 4)
            {
                cubos[3].transform.position += Vector3.right;
            }
            else if (cubos[3].position.x <= 4)
            {
                cubos[3].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
                 if (cubos[4].position.x < 4)
            {
                cubos[4].transform.position += Vector3.right;
            }
            else if (cubos[4].position.x <= 4)
            {
                cubos[4].transform.position = Vector3.zero;
            }
        }

    
       else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (cubos[0].position.x < -4)
            {
                cubos[0].transform.position += Vector3.left;
            }
            else if (cubos[0].position.x <= -4)
            {
                cubos[0].transform.position = Vector3.zero;
            }

            cubos[0].transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (cubos[1].position.x < -4)
            {
                cubos[1].transform.position += Vector3.left;
            }
            else if (cubos[1].position.x <= -4)
            {
                cubos[1].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (cubos[2].position.x < -4)
            {
                cubos[2].transform.position += Vector3.left;
            }
            else if (cubos[2].position.x <= -4)
            {
                cubos[2].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (cubos[3].position.x < -4)
            {
                cubos[3].transform.position += Vector3.left;
            }
            else if (cubos[3].position.x <= -4)
            {
                cubos[3].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            if (cubos[4].position.x < -4)
            {
                cubos[4].transform.position += Vector3.left;
            }
            else if (cubos[4].position.x <= -4)
            {
                cubos[4].transform.position = Vector3.zero;
            }
        }


        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (cubos[0].position.y < 4)
            {
                cubos[0].transform.position += Vector3.up;
            }
            else if (cubos[0].position.y <= 4)
            {
                cubos[0].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (cubos[1].position.y < 4)
            {
                cubos[1].transform.position += Vector3.up;
            }
            else if (cubos[1].position.y <= 4)
            {
                cubos[1].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (cubos[2].position.y < 4)
            {
                cubos[2].transform.position += Vector3.up;
            }
            else if (cubos[2].position.y <= 4)
            {
                cubos[2].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (cubos[3].position.y < 4)
            {
                cubos[3].transform.position += Vector3.up;
            }
            else if (cubos[3].position.y <= 4)
            {
                cubos[3].transform.position = Vector3.zero;
            }
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (cubos[4].position.y < 4)
            {
                cubos[4].transform.position += Vector3.up;
            }
            else if (cubos[4].position.y <= 4)
            {
                cubos[4].transform.position = Vector3.zero;
            }
        }

        
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            cubos[0].transform.position = Vector3.zero;
            cubos[1].transform.position = Vector3.zero;
            cubos[2].transform.position = Vector3.zero;
            cubos[3].transform.position = Vector3.zero;
            cubos[4].transform.position = Vector3.zero;
        }







    }
}
