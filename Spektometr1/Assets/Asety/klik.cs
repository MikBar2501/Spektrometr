using UnityEngine;
using System.Collections;

public class klik : MonoBehaviour
{

   
    public GUISkin menuSkin;
    public Rect reset;
    public Rect started;
    public Rect masa;
    public Rect kat;
    public Rect opis;
    public Rect quit;
    public Rect menuArea;
    Rect normalizedMenuArea;
    public GameObject elem1;
    public GameObject elem2;
    public GameObject elem3;
    public GameObject mass1;
    public GameObject mass2;
    public GameObject mass3;
    public GameObject angle1;
    public GameObject angle2;
    public GameObject angle3;
    bool start = false;
    bool rainbow = false;
    move[] kulki = FindObjectsOfType<move>();
    



    void OnGUI()
    {
        move[] kulki = FindObjectsOfType<move>();


        GUI.Box(new Rect(Screen.width - 330, Screen.height - 30, 320, 25), "Spektrometr masowy, Mikołaj Bartoszek 26.05.2016");

        if (start == true)
        {
            //Debug.Log("kulki.Length: " + kulki.Length);

            GUI.Box(new Rect(Screen.width - 300, Screen.height - 710, 290, 25), "Masa czerw: " + kulki[0].mass + " * 10^(-25) kg]");
            GUI.Box(new Rect(Screen.width - 260, Screen.height - 680, 250, 25), "Kąt (stopnie): " + kulki[0].angle);
            GUI.Box(new Rect(Screen.width - 300, Screen.height - 650, 290, 25), "Masa nieb [kg]: " + kulki[1].mass + " * 10^(-25) kg");
            GUI.Box(new Rect(Screen.width - 260, Screen.height - 620, 250, 25), "Kąt (stopnie): " + kulki[1].angle);
            GUI.Box(new Rect(Screen.width - 300, Screen.height - 590, 290, 25), "Masa ziel [kg]: " + kulki[2].mass + " * 10^(-25) kg");
            GUI.Box(new Rect(Screen.width - 260, Screen.height - 560, 250, 25), "Kąt (stopnie): " + kulki[2].angle);
        }

        if (GUI.Button(new Rect(Screen.width - 870, Screen.height - 30, 50, 20), "Reset"))
        {

            Application.LoadLevel("spek");
            //Debug.Log("Clicked the button with text");
        }

        if (GUI.Button(new Rect(Screen.width - 810, Screen.height - 30, 50, 20), "Los"))
        {

            if (start == false)
            {

                Instantiate(elem3, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(elem2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(elem1, new Vector3(0, 0, 0), Quaternion.identity);
                start = true;
            }

        }
        if (GUI.Button(new Rect(Screen.width - 750, Screen.height - 30, 50, 20), "Masa"))
        {

            if (start == false)
            {

                Instantiate(mass3, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(mass2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(mass1, new Vector3(0, 0, 0), Quaternion.identity);
                start = true;
            }

        }

        if (GUI.Button(new Rect(Screen.width - 690, Screen.height - 30, 50, 20), "Kąt"))
        {

            if (start == false)
            {

                Instantiate(angle3, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(angle2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(angle1, new Vector3(0, 0, 0), Quaternion.identity);
                start = true;
            }

        }
        if (GUI.Button(new Rect(Screen.width - 1000, Screen.height - 690, 20, 20), "X"))
        {
            Application.Quit();
        }

    }
        
    }



/*
move[] kulki = FindObjectsOfType<move>();


GUI.Box(new Rect(550, 295, 320, 25), "Spektrometr masowy, Mikołaj Bartoszek 17.05.2016");

        if (start == true) {
            //Debug.Log("kulki.Length: " + kulki.Length);
           
            GUI.Box(new Rect(580, 10, 290, 25), "Masa czerw: " + kulki[0].mass + " * 10^(-25) kg]");
            GUI.Box(new Rect(620, 40, 250, 25), "Kąt (stopnie): " + kulki[0].angle);
            GUI.Box(new Rect(580, 70, 290, 25), "Masa nieb [kg]: " + kulki[1].mass + " * 10^(-25) kg");
            GUI.Box(new Rect(620, 100, 250, 25), "Kąt (stopnie): " + kulki[1].angle);
            GUI.Box(new Rect(580, 130, 290, 25), "Masa ziel [kg]: " + kulki[2].mass + " * 10^(-25) kg");
            GUI.Box(new Rect(620, 160, 250, 25), "Kąt (stopnie): " + kulki[2].angle);
        }

        if (GUI.Button(new Rect(10, 300, 50, 20), "Reset"))
        {

            Application.LoadLevel("spek");
            //Debug.Log("Clicked the button with text");
        }

        if (GUI.Button(new Rect(70, 300, 50, 20), "Start"))
        {
            
            if (start == false)
            {

               Instantiate(elem3, new Vector3(0, 0, 0), Quaternion.identity);
               Instantiate(elem2, new Vector3(0, 0, 0), Quaternion.identity);
               Instantiate(elem1, new Vector3(0, 0, 0), Quaternion.identity);
               start = true;
            }

            }
        if (GUI.Button(new Rect(130, 300, 50, 20), "Masa"))
        {

            if (start == false)
            {

                Instantiate(mass3, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(mass2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(mass1, new Vector3(0, 0, 0), Quaternion.identity);
                start = true;
            }

        }

        if (GUI.Button(new Rect(190, 300, 50, 20), "Kąt"))
        {

            if (start == false)
            {

                Instantiate(angle3, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(angle2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(angle1, new Vector3(0, 0, 0), Quaternion.identity);
                start = true;
            }

        }*/