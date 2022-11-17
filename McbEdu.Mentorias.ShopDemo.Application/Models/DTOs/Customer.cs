﻿namespace McbEdu.Mentorias.ShopDemo.Domain.Models.DTOs;

public class Customer
{
    public Guid Identifier { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public DateOnly Birthday { get; set; }

    public Customer()
    {
        Name = Surname = Email = string.Empty;
    }
}
