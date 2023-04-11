using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CartaLoader : MonoBehaviour
{
    [SerializeField]
    public CartaSO _datos;
    [SerializeField]
    public TMP_Text _nombre;
    [SerializeField]
    public TMP_Text _fuerza;
    [SerializeField]
    public SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _nombre.text = _datos._nombre;
        _fuerza.text = _datos._fuerza;
        _spriteRenderer.sprite = _datos._sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
