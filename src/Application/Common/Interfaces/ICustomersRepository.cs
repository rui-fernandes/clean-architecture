﻿namespace CleanArchitecture.Application.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CleanArchitecture.Application.Customers.Queries.GetCustomers;
    using CleanArchitecture.Domain.Entities;

    public interface ICustomersRepository
    {
        Task<Guid> CreateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(Guid id);

        Task<List<Customer>> GetCustomersAsync(GetCustomersQuery query);

        Task<Customer> GetCustomerAsync(Guid id);

        Task UpdateCustomerAsync(Customer customer);
    }
}
