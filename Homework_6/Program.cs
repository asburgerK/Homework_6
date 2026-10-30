using System;


class Building
{ 
    private static int count = 0;



    private int floors;
    private int id;
    private double tall;
    
    private int apartments;
    
    private int entrances;
    

    public void SetFloors(int floors)
    {
        this.floors = floors;
    }
    public void SetId()
    {
        count++;
        this.id = count;
    }
    public void SetTall(double tall)
    {
        this.tall = tall;
    }
    public void SetApartments(int apartments)
    {
        this.apartments = apartments;
    }
    public void SetEntrances(int entrances)
    {
        this.entrances = entrances;
    }

    double floorTall;
    private void SetFloorTall()
    {
        this.floorTall = this.tall / (double)this.floors;
    }
    int apartmentsInEntrance;

    private void SetApartmentsInEntrance()
    {
        this.apartmentsInEntrance = this.apartments / this.entrances;
    }

    int apartmentsInFloor;
    private void SetApartmentsInFloor()
    {
        this.apartmentsInFloor = this.apartments / (this.entrances * this.floors);
    }


    public int GetFloors() => this.floors;
    public int GetId() => this.id;
    public double GetTall() => this.tall;
    public int GetApartments() => this.apartments;
    public int GetEntrances() => this.entrances;
    public double GetFloorTall() => this.floorTall;
    public int GetApartmentsInEntrance() => this.apartmentsInEntrance;
    public int GetApartmentsInFloor() => this.apartmentsInFloor;
    


    public void ShowInfo()
    {
        Console.WriteLine($"Id: {GetId()}");
        Console.WriteLine($"Floors: {GetFloors()}");
        Console.WriteLine($"Tall: {GetTall()}");
        Console.WriteLine($"Apartments: {GetApartments()}");
        Console.WriteLine($"Entrances: {GetEntrances()}");
        Console.WriteLine($"Floor tall: {GetFloorTall()}");
        Console.WriteLine($"Apartments in entrance: {GetApartmentsInEntrance()}");
        Console.WriteLine($"Apartments in floor: {GetApartmentsInFloor()}");
    }


    public Building(int floors, double tall, int apartments, int entrances)
    {
        SetFloors(floors);
        SetId();
        SetTall(tall);
        SetApartments(apartments);
        SetEntrances(entrances);
        SetFloorTall();
        SetApartmentsInEntrance();
        SetApartmentsInFloor();
    }

}