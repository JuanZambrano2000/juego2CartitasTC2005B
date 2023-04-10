using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private Button _boton;
    [SerializeField] 
    private CartaSO[] _cartasSO;

    private List<CartaSO> _listaCartas = new List<CartaSO>();
    
    private void OnClick()
    {
        Debug.Log("El botón fue presionado!");
    }
    
    // Start is called before the first frame update
    void Start()
    {
      Assert.IsNotNull(_boton, "Falta agregar el boton");  
      _boton.onClick.AddListener(OnClick);
      for (int i = 0; i < _cartasSO.Length; i++)
      {
        _listaCartas.Add(_cartasSO[i]);
      }
    }
    
}


/*
    [SerializeField]
    private CartaSO _datosBorreguito;
    [SerializeField]
    private CartaSO _datosCaballito;
    [SerializeField]
    private CartaSO _datosConejito;
    [SerializeField]
    private CartaSO _datosFoquita;
    [SerializeField]
    private CartaSO _datosGatito;
    [SerializeField]
    private CartaSO _datosHuroncito;
    [SerializeField]
    private CartaSO _datosOsito;
    [SerializeField]
    private CartaSO _datosPandita;
    [SerializeField]
    private CartaSO _datosPerrito;
    [SerializeField]
    private CartaSO _datosPollito;
    //List<CartaSO> _listaSO = new List<CartaSO>{_datosBorreguito, _datosCaballito, _datosConejito, _datosFoquita, _datosGatito, _datosHuroncito, _datosOsito, _datosPandita, _datosPerrito, _datosPollito};
    List<CartaSO> _listaSO = new List<CartaSO>;
    _listaSO.add(_datosBorreguito);*/