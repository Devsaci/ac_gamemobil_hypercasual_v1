using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Obstacle : MonoBehaviour
{
    public float speed =10.0f;

    public TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
