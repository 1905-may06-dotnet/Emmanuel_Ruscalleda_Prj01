using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;

namespace Data
{
    public sealed class DbInstance
    {
        private DbInstance() // constructor 
        {
        }

        // instance of the class for which I want to use Singleton
        private static DBContext instance = null;

        // Method used to create an instance of PizzaBoxContex (the singleton class)  and return it to the calling method 
        public static DBContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBContext();
                    return instance;
                }
                else
                {
                    return instance;
                }
            } // end of: get
        } // end of: Instance method 
    } // end of: DbInstance class
}
