using TMPro;
using UnityEngine;

public class demo1 : MonoBehaviour
{
    public TextMeshProUGUI textbox;
    
    public void OnClick()
    {
        textbox.text = "i have changed";
    }


}
