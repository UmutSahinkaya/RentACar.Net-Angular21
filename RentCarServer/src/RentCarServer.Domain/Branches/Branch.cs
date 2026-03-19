using RentCarServer.Domain.Abstractions;
using RentCarServer.Domain.Shared;

namespace RentCarServer.Domain.Branches;

public sealed class Branch : Entity
{
    private Branch() { }

    public Branch(Name name, Address adress, Contact contact, bool isActive)
    {
        SetName(name);
        SetAdress(adress);
        SetStatus(isActive);
        SetContact(contact);
    }

    public Name Name { get; private set; } = default!;
    public Address Address { get; set; } = default!;
    public Contact Contact { get; set; } = default!;

    #region Behaviors
    public void SetName(Name name)
    {
        Name = name;
    }
    public void SetAdress(Address adress)
    {
        Address = adress;
    }
    public void SetContact(Contact contact)
    {
        Contact = contact;
    }
    #endregion
}
