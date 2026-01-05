class Lasagna
{
    public int expectedOvenTimeInMinutes => 40;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => expectedOvenTimeInMinutes;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutes) => expectedOvenTimeInMinutes - actualMinutes;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayerLasagne) => 2 * numberOfLayerLasagne;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayerLasagne, int numberInMinutesLasagnaInOven) => this.PreparationTimeInMinutes(numberOfLayerLasagne) + numberInMinutesLasagnaInOven;
}
