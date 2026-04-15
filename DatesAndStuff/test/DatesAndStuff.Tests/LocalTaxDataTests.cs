using DatesAndStuff.Models;
using FluentAssertions;

namespace DatesAndStuff.Tests;

public class LocalTaxDataTests
{
    [Test]
    public void Constructor_SetsUAT()
    {
        var sut = new LocalTaxData("valami");

        sut.UAT.Should().Be("valami");
    }

    [Test]
    public void YearlyTax_ReturnsZero()
    {
        var sut = new LocalTaxData("valami");

        sut.YearlyTax.Should().Be(0);
    }

    [Test]
    public void DiscountPercentage_CanBeSetAndRead()
    {
        var sut = new LocalTaxData("valami");

        sut.DiscountPercentage = 10.5;

        sut.DiscountPercentage.Should().Be(10.5);
    }

    [Test]
    public void TaxItems_CanBeSetAndRead()
    {
        var sut = new LocalTaxData("valami");
        var items = new List<TaxItem>
        {
            new TaxItem { ReferenceNumber = "REF001", BaseTax = 100.0 }
        };

        sut.TaxItems = items;

        sut.TaxItems.Should().BeEquivalentTo(items);
    }
}