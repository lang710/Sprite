using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTTPRequest : MonoBehaviour
{
    

    class User
    {
        public string username;
        public string password;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test HTTP Request!");
        // Test Get Method.
        StartCoroutine(SendGet("localhost:8007/ping"));

        User body = new User();
        body.username = "lang";
        body.password = "dmrfans";
        // Test Post Method.
        string rbody = JsonUtility.ToJson(body);
        byte[] tbody = System.Text.Encoding.Default.GetBytes(rbody);
        StartCoroutine(SendPost("localhost:8007/api/v1/user/login", tbody));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SendGet(string _url)
    {
        WWW getData = new WWW(_url);
        yield return getData;
        if(getData.error != null)
        {
            Debug.Log("request get error:" + getData.error);
        }
        else
        {
            Debug.Log("request get ok:" + getData.text);
        }
    }

    IEnumerator SendPost(string _url, byte[] _wJson)
    {
        Dictionary<string, string> header = new Dictionary<string, string>();
        header.Add("Content-Type", "application/json");

        WWW postData = new WWW(_url, _wJson, header);

        yield return postData;
        if(postData.error != null)
        {
            Debug.Log("request post error:" + postData.error);
        }
        else
        {
            Debug.Log("request post ok:" + postData.text);
        }
    }
}
