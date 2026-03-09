using RentCarServer.Domain.Abstractions;
using RentCarServer.Domain.Branchs.ValueObjects;

namespace RentCarServer.Domain.Branches;

public sealed class Branch : Entity
{
    private Branch() { }

    public Branch(Name name, Address adress, bool isActive)
    {
        SetName(name);
        SetAdress(adress);
        SetStatus(isActive);
    }

    public Name Name { get; private set; } = default!;
    public Address Address { get; set; } = default!;
    #region Behaviors
    public void SetName(Name name)
    {
        Name = name;
    }
    public void SetAdress(Address adress)
    {
        Address = adress;
    }
    #endregion
}
