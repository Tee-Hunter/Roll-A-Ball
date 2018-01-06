using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayControl : MonoBehaviour {

    private Rigidbody rb; // Rigidbody ເປັນການສ້າງແຮງໃນການເຄືອນທີ່ທາງດ້ານຟີຊິກ

    private float speed = 50f; // ຕັ້ງຄ່າຄວາມໄວໃຫັກັບວັດຖຸເຮົາ

    private int count; // ເປັນຕົວແປທີ່ໃຊ້ໃນການນັບຄະແນນ

    public Text countText; // ເປັນຕົວແທນກ່ອງຂໍ້ຄວາມຂອງເຮົາ
    public Text winText; // ຕົວແປຄວບຄຸມກ່ອງຄະແນນ

	// Use this for initialization
    // ເປັນຟັງຊັ້ນທີ່ທຳງານເລີ່ມທຳອິດກ່ອນຟັງຊັິນອື່ນ
	void Start () {
        rb = GetComponent<Rigidbody>(); // ຮັບຄ່າຄວາມໄວໄວ້ທີ່ rb ກ່ອນ
        count = 0;
        SetCountText();
        winText.text = "";
	}
	
	// Update is called once per frame
    // ທຳງານຢູ່ຕະຫຼອດເວລາ
	//void Update () { // ເປັນການອັບເດດຕາມຄວາມໄວເຄີ່ອງຂອງຄອມພິວເຕີ້ເຮົາ
    
      void FixedUpdate (){ // ເປັນການອັບເດດຄວາມໄວຕ່າມທີ່ເຮົາກຳໜົດ ຖ້າບໍ່ໄດ້ກຳໜົດໄວ້ ມັນຈະຕັ້ງໄວ້ໃຫ້ 50%
        // ສ້າງຕົວແປທີ່ຈະມາເຮັດໜ້າທີ່ຮັບແຮງເຄື່ອນຍ້າຍເຂົ້າມາເກັບໄວ້ກ່ອນ
        float moveHorizontal = Input.GetAxis("Horizontal"); // moveHorizontal ເປັນຕົວແທນໃຫ້ກັບແກນ x
        float moveVertical = Input.GetAxis("Vertical"); // moveVertical ເປັນຕົວແທນໃຫ້ກັບແກນ z

        // ສ້າງຕົວແປຂື້ນມາເພື່ອໃຊ້ໃນການເຄື່ອນທີ່ ຕາມແກນ X, Y, Z
        // movement ເປັນຕົວທີ່ຈຳແກນ x, y, z ເພື່ອທີ່ຈະສັ້ງທິດທາງໃນການເຄື່ອນທີ່
        Vector3 movement = new Vector3(moveHorizontal, .0f, moveVertical);
        rb.AddForce(movement * speed); // ໃສ່ຄວາມແຮງໃນການເຄື່ອນຍ້າຍເຂົ້າໄປ
	}

    // ຂຽນໂຄດເພື່ອເກັບກ່ອງ
    void OnTriggerEnter(Collider other)  // OnTriggerEnter ເປັນຄຳສັ່ງກວດຈັບການຕຳກັນຂອງວັດຖຸ; Collider ແມ່ນ; other  ເປັນຊື່ຕົວແປທີ່ເຮັດໜ້າທີໃຈການສົ່ງຄ່າແບບ Refereant
    {
        if (other.gameObject.CompareTag("Box"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }

        if (count >= 8)
            winText.text = "You Win";
    }

    // ເປັນຟັງຊັນການສະແດງຄ່າ score ອອກຜ່ານທາງ Text
    void SetCountText()
    {
        countText.text = "Score : " + count.ToString();
    }
}
