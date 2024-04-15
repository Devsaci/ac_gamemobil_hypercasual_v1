using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Touch touch;
    public float speed;
    public float poXxmin;
    public float poXxmax;


    // 
    void Update()
    {
        //Si le joueur a au moin un doigt sur l'écran
        if (Input.touchCount > 0)
        {
            // On recuper les infos du premier doigt posé sur l'écran tactil
            touch = Input.GetTouch(0);

            // On teste si le joueur bouge le doigt
            if(touch.phase == TouchPhase.Moved) 
            {
            // On bouge le cube en suivant le mouvement du doigt
            transform.position = new Vector3 (
                 transform.position.x + touch.deltaPosition.x * speed,
                 transform.position.y,
                 transform.position.z
                );
            
            }         
        }
        // Bloquer le cube entre 2 valeurs sur l'axe des X
        if (transform.position.x < poXxmin)
        {
            transform.position = new Vector3(
                poXxmin,
                transform.position.y,
                transform.position.z
                );

        }

        if (transform.position.x > poXxmax)
        {
            transform.position = new Vector3(
                poXxmax,
                transform.position.y,
                transform.position.z
                );
        }



    }



}
