using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Obj : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] texts;
    private int no;
    public void SetObj(int no,string[] infos)
    {
        this.no = no;
    }
    public int GetNo()
    {
        return no;
    }
}
