using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class master : MonoBehaviour
{
    public Button btn;
    public string sce;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        SceneManager.LoadScene(sce);
    }
}
