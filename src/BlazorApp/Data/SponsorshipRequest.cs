namespace BlazorApp.Data;
using System.ComponentModel.DataAnnotations;


public class SponsorshipRequest
{
    [Required]
    public string? CompanyName{get; set;}
    [Required]
    public string? ContactName{get; set;}
    [Required]
    [EmailAddress]
    public string? ContactEmail{get; set;}
    [Required]
    [Phone]
    public string? ContactPhone{get; set;}
    [Required]
    public string? MailingAddress{get; set;}
    

    public bool FeildSign {get; set;}
    public bool TeamsJersey {get; set;}
    public bool FieldSignAndTeamJersey {get; set;}

    public bool LargeSign {get; set;}
    public bool SponsorOnePlayer {get; set;}

    public bool OtherMonetaryDonation {get; set;}
    public double DonationAmount {get; set;}

    public PaymentTypeEnum PaymentType {get; set;}

    public SponsorshipRequest() 
    {
        FeildSign = false;
        TeamsJersey = false;
        FieldSignAndTeamJersey = false;
        LargeSign = false;  
        SponsorOnePlayer = false;
        OtherMonetaryDonation = false;
    }

}

public enum PaymentTypeEnum
{
    Venmo,
    Check,
    CreditCard
}   