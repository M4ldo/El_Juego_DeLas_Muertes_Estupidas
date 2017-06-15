using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_de_controles : MonoBehaviour {
    string Algo = "";
    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width/2 - 50,Screen.height/2 - 25,100,50),"Soy un boton"))
        {
            Algo = "Has Apretado el boton hurra";
        }
        GUI.Label(new Rect(10, 10, 200, 25), Algo);
    }


    void Update()
    {
        int fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                fingerCount++;

        }
        if (Input.touchCount > 0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Has tocado la pantalla");
            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Debug.Log("Has tocado movido el dedo");
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                Debug.Log("Has sacado el dedo de la pantalla");
            }

            //Debug.Log(Input.GetTouch(0).position);//Te dice la posicion del primer dedo que toque la pantalla
        }
        if (fingerCount > 0)
            print("User has " + fingerCount + " finger(s) touching the screen");

    }
}
