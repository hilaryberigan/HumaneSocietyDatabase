
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Adopter
{
    string name;
    bool hasPaid;
    decimal moneyOwed;
   
    public Adopter()
    {
        
    }
    public string Name
	{
		get { return name; }
 		set { name = value; }
	}
	public bool HasPaid
	{
        get { return hasPaid; }
    }
    public decimal MoneyOwed
    {
        get { return moneyOwed; }
        set { moneyOwed = value;
            if (value == 0)
            {
                hasPaid = true;
            }
        }
    }

	public void AdoptAnimal()
	{

		
	}
    public void PayForAnimal()
    {

    }

	

}

