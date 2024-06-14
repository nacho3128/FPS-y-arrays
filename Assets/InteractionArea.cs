using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    // Detectar cuando el area entra en contacto con un alimento
    // si lo hace destruye el alimento
    //y suma una variable el valor del item
    // y mistrar el valor de esa variable en el txtScore de la escena
    //Detectar cuando el area entra en contacto con un alimento
    //cuando se llegue al valor maximo de be dejar de sumarse puntos
    //y mostrar en txtScore en lugar del puntaje le mensaje "Ganaste!"

    public Text txtScore;
    public int score;
    public int MaxScore;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        if(score > MaxScore)
        {
        txtScore.text = score.ToString();
        Destroy(collision.gameObject); 
        }
        else
        {
            txtScore.text = "Ganaste!";
        }
       
        
    }
}