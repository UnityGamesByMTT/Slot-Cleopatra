using System.Collections.Generic;
using UnityEngine;

public class PayoutCalculation : MonoBehaviour
{
    [SerializeField] private List<GameObject> LineObjetcs;
    internal List<int> DontDestroyLines = new List<int>();


    //generate lines at runtime accordingly
    internal void GeneratePayoutLinesBackend(int index = -1, bool DestroyFirst = true)
    {
        if (DestroyFirst)
            ResetStaticLine();

        if (index >= 0)
        {
            LineObjetcs[index].SetActive(true);
            return;
        }
        DontDestroyLines.Clear();
        for (int i = 0; i < 9; i++)
        {
            LineObjetcs[i].SetActive(true);
        }
    }

    //delete the line generated by button hover
    internal void ResetStaticLine()
    {
        for (int i = 0; i < LineObjetcs.Count; i++)
        {
            if (DontDestroyLines.Contains(i))
                continue;
            else
                LineObjetcs[i].SetActive(false);
        }
    }
}
