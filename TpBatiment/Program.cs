using TpBatiment;

#region Create building
Building Building1 = new Building();
Building Building2 = new Building("13 Avenue du tourniquet");
#endregion
#region Create house
House House1 = new House();
House House2 = new House("4 Avenue de Verdun", 5);
#endregion
#region Method
Building1.ToString();
Console.WriteLine("******************");
Building2.ToString();
Console.WriteLine("******************");
House1.ToString();
Console.WriteLine("******************");
House2.ToString(); 
#endregion