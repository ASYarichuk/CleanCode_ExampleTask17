public static void GenerateNewObject()
{
    //�������� ������� �� �����
}

public static void CreateNewChance()
{
    _chance = Random.Range(0, 100);
}

public static int AppointSalary(int hoursWorked)
{
    return _hourlyRate * hoursWorked;
}