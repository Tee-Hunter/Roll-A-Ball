using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
        transform.Rotate(new Vector3(90, 180, -90) * Time.deltaTime); // transform ເປັນຄຳສັ່ງໃຫ້ເກີດມີການປ່ຽນແປງ ຫຼື ການເຄື່ອນທີ່; Rotate ແມ່ນການໝູນອ້ອມ; transform.Rotate ແມ່ນການເຄື່ອນທີ່ໝູນອ້ອມຕົວເອງ
                                                                      // Time.deltaTime ຕໍ່ວິນາທີ ຕົວຢ່າງເຮົາ ໝູນແກນ x, y, z ໄປ 90, 180, -90 ອົງສາຕໍ່ວິນາທີ                                                          
	}
}
