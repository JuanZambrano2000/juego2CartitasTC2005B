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
    private List<GameObject> _instancias = new List<GameObject>();
    public void CreatePrefab()
    {
      foreach (GameObject instancia in _instancias)
    {
        Destroy(instancia);
    }
    _instancias.Clear();

    for (int i = 0; i < 5; i++)
    {
        int randomIndex = UnityEngine.Random.Range(0, _listaCartas.Count);
        GameObject instancia = Instantiate(_carta);
        CartaLoader cartaLoader = instancia.GetComponent<CartaLoader>();
        cartaLoader._nombre.text = _listaCartas[randomIndex]._nombre;
        cartaLoader._fuerza.text = _listaCartas[randomIndex]._fuerza;
        cartaLoader._spriteRenderer.sprite = _listaCartas[randomIndex]._sprite;
        instancia.transform.position = new Vector3(i * 2f, 1f, 0f);

        _instancias.Add(instancia);
    }

      
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