﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //kod yükünü azaltmak için repositorleri  generic yapı yapıyoruz 
    class CategoryRepository : ICategoryDal
    {
        //cagırmamız gereken sınıflar 
        Context p = new Context();
        DbSet<Category> _object;
        public void Delete(Category c)
        {
            _object.Remove(c);
            p.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            p.SaveChanges();

        }

        public List<Category> List()
        {
            return _object.ToList();


        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();    //şartlı listeleme 
        }

        public void Update(Category c)
        {
            p.SaveChanges();  //direk işlemleri kaydet
        }

    }
   
 }
