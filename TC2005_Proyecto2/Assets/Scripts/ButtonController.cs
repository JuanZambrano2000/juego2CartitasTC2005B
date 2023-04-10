using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private Button _boton;
    //_boton.onClick.AddListener(OnClick);

    private void OnClick()
    {
        Debug.Log("El botón fue presionado!");
    }
    
    // Start is called before the first frame update
    void Start()
    {
      Assert.IsNotNull(_boton, "Falta agregar el boton");  
      _boton.onClick.AddListener(OnClick);
    }
}
