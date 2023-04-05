// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Photon.Pun;
// using Photon.Realtime;

// namespace Photon.Pun.Demo.Basics {
// public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
// {
//     private GameObject spawnedPlayerPrefab;
//     public GameObject patientPrefab;
//     public GameObject caretakerPrefab;

//     void Start() {
//         // Instantiate(myPrefab, new Vector3(0, 1, 0), Quaternion.identity);
//         // PhotonNetwork.Instantiate(myPrefab, new Vector3(0, 1, 0), Quaternion.identity);

//     }

//     public override void OnJoinedRoom() {
//         base.OnJoinedRoom();
//         if(PhotonNetwork.IsMasterClient) {
//             Debug.Log("Im the master client!");
//             PhotonNetwork.Instantiate(this.caretakerPrefab.name, new Vector3(0, 1, 0),Quaternion.identity);

//         } else {
//             Debug.Log("Im the other client");
//             PhotonNetwork.Instantiate(this.patientPrefab.name, new Vector3(0, 0, 0),Quaternion.identity);

//         }
//         // spawnedPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
//     }
//     public override void OnLeftRoom() {
//         base.OnLeftRoom();
//         PhotonNetwork.Destroy(spawnedPlayerPrefab);
//     }
// }
// }
