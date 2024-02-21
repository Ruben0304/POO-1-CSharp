using POO_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus; 
// Importante importar libreria Bogus para poder trabajar con la clase Faker
// La clase Faker facilia la creacion de datos falsos para incializar datos

namespace POO_1.Factory
{
    public class ProductFaker
    {
        private static int lastId = 0;

        public static Product CreateProduct()
        {
            Faker faker = new Faker();
            string randomName = faker.Random.AlphaNumeric(10);
            float randomPrice = faker.Random.Float(1.00f, 1000f);
            int randomCategory = faker.Random.Int(1,10);

            return new Product(lastId++, randomName, randomPrice, randomCategory);
            
        }
    }
}
