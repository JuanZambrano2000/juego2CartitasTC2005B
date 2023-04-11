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
    [SerializeField]
    private GameObject _carta;
    private int randomIndex;
    private GameObject _instancia0;

    public List<CartaSO> _listaCartas = new List<CartaSO>();

    public void CreatePrefab()
    {
      Destroy(_instancia0);
      /*
      List<GameObject> _instanciaCartas = new List<GameObject>(5);
      List<CartaLoader> _cartaLoader
      */    
      int randomIndex = UnityEngine.Random.Range(0, _listaCartas.Count);
      _instancia0 = Instantiate(_carta);
      CartaLoader _cartaLoaderInstancia0 = _instancia0.GetComponent<CartaLoader>();
      _cartaLoaderInstancia0._nombre.text = _listaCartas[randomIndex]._nombre;
      _cartaLoaderInstancia0._fuerza.text = _listaCartas[randomIndex]._fuerza;
      _cartaLoaderInstancia0._spriteRenderer.sprite = _listaCartas[randomIndex]._sprite;
      _instancia0.transform.position = new Vector3(0f, 1f, 0f);

      
    }

    private void OnClick()
    {
      CreatePrefab();
      //Debug.Log(_listaCartas[0]._nombre);
    }
    
    // Start is called before the first frame update
    void Start()
    {
      _listaCartas.Add(_datosBorreguito);
      _listaCartas.Add(_datosCaballito);
      _listaCartas.Add(_datosConejito);
      _listaCartas.Add(_datosFoquita);
      _listaCartas.Add(_datosGatito);
      _listaCartas.Add(_datosHuroncito);
      _listaCartas.Add(_datosOsito);
      _listaCartas.Add(_datosPandita);
      _listaCartas.Add(_datosPerrito);
      _listaCartas.Add(_datosPollito);

      Assert.IsNotNull(_boton, "Falta agregar el boton");  
      Assert.IsNotNull(_carta, "Falta agregar el prefab de la carta");  
      Assert.IsNotNull(_listaCartas, "Falta agregar las cartas a la lista"); 
      _boton.onClick.AddListener(OnClick);
      
    }
    
}