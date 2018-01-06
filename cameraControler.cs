using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour {

    public GameObject player; // ເປັນຕົວແທນຂອງບານ
    private Vector3 offset; // ປະກາດຄ່າຄວມຕ່າງລະຫວ່າງຕຳແໜ່ງ 

	void Start () {
        // ຕັ້ງຄ່າໃຫ້ກ້ອງແລ່ນຕາມບານ
        offset = transform.position - player.transform.position; // transform.position ຕຳແໜ່ງທີ່ກ້ອງຢູ່; player.transform.postion ຕຳແໜ່ງທີ່ບານຢູ່
	}

    // LateUpdate ແມ່ນການອັບເດດແບບຊ້າ ຖ້າເປັນການທຳງານຂັ້ນສູດທ່າຍໃຫ້ໃຊນີ້ດີກວ່າ ສ່ວນຫຼາຍກ້ອງມັກໃຊ້ເປັນ LateUpdate
    void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
