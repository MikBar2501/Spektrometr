using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {

    public Object elem1;
    public Object elem2;
    public Object elem3;
    bool start = false;

    void OnGUI()
    {

        if (GUI.Button(new Rect(10, 10, 50, 30), "Reset"))
        {

            Application.LoadLevel("spek");
            Debug.Log("Clicked the button with text");
        }

        if (GUI.Button(new Rect(70, 10, 50, 30), "Start"))
        {
            if (start == false) {
                Instantiate(elem1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(elem2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(elem3, new Vector3(0, 0, 0), Quaternion.identity);
                start = true;
            }
        }

    }
}
