using System.Text.Json.Serialization;

namespace HuntShowdownAPI.Models;

public class Weapon
{
    [JsonIgnore]
    public int Id { get; set; }
    
    public string Slug { get; set; }
    
    public string Name { get; set; }
    
    public string Cost { get; set; }
    
    public string UnlockCondition { get; set; }
    
    public string Ammunition { get; set; }
    
    public string Capacity { get; set; }
    
    public int Damage { get; set; }
    
    public string RateOfFire { get; set; }
    
    public string ReloadSpeed { get; set; }
    
    public int MeleeDamage { get; set; }
    
    public string EffectiveRange { get; set; }
    
    public string Handling { get; set; }
    
    public string MuzzleVelocity { get; set; }
    
    public int HeavyMeleeDamage { get; set; }
}