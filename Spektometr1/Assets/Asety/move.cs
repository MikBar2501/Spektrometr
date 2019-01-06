using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class move : MonoBehaviour
{

    // angle <-5,5>, mass (0.4,11)

    private float timer = 0;
    public double mass;
    public double angle;
    public Object punkt;
    public Object middle;
    public bool random;
    double om;
    double induction = 1;
    double elem = 1;
    double velocity = 1;
    float x = 0f;
    float y = 0f;
    float kat;
    bool flag = false;

    void Start()
    {
        if (random == true)
        {
            angle = Random.Range(-5.0f,5.0f);
            mass = Random.Range(0.4f, 11.0f);

        }

        while (angle > 5.0)
        {
            angle = angle / 6;
        }

        while (angle < -5.0)
        {
            angle = angle / 6;
        }

        if (mass < 0)
        {
            mass = mass * (-1);
        }

        if (mass < 0.3)
        {
            mass = 0.4;
        }

        while (mass > 11.0)
        {
            mass = mass / 2;
        }


        
        om = (elem * induction) / mass;
        kat = (float)(angle / 360);
        transform.position = new Vector3(x, y, 0);
        Instantiate(middle, new Vector3(x + ((float)(velocity / om) * (Mathf.Cos(kat))), (-1) * ((float)(velocity / om) * (Mathf.Sin(kat))), -1), Quaternion.identity);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == false)
        {
            transform.position = new Vector3(x + ((float)(velocity / om) * (Mathf.Cos(kat) - Mathf.Cos(((float)om * timer) + kat))), y - ((float)(velocity / om) * (Mathf.Sin(kat) - Mathf.Sin(((float)om * timer) + kat))), 0);
            Instantiate(punkt, new Vector3(x + ((float)(velocity / om) * (Mathf.Cos(kat) - Mathf.Cos(((float)om * timer) + kat))), y - ((float)(velocity / om) * (Mathf.Sin(kat) - Mathf.Sin(((float)om * timer) + kat))), 0), Quaternion.identity);
            timer += Time.deltaTime;

        }

        else
        {
            transform.position = new Vector3(x + ((float)(velocity / om) * (Mathf.Cos(kat) - Mathf.Cos(((float)om * timer) + kat))), y - ((float)(velocity / om) * (Mathf.Sin(kat) - Mathf.Sin(((float)om * timer) + kat))), 0);
        }
    }

   void OnTriggerEnter(Collider other)
    {
        // Tutaj kod wykonywany po wejściu w obszar
        if (other.tag == "wall")
        {
            //Debug.Log("zlapal");
            flag = true;
        }
    }
}
