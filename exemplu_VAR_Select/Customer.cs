using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer {
    public string Name;
    public string Phone;
    public string City;

    public Customer(string n, string p, string c)
    {
        Name = string.Copy(n);
        Phone = string.Copy(p);
        City = string.Copy(c);
    }
}
