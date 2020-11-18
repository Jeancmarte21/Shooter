using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f; // velocidad de movimiento de la nave
    public float minY, maxY; // restriccion del eje y
    public float minX, maxX; // restriccion del eje x

    [SerializeField]
    private GameObject player_Bullet;

    [SerializeField]
    private Transform attack_Point;

    public float attack_Timer = 0.35f;
    private float current_Attack_Timer;
    private bool canAttack;

    public Transform bulletSpawner;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start() {
        current_Attack_Timer = attack_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Attack();
        PlayerShooting();

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

    void Attack() {

        attack_Timer += Time.deltaTime;
        if (attack_Timer > current_Attack_Timer) {
            canAttack = true;
        }

        if (Input.GetKeyDown(KeyCode.K)) {
            if (canAttack) {

                canAttack = false;
                attack_Timer = 0f;
                Instantiate(player_Bullet, attack_Point.position, Quaternion.identity);

            }
        } 
    }

    public void PlayerShooting()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation);

        }

    }

}
