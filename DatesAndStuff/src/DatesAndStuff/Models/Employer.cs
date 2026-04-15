using System;
using System.Collections.Generic;
using System.Linq;

namespace DatesAndStuff.Models;

public class Employer
{

    private readonly string _taxId;

    private readonly string _address;

    private readonly string _ownerName;

    private readonly List<int> _activityDomains;

    public Employer(
        string taxId,
        string address,
        string ownerName,
        List<int> activityDomains)
    {
        this._taxId = taxId;
        this._address = address;
        this._ownerName = ownerName;
        this._activityDomains = activityDomains;
    }

    internal Employer Clone()
    {
        return new Employer(_taxId, _address, _ownerName, new List<int>(_activityDomains));
    }
}