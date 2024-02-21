using Bogus;
using POO_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1.Factory
{
    public class CategoryFaker
    {
        private static int lastId = 0;

        public static Category CreateCategory()
        {
            Faker faker = new Faker();
            string randomName = faker.Random.AlphaNumeric(10);

            return new Category(lastId++, randomName);

        }
    }
}
