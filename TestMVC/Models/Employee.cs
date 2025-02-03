using System;
using System.Collections.Generic;

namespace TestMVC.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeeAddress { get; set; } = null!;

    public string EmployeePhone { get; set; } = null!;

    public string EmployeeEmail { get; set; } = null!;

    public decimal EmployeeSalary { get; set; }

    public DateOnly DateofJoining { get; set; }
}
