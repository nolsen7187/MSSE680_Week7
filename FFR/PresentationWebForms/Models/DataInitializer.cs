using System.Collections.Generic;
using System.Data.Entity;
using PresentationWebForms;


namespace PresentationWebForms.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            GetCustomers().ForEach(c => context.Customers.Add(c));
            GetEmployees().ForEach(e => context.Employees.Add(e));
            GetItems().ForEach(i => context.Items.Add(i));
            GetItemCategories().ForEach(ic => context.ItemCategories.Add(ic));
            GetSalesHeader().ForEach(sh => context.SalesHeaders.Add(sh));
            GetSalesItems().ForEach(si => context.SalesItems.Add(si));
            GetWebUsers().ForEach(w => context.WebUsers.Add(w));

        }
        private static List<Customer> GetCustomers()
        {
            var customers = new List<Customer> {
                new Customer
                {
                    CustomerId = 15,
                    FirstName = "Master",
                    LastName = "Yoda",
                    City = "Hoth",
                    State = "CO",
                    Zip = "80012",
                    Street = "1234 Wookie Way",
                    Address = "1234 Wookie Way, Hoth CO 80012",
                    Phone = "3031234567",
                    Email = "Masteryoda@jedi.com"
                },
                new Customer
                {
                    CustomerId = 16,
                    FirstName = "Master",
                    LastName = "Yoda",
                    City = "Hoth",
                    State = "CO",
                    Zip = "80012",
                    Street = "1234 Wookie Way",
                    Address = "1234 Wookie Way, Hoth CO 80012",
                    Phone = "3031234567",
                    Email = "Masteryoda@jedi.com"
                }
                
            };

            return customers;
        }
        private static List<Employee> GetEmployees()
        {
            var employees = new List<Employee> {
                new Employee
                {
                    EmployeeId = 15,
                    EmployeeFirstName = "Bruce",
                    EmployeeLastName = "Olsen",
                    EmployeePhone = "3031234567",
                    Employeetype = "Worker"
                },
                new Employee
                {
                    EmployeeId = 16,
                    EmployeeFirstName = "Maurice",
                    EmployeeLastName = "Olsen",
                    EmployeePhone = "3031234567",
                    Employeetype = "Manager"
                }
                
            };

            return employees;
        }
        private static List<ItemCategory> GetItemCategories()
        {
            var itemCategoies = new List<ItemCategory> {
                new ItemCategory
                {
                ItemCategoryId = 1,
                Category = "Engine",
                Description = "Engine Performance Modification"
                },
                new ItemCategory
                {
                ItemCategoryId = 2,
                Category = "Exhaust",
                Description = "Exhaust Performance Modification"
                },
                new ItemCategory
                {
                ItemCategoryId = 3,
                Category = "Suspension",
                Description = "Suspension Performance Modification"
                }                
            };

            return itemCategoies;
        }
        private static List<Item> GetItems()
        {


            var items = new List<Item> {
                new Item
                {
                    ItemId = 1,
                    ItemName = "FP Green",
                    Price = 900,
                    QuantityAvailable = 10,
                    ItemCategoryId =  1
                },
                new Item
                {
                    ItemId =2,
                    ItemName = "FP Red",
                    Price = 1200,
                    QuantityAvailable = 10,
                    ItemCategoryId =  1
                },
                new Item
                {
                    ItemId =3,
                    ItemName = "Borla Catback Exhaust",
                    Price = 500,
                    QuantityAvailable = 10,
                    ItemCategoryId =  2
                },      
                new Item
                {
                    ItemId =4,
                    ItemName = "Magnaflow Catback Exhaust",
                    Price = 600,
                    QuantityAvailable = 10,
                    ItemCategoryId =  2
                },       
                new Item
                {
                    ItemId = 5,
                    ItemName = "UR Front Sway Bar",
                    Price = 200,
                    QuantityAvailable = 10,
                    ItemCategoryId =  3
                },      
                new Item
                {
                    ItemId = 6,
                    ItemName = "UR Rear Sway Bar",
                    Price = 200,
                    QuantityAvailable = 10,
                    ItemCategoryId =  3
                },          
            };

            return items;
        }
        private static List<SalesHeader> GetSalesHeader()
        {
            var salesHeaders = new List<SalesHeader> {
                new SalesHeader
                {
                    SalesId = 1,
                    CustomerId = 15,
                    OrderSalesBalance = 1400,
                    OrderTaxAmount = 100,
                    OrderTotal = 1500
                },
                
            };

            return salesHeaders;
        }
        private static List<SalesItem> GetSalesItems()
        {
            var salesItems = new List<SalesItem> {
                new SalesItem
                {
                    SalesItemTransId = 1,
                    SalesId = 1,
                    ItemId = 2,
                    Qty = 1,
                    Price = 1200
                   
                },
                new SalesItem
                {
                    SalesItemTransId = 2,
                    SalesId = 1,
                    ItemId = 6,
                    Qty = 1,
                    Price = 200
                }
                
            };

            return salesItems;
        }
        private static List<WebUserTable> GetWebUsers()
        {
            var webUsers = new List<WebUserTable> {
                new WebUserTable
                {
                    UserId = 0,
                    UserName = "yoda",
                    Password = "Pass@word1",
                    CustomerId = 15
                   
                },
                new WebUserTable
                {
                    UserId = 0,
                    UserName = "bolsen",
                    Password = "Pass@word1",
                    EmployeeId = 15
                }
                
            };

            return webUsers;
        }
    }
}