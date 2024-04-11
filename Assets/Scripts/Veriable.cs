using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veriable : MonoBehaviour
{
    //структура переменных
    // 1. Модификатор доступа(private, public)
    // 2. Тип данных
    // 3. Имя

    public int countCar = 3;
    private int speedCar = 90;
    public float power = 3.6F;
    public bool gameOver = true;
    public string nameCar = "BMW";
    public GameObject car;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
