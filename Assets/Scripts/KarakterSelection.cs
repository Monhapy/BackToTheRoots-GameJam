using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterSelection : MonoBehaviour
{
    

    public void T�rk()
    {
        SceneManager.LoadScene(2);
    }
    public void Roma()
    {
        SceneManager.LoadScene(3);
    }
    public void �skandinav()
    {
        SceneManager.LoadScene(4);
    }



}
