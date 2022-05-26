using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleUI : MonoBehaviour
{
    private TextMeshProUGUI pr_val;
    private TextMeshProUGUI etco2_val;
    private TextMeshProUGUI bp_label;
    private TextMeshProUGUI mmhg_label_2;
    private TextMeshProUGUI spo2_val;
    private TextMeshProUGUI bp_val_2;
    private TextMeshProUGUI bpm_label;
    private TextMeshProUGUI mmhg_label_1;
    private TextMeshProUGUI pr_label;
    private TextMeshProUGUI etco2_label;
    private TextMeshProUGUI bp_val_1;
    private TextMeshProUGUI percentage_label;
    private TextMeshProUGUI spo2_label;
 

    void Start()
    {
        GameObject ui_color = GameObject.Find("UI_Color");
        pr_val = ui_color.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        pr_label = ui_color.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        bpm_label = ui_color.transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>();

        bp_label = ui_color.transform.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>();
        mmhg_label_1 = ui_color.transform.GetChild(4).gameObject.GetComponent<TextMeshProUGUI>();
        bp_val_1 = ui_color.transform.GetChild(5).gameObject.GetComponent<TextMeshProUGUI>();
        bp_val_2 = ui_color.transform.GetChild(6).gameObject.GetComponent<TextMeshProUGUI>();

        etco2_val = ui_color.transform.GetChild(7).gameObject.GetComponent<TextMeshProUGUI>();
        etco2_label = ui_color.transform.GetChild(8).gameObject.GetComponent<TextMeshProUGUI>();
        mmhg_label_2 = ui_color.transform.GetChild(9).gameObject.GetComponent<TextMeshProUGUI>();

        spo2_val = ui_color.transform.GetChild(10).gameObject.GetComponent<TextMeshProUGUI>();
        percentage_label = ui_color.transform.GetChild(11).gameObject.GetComponent<TextMeshProUGUI>();
        spo2_label = ui_color.transform.GetChild(12).gameObject.GetComponent<TextMeshProUGUI>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            pr_val.color = new Color(0, 255, 0, 255);
            pr_label.color = new Color(0, 255, 0, 255);
            bpm_label.color = new Color(0, 255, 0, 255);
            bp_label.color = new Color(0, 255, 255, 255);
            mmhg_label_1.color = new Color(0, 255, 255, 255);
            bp_val_1.color = new Color(0, 255, 255, 255);
            bp_val_2.color = new Color(0, 255, 255, 255);
            etco2_label.color = new Color(255, 0, 255, 255);
            etco2_val.color = new Color(255, 0, 255, 255);
            mmhg_label_2.color = new Color(255, 0, 255, 255);
            spo2_label.color = new Color(255, 255, 0, 255);
            spo2_val.color = new Color(255, 255, 0, 255);
            percentage_label.color = new Color(255, 255, 0, 255);

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            pr_val.color = new Color(255, 255, 255, 255);
            pr_label.color = new Color(255, 255, 255, 255);
            bpm_label.color = new Color(255, 255, 255, 255);
            bp_label.color = new Color(255, 255, 255, 255);
            mmhg_label_1.color = new Color(255, 255, 255, 255);
            bp_val_1.color = new Color(255, 255, 255, 255);
            bp_val_2.color = new Color(255, 255, 255, 255);
            etco2_label.color = new Color(255, 255, 255, 255);
            etco2_val.color = new Color(255, 255, 255, 255);
            mmhg_label_2.color = new Color(255, 255, 255, 255);
            spo2_label.color = new Color(255, 255, 255, 255);
            spo2_val.color = new Color(255, 255, 255, 255);
            percentage_label.color = new Color(255, 255, 255, 255);

        }
    }
}