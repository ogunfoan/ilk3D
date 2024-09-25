using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMarker : MonoBehaviour
{
    private void OnDrawGizmos() //Unity editörde gizmoz çizmemizi sağlıyor
    {
        RaycastHit hit; // gameobjemizden hiza almak için kullanıcaz
        if (Physics.Raycast(transform.position, -Vector3.up, out hit)) // gameobjemizin pozisyonunu alıcak, aşağı doğrru bir ok çizecek ve sonra neye temas ettiğini görücez
        {
            Debug.DrawLine(transform.position,hit.point, Color.magenta); //  hizayı nerden çekeceğini gösterdik, renk seçtik
            Gizmos.color = Color.blue; // çevreleyeceği alanın rengini seçtik
            Gizmos.DrawWireSphere(hit.point,2.5f); // çevrelediği şekli ve yarı çapını belirttik
        }
    }
}
