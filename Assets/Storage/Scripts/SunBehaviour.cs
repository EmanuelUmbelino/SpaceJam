using UnityEngine;
using System.Collections;

public class SunBehaviour : MonoBehaviour {

    public float durationInSeconds;
    public bool clockwise;
    private float angle;
    void Start()
    {
        // calcula quantos graus deve andar por segundo
        angle = 360 / durationInSeconds;
        // verifica se é sentido horário
        if (clockwise) angle *= -1;
    }
	void FixedUpdate () 
    {
        // rotaciona a quantidade de graus em função do tempo
        float rotation = Time.deltaTime * angle;
        transform.Rotate(new Vector3(0,0,rotation));
	}
}
