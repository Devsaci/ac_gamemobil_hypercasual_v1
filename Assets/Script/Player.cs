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
            { }         
        }
    }
}
