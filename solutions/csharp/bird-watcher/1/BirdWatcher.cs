class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsDay = new int[] {0, 2, 5, 3, 7, 8, 4};
        return birdsDay;
    }

    public int Today()
    {
        return this.birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int birdDay in this.birdsPerDay){
            if (birdDay == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int somme = 0;
        for(int i = 0; i< numberOfDays; i++)
            somme += this.birdsPerDay[i];
        return somme;
    }

    public int BusyDays()
    {
        int nbBusyDay = 0;
        foreach(int birdDay in this.birdsPerDay){
            if (birdDay >= 5)
                nbBusyDay ++;
        }
        return nbBusyDay;
    }
}
