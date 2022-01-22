using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using HuntShowdownAPI.Interfaces.Repositories;
using HuntShowdownAPI.Models;
using HuntShowdownAPI.Services;
using Moq;
using Xunit;

namespace HuntShowdownAPI.UnitTests.Services;

public class WeaponsServiceTests
{
    private readonly WeaponsService _sut;
    private readonly Mock<IWeaponsRepository> _weaponsRepoMock = new Mock<IWeaponsRepository>();
    
    public WeaponsServiceTests()
    {
        _sut = new WeaponsService(_weaponsRepoMock.Object);
    }

    private static Weapon GetFirstWeapon()
    {
        return new Weapon
        {
            Slug = "Caldwell_Conversion_Uppercut",
            Name = "Caldwell Conversion Uppercut",
            Cost = "275$",
            UnlockCondition = "Earn 3000XP with any Caldwell Conversion Pistol variant",
            Ammunition = "Long",
            Capacity = "6/9",
            Damage = 130,
            RateOfFire = "40rpm",
            ReloadSpeed = "15s",
            MeleeDamage = 31,
            EffectiveRange = "96m",
            Handling = "57%",
            MuzzleVelocity = "410m/s",
            HeavyMeleeDamage = 31
        };
    }
    
    private static Weapon GetSecondWeapon()
    {
        return new Weapon
        {
            Slug = "test_weapon",
            Name = "Test Weapon",
            Cost = "0$",
            UnlockCondition = "None",
            Ammunition = "Long",
            Capacity = "0",
            Damage = 0,
            RateOfFire = "0rpm",
            ReloadSpeed = "0s",
            MeleeDamage = 0,
            EffectiveRange = "0m",
            Handling = "0%",
            MuzzleVelocity = "0m/s",
            HeavyMeleeDamage = 0
        };
    }
    
    public static TheoryData<List<Weapon>> GetAllWeaponsData()
    {
        return new TheoryData<List<Weapon>>
        {
            new List<Weapon> {GetFirstWeapon(), GetSecondWeapon()}
        };
    }
    
    public static TheoryData<List<Weapon>> GetSearchedWeaponData()
    {
        return new TheoryData<List<Weapon>>
        {
            new List<Weapon> {GetFirstWeapon()}
        };
    }
    
    public static TheoryData<Weapon> GetBySlugData()
    {
        return new TheoryData<Weapon>
        {
            GetFirstWeapon()
        };
    }
    
    [Theory]
    [MemberData(nameof(GetAllWeaponsData), MemberType = typeof(WeaponsServiceTests))]
    public async Task GetAll_ShouldReturnWeapons_WhenSearchDoesNotExists(List<Weapon> weaponsMock)
    {
        // Arrange
        _weaponsRepoMock.Setup(x => x.GetAll()).ReturnsAsync(weaponsMock);
        
        // Act
        var weapons = await _sut.GetAll(null);

        // Assert
        weapons.Should().BeEquivalentTo(weaponsMock);
    }
    
    [Theory]
    [MemberData(nameof(GetSearchedWeaponData), MemberType = typeof(WeaponsServiceTests))]
    public async Task GetAll_ShouldReturnWeaponsAccordingToSearch_WhenSearchExists(List<Weapon> listOfWeapons)
    {
        // Arrange
        const string search = "uppercut";
        _weaponsRepoMock.Setup(x => x.SearchByName(search)).ReturnsAsync(listOfWeapons);
        
        // Act
        var weapons = await _sut.GetAll(search);
    
        // Assert
        weapons.Should().BeEquivalentTo(listOfWeapons);
    }
    
    [Theory]
    [MemberData(nameof(GetBySlugData), MemberType = typeof(WeaponsServiceTests))]
    public async Task GetBySlug_ShouldReturnWeapon_WhenSlugIsValid(Weapon weaponMock)
    {
        // Arrange
        const string slug = "Caldwell_Conversion_Uppercut";
        _weaponsRepoMock.Setup(x => x.GetBySlug(slug)).ReturnsAsync(weaponMock);
        
        // Act
        var weapon = await _sut.GetBySlug(slug);
    
        // Assert
        weapon.Should().BeEquivalentTo(weaponMock);
        weapon?.Slug.Should().Be(slug);
    }
}