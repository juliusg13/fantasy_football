using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class max_games_chosen_dialog : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    [MenuItem("Example/Place Selection On Surface")]
    static void CreateWizard() {
        Transform[] transforms = Selection.GetTransforms(SelectionMode.Deep |
                SelectionMode.ExcludePrefab | SelectionMode.Editable);

        if (transforms.Length > 0 &&
            EditorUtility.DisplayDialog("Max 7 games.",
                "You can only bet on 7 games.", "Ok")) {
            foreach (Transform transform in transforms) {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, -Vector3.up, out hit)) {
                    transform.position = hit.point;
                    Vector3 randomized = Random.onUnitSphere;
                    randomized = new Vector3(randomized.x, 0F, randomized.z);
                    transform.rotation = Quaternion.LookRotation(randomized, hit.normal);
                }
            }
        }
    }
}
