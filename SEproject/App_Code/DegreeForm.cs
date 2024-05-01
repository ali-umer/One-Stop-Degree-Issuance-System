using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

public class DegreeForm
{
    private string ID;
    private string name;
    private string batch;
    private int tokenID;
    private string tokenTime;
    private string tokenDate;
    private string FYPapproval;
    private string FYPTime;
    private string FYPdate;
    private string financeApproval;
    private string financeTime;
    private string financeDate;
    private string outstandingDues;
    private string degreeFee;
    private string finalStatus;

    public DegreeForm()
    {
        ID = null;
        name = null;
        batch = null;
        tokenID = 0;
        tokenTime = null;
        tokenDate = null;
        FYPapproval = null;
        FYPTime = null;
        FYPdate = null;
        financeApproval = null;
        financeTime = null;
        financeDate = null;
        outstandingDues = null;
        degreeFee = null;
        finalStatus = null;
    }

    public void SetID(string id)
    {
        ID = id;
    }

    public string GetID()
    {
        return ID;
    }

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }

    public void SetBatch(string b)
    {
        batch = b;
    }

    public string GetBatch()
    {
        return batch;
    }

    public void SetTokenID(int id)
    {
        tokenID = id;
    }

    public int GetTokenID()
    {
        return tokenID;
    }

    public void SetTokenTime(string time)
    {
        tokenTime = time;
    }

    public string GetTokenTime()
    {
        return tokenTime;
    }

    public void SetTokenDate(string date)
    {
        tokenDate = date;
    }

    public string GetTokenDate()
    {
        return tokenDate;
    }

    public void SetFYPApproval(string approval)
    {
        FYPapproval = approval;
    }

    public string GetFYPApproval()
    {
        return FYPapproval;
    }

    public void SetFYPTime(string time)
    {
        FYPTime = time;
    }

    public string GetFYPTime()
    {
        return FYPTime;
    }

    public void SetFYPDate(string date)
    {
        FYPdate = date;
    }

    public string GetFYPDate()
    {
        return FYPdate;
    }

    public void SetFinanceApproval(string approval)
    {
        financeApproval = approval;
    }

    public string GetFinanceApproval()
    {
        return financeApproval;
    }

    public void SetFinanceTime(string time)
    {
        financeTime = time;
    }

    public string GetFinanceTime()
    {
        return financeTime;
    }

    public void SetFinanceDate(string date)
    {
        financeDate = date;
    }

    public string GetFinanceDate()
    {
        return financeDate;
    }

    public void SetOutstandingDues(string dues)
    {
        outstandingDues = dues;
    }

    public string GetOutstandingDues()
    {
        return outstandingDues;
    }

    public void SetDegreeFee(string fee)
    {
        degreeFee = fee;
    }

    public string GetDegreeFee()
    {
        return degreeFee;
    }

    public void SetFinalStatus(string status)
    {
        finalStatus = status;
    }

    public string GetFinalStatus()
    {
        return finalStatus;
    }

   
}
