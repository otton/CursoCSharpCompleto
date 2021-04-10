using System;

public class Class1
{

    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }

    public Class1()
	{
	}

    public Class1(string nome, string email, DateTime birthdate)
    {
        Nome = nome;
        Email = email;
        BirthDate = birthdate;
    }
}
