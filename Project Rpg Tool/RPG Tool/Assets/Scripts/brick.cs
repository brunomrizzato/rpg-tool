using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{

    #region Variables
    private int int_cost;
    private bool bool_isWater;
    private bool bool_isClimbable; 
    private Color color_brickColor;

    #endregion


    #region Function
    private void Start()
    {
        color_brickColor = this.gameObject.GetComponent<Renderer>().sharedMaterial.color;
    }

    // Update is called once per frame

    void OnClick()
    {
        //TO DO
    }
    #endregion
}
