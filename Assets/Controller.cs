using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Transform camOrigin;
    public List<Transform> sets; 
    public List<Dropdown> dropdowns = new List<Dropdown>();
    

    public void QuitGame() {
        Application.Quit();
    }

    public void UpdateScene() {
        var i = 0;
        foreach(Dropdown d in dropdowns) {
            for (var j = 0; j < sets.Count; j++) {
                if (d.value == j) sets[j].GetChild(i).gameObject.SetActive(true);
                else sets[j].GetChild(i).gameObject.SetActive(false);
            }
            i++;
        }
    }

    private void Update() {

        //inputs
       // if (Input.GetMouseButton(0)) {
                       
        //    camOrigin.Rotate(-Input.GetAxis("Mouse Y") * 1.1f, -Input.GetAxis("Mouse X") * 1.1f, 0,Space.World);
       //     camOrigin.eulerAngles = new Vector3(camOrigin.eulerAngles.x, camOrigin.eulerAngles.y, 0);
       // }
       // if (Input.GetMouseButton(1)) {
        //    Camera.main.fieldOfView += -Input.GetAxis("Mouse Y");
       // }

        
    }

    


}
