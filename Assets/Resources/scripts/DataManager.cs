using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DataManager : MonoBehaviour
{
    int curNo=-1;
    [SerializeField] GameObject dataView;
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hit = Physics2D.GetRayIntersectionAll(ray, Mathf.Infinity);
            foreach(var obj in hit)
            if (obj.collider != null && obj.collider.tag=="obj")
            {
                 Debug.Log(obj.collider);
                OpenDataView(obj.collider.GetComponent<Obj>().GetNo());
            }
        }

    }
    public void GoMainScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ClickScrollView()
    {
        OpenDataView(curNo);
    }
    public void OpenDataView(int no)
    {
        Debug.Log(no);
        dataView.SetActive(true);
    }
}
