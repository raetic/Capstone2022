using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Main : MonoBehaviour
{
    [SerializeField] Image obj;
    float speed=0.5f;
    bool right;
    public void GoDatabaseScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    private void Update()
    {
        obj.rectTransform.position += new Vector3(speed, 0) * Time.deltaTime;
        if (obj.rectTransform.position.x > 1&&!right)
        {
            right = true;
            speed = -0.5f;

        }
        if(obj.rectTransform.position.x <- 1&&right)
        {
            right = false;
            speed = 0.5f;
            
        }
    }
    
}
