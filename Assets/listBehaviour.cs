using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listBehaviour : MonoBehaviour
{
    public List<Entry> entryList = new List<Entry>(0);

    public class Entry
    {
        public string key;
        public int value;

    }
    public void AddToList(string key, int value)
    {
        Entry entry = new Entry();
        entry.key = key;
        entry.value = value;
        entryList.Add(entry);
    }
}

