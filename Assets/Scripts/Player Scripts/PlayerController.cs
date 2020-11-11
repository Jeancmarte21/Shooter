using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f; // velocidad de movimiento de la nave
    public float minY, maxY; // restriccion del eje y
    public float minX, maxX; // restriccion del eje x

    [SerializeField]
    private GameObject playerBullet;

    [SerializeField]
    private Transform attackPoint;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
         
    }

    void MovePlayer(){

        if(Input.GetAxisRaw("Vertical") > 0f){

            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            if(temp.y > maxY){ 
                temp.y = maxY;
            }


            transform.position = temp; 

        }else if(Input.GetAxisRaw("Vertical") < 0f){

            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

             if(temp.y < minY){
                temp.y = minY;
            }

            transform.position = temp; 

        }else if(Input.GetAxisRaw("Horizontal") > 0f){

            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;

            if(temp.x > maxX){ 
                temp.x = maxX;
            }


            transform.position = temp; 

        }else if(Input.GetAxisRaw("Horizontal") < 0f){

            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;

            if(temp.x < minX){
                temp.x = minX;
            }

            transform.position = temp; 

        }
    }

}
