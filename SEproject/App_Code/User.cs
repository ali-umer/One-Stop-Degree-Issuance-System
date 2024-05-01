using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
public class User
{
    protected string ID;
    protected string password;
    protected string role;
    protected string name;
    protected string DOB;
    protected string bloodGroup;
    protected string gender;
    protected string CNIC;
    protected string nationality;
    protected string email;
    protected string contact;
    protected string campus;

    public User()
    {
        this.ID = null;
        this.password = null;
        this.role = null;
        this.name = null;
        this.DOB = null;
        this.bloodGroup = null;
        this.gender = null;
        this.CNIC = null;
        this.nationality = null;
        this.email = null;
        this.contact = null;
        this.campus = null;
    }

    public void setID(string ID)
    {
        this.ID = ID;
    }

    public string getID()
    {
        return this.ID;
    }

    public void setPassword(string password)
    {
        this.password = password;
    }

    public string getPassword()
    {
        return this.password;
    }

    public void setRole(string role)
    {
        this.role = role;
    }

    public string getRole()
    {
        return this.role;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }

    public void setDOB(string DOB)
    {
        this.DOB = DOB;
    }

    public string getDOB()
    {
        return this.DOB;
    }

    public void setBloodGroup(string bloodGroup)
    {
        this.bloodGroup = bloodGroup;
    }

    public string getBloodGroup()
    {
        return this.bloodGroup;
    }

    public void setGender(string gender)
    {
        this.gender = gender;
    }

    public string getGender()
    {
        return this.gender;
    }

    public void setCNIC(string CNIC)
    {
        this.CNIC = CNIC;
    }

    public string getCNIC()
    {
        return this.CNIC;
    }

    public void setNationality(string nationality)
    {
        this.nationality = nationality;
    }

    public string getNationality()
    {
        return this.nationality;
    }

    public void setEmail(string email)
    {
        this.email = email;
    }

    public string getEmail()
    {
        return this.email;
    }

    public void setContact(string contact)
    {
        this.contact = contact;
    }

    public string getContact()
    {
        return this.contact;
    }

    public void setCampus(string campus)
    {
        this.campus = campus;
    }

    public string getCampus()
    {
        return this.campus;
    }
}
