namespace WowSpellidManager.DomainUWP.Models.Spells
{
    /// <summary>
    /// Determines in which way the spell is cast. <br></br>
    /// A cast can be either instant, channeled or a standard cast.
    /// </summary>
    public enum CastType
    {
        Instant = 0,
        Channeling = 1,
        Cast = 2,
    }
}
