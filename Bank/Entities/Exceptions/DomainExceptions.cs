﻿using System;


namespace Bank.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }

    }

}

