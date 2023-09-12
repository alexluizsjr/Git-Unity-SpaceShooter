using UnityEngine;

public class PlayerTiro : MonoBehaviour {
public GameObject shot; // Neste campo colocaremos o Tiro.
public Transform shotSpaw; //Neste campo o SpawnShoot.
public float tempo_Entre_Tiros; // Valor determina o tempo entre os tiros.
private float proximoTiro; // Variável privada não aparece na Unity
void Update() { //Este tipo de Update é feito antes do FixedUpdate.
if (Time.time > proximoTiro) { //Verifica se já é tempo de dar o próximo tiro.
proximoTiro = Time.time + tempo_Entre_Tiros;// Recebe o valor do tempo
//agora com uma adição de tempo para o próximo tiro.
Instantiate(shot, shotSpaw.position, shotSpaw.rotation);// Instancia shot que // é nosso tiro com a posição do SpawnShoot, e rotação do mesmo, como // nossa rotação é zero o objeto não tem rotação.
}   }   }