using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZarzadzaniePoziomami : MonoBehaviour
{
    // Update is called once per frame
    public void LadujPoziom(string poziom)
    {
        SceneManager.LoadScene(poziom);
    }
    public void PrzeladujPoziom()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
