using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerGUI
{
    class BusinessLogic
    {
        private DataAccess connectData;
        public BusinessLogic(string connectionString)
        {
            connectData = new DataAccess(connectionString);
        }

        public DatabaseObjectModel getCustInfoFromDatabase()
        {
            var model = new DatabaseObjectModel();
            model.countOfRecords = connectData.numOfCust();
            model.listOfRecords = connectData.listOfCust();
            return model;
        }

        public DatabaseObjectModel getEmpInfoFromDatabase()
        {
            var model = new DatabaseObjectModel();
            model.countOfRecords = connectData.numOfEmp();
            model.listOfRecords = connectData.listOfEmp();
            return model;
        }

        public DatabaseObjectModel getOrderInfoFromDatabase()
        {
            var model = new DatabaseObjectModel();
            model.countOfRecords = connectData.numOfOrders();
            model.listOfRecords = connectData.listOfOrders();
            return model;
        }

        public bool getCustomerAccess()
        {
            return connectData.accessToCust();
        }

        public bool getOrdersAccess()
        {
            return connectData.accessToOrders();
        }

        public bool getEmpAccess()
        {
            return connectData.accessToEmp();
        }

        public bool getLoginAccess()
        {
            return connectData.accessLogin();
        }
    }
}
