using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//agregar una variable que establezca la cantidad de
//veces que se instanciara un alimento
//cuando se instancien esa alimentos 
//no debe instancierse mas
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement RNG;
    public int MaxClones;
    public int cloneCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if (cloneCount < MaxClones)
        {
            cloneCount++;
            RNG.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
    }
}
