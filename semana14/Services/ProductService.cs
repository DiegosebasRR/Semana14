﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace semana14
{
	public class ProductService
	{
		private readonly AppDbContext _context;

		public ProductService() => _context = App.GetContext();

		public bool Create(Product item)
		{ 
			try
			{
				_context.Product.Add(item);
				_context.SaveChanges();
				return true;
		    }
			catch (Exception)
			{
				return false;
		    }
		}

        public bool CreateRange(List<Product> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Product.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> Get()
        {
            return _context.Product.ToList();
        }

        public List<Product> GetByText(string text)
        {
            return _context.Product.Where(x => x.Name.Contains(text)).ToList();
        }

    }
}

