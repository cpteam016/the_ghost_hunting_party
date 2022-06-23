using UnityEngine;
using UnityEngine.UI;

public class GetGameVersion : MonoBehaviour
{
    [SerializeField] private Text textVersion;
    // Start is called before the first frame update
    void Start()
    {
        textVersion.text = "v" + Application.version;
    }
}