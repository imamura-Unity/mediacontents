using UnityEngine;
using UnityEngine.UI;

public class HPText : MonoBehaviour
{
    // UI Text�w��p
    public Text TextFrame;
    // �\������ϐ�
   

    // Use this for initialization
    void Start()
    {
        TextFrame.text = string.Format(GlobalVariables.HP, "HP");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}