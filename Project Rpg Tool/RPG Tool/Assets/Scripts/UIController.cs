using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Variables
      [SerializeField]
    private GameObject panel_createTerrain;
    [SerializeField]
    private GameObject panel_paintTerrain;
    [SerializeField]
    private Slider slider_red;
    [SerializeField]
    private Slider slider_green;
    [SerializeField]
    private Slider slider_blue;
    [SerializeField]
    private RawImage rawImage_terrainCollor;
    #endregion

    #region Functions 
    private void Start()
    {
        panel_paintTerrain.SetActive(false);
        panel_createTerrain.SetActive(false);
    }

    /// <summary>
    /// Activate the UI of create terrain
    /// </summary>
    public void activatePanelCreateTerrain()
    {
        if (!panel_createTerrain.active)
        {
            panel_createTerrain.SetActive(true);
        }
        else
        {
            panel_createTerrain.SetActive(false);
        }
        
    }

    /// <summary>
    /// Deactivate the UI of create terrain
    /// </summary>
    public void deactivatePanelCreateTerrain()
    {
        panel_createTerrain.SetActive(false);
    }

    /// <summary>
    /// Activate the UI of paint terrain
    /// </summary>
    public void activatePanelPaintTerrain()
    {
        if(panel_paintTerrain.active == false)
        {
            panel_paintTerrain.SetActive(true);
        }
        else
        {
            panel_paintTerrain.SetActive(false);
        }
        
    }

    /// <summary>
    /// Function to set the RGB color, in specific the red one
    /// </summary>
    public void setColorRed()
    {
        Color color = rawImage_terrainCollor.color;
        color.r = slider_red.value;
        rawImage_terrainCollor.color = color;
        this.GetComponent<TerrainController>().setBrickColor(color);
    }

    /// <summary>
    /// Function to set the RGB color, in specific the green one
    /// </summary>
    public void setColorGreen()
    {
        Color color = rawImage_terrainCollor.color;
        color.g = slider_green.value;
        rawImage_terrainCollor.color = color;
        this.GetComponent<TerrainController>().setBrickColor(color);
    }

    /// <summary>
    /// Function to set the RGB color, in specific the blue one
    /// </summary>
    public void setColorBlue()
    {
        Color color = rawImage_terrainCollor.color;
        color.b = slider_blue.value;
        rawImage_terrainCollor.color = color;
        this.GetComponent<TerrainController>().setBrickColor(color);
    }
    #endregion
}

