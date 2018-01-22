using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrainController : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private GameObject gobj_terrain;
    [SerializeField]
    private InputField input_length;
    [SerializeField]
    private InputField input_width;
    private Color color_brickColor;
    private List<GameObject> terrains = new List<GameObject>();
    #endregion

    #region Functions



    private void Start()
    {
        color_brickColor = Color.white;
    }

    public void getParameters()
    {
        int x = int.Parse(input_length.text);
        int y = int.Parse(input_width.text);
        setCanvasSize(x, y);
    }

    /// <summary>
    /// This function set the terrain size,also called canvas
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    private void setCanvasSize(int x, int y)
    {
        if (terrains.Count == 0)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    GameObject auxBrick = gobj_terrain;
                    auxBrick.GetComponent<Renderer>().sharedMaterial.color = color_brickColor;
                    terrains.Add(Instantiate(auxBrick, new Vector3(i, 0, j), Quaternion.identity));
                    GetComponent<UIController>().deactivatePanelCreateTerrain();
                }
            }
        }
    }

    /// <summary>
    /// Delete the terrain and clear the list Terrains.
    /// </summary>
    public void deleteCanvas()
    {
        if(terrains.Count > 0)
        {
            foreach (GameObject terrain in terrains)
            {
                Destroy(terrain);
            }
        }
        terrains.Clear();
    }

    /// <summary>
    /// Set the color of the brick
    /// </summary>
    /// <param name="color"> the color of the brick</param>
    public void setBrickColor(Color color)
    {
        color_brickColor = color;
    }

    /// <summary>
    /// Add a brick into the list terrains
    /// </summary>
    /// <param name="brick"></param>
    public void addBrick(GameObject brick)
    {
        terrains.Add(brick);
    }
    #endregion
}
