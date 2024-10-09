using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowQuestInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text questInfo;

    public void AddQuestInfo(string info)
    {
        questInfo.text += $"{info}{System.Environment.NewLine}";
    }
}
