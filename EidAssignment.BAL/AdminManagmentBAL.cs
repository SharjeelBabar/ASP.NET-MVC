using EidAssignment.DAL;
using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EidAssignment.BAL
{
    public class AdminManagmentBAL
    {
        //public List<Product> GetProducts()
        //{
        //   return new AdminManagmentDAL().GetProducts();
        //}
        //Role
        public List<Role> GetRoles()
        {
            return new AdminManagmentDAL().GetRoles();
        }
       
        public void AddRole(Role role)
        {
            new AdminManagmentDAL().AddRole(role);
        }
        public void DelRole(int Id)
        {
            new AdminManagmentDAL().DelRole(Id);
        }
        public Role GetRole(int Id)
        {
            return new AdminManagmentDAL().GetRole(Id);
        }
        public void EditRole(Role role)
        {
            new AdminManagmentDAL().EditRole(role);
        }
        //User
        public List<User> GetUsers()
        {
            return new AdminManagmentDAL().GetUsers();
        }
        public void AddUsers(User user)
        {
            user.JoinedOn = DateTime.UtcNow.AddHours(5);
            new AdminManagmentDAL().AddUser(user);
        }
        public User GetUser(int Id)
        {
            return new AdminManagmentDAL().GetUser(Id);
        }
        public void DelUser(int Id)    
        {
            new AdminManagmentDAL().DelUser(Id);
        }
        public void EditUser(User user)
        {
            new AdminManagmentDAL().EditUser(user);
        }
        //Products
        public List<Product> GetProducts()
        {
            return new AdminManagmentDAL().GetProducts();

        }
        public void AddProduct(Product product)
        {
            product.CreatedAt = DateTime.UtcNow.AddHours(5);
            new AdminManagmentDAL().AddProducts(product);
        }
        public Product GetProduct(int Id)
        {
            return new AdminManagmentDAL().GetProduct(Id);
        }
        public void EditProduct(Product product)
        {
            new AdminManagmentDAL().EditProduct(product);
        }
        public void DelProduct(int Id)
        {
            new AdminManagmentDAL().DelProduct(Id);
        }
        //Product Statuses
        public List<ProductStatus> GetProductStatuses()
        {
            return new AdminManagmentDAL().GetProductStatuses();
        }
        public void AddProductStatuses(ProductStatus productStatuses)
        {
            new AdminManagmentDAL().AddProductStatuses(productStatuses);
        }
        public void DelProductStatus(int Id)
        {
            new AdminManagmentDAL().DelProductStatus(Id);
        }
        public ProductStatus GetProductStatus(int Id)
        {
            return new AdminManagmentDAL().GetProductStatus(Id);
        }
        public void EditProductStatus(ProductStatus productStatus)
        {
            new AdminManagmentDAL().EditProductStatus(productStatus);
        }
        //Cateories 
        public List<Category> GetCategories()
        {
            return new AdminManagmentDAL().GetCategories();

        }
        public void AddCategories(Category categories)
        {
            new AdminManagmentDAL().AddCategories(categories);
        }
        public void DelCat(int Id)
        {
            new AdminManagmentDAL().DelCat(Id);
        }
        public Category GetCat(int Id)
        {
            return new AdminManagmentDAL().GetCat(Id);
        }
        public void EditCat(Category category)
        {
            new AdminManagmentDAL().EditCat(category);
        }
        //SubCat
        public List<SubCategory> GetSubCategories()
        {
            return new AdminManagmentDAL().GetSubCategories();
        }
        public void AddSubCategories(SubCategory subcategories)
        {
            new AdminManagmentDAL().AddSubCategories(subcategories);
        }
        public void DelSubCat(int Id)
        {
            new AdminManagmentDAL().DelSubCat(Id);
        }
        public SubCategory GetSubCat(int Id)
        {
            return new AdminManagmentDAL().GetSubCat(Id);
        }
        public void EditSubCat(SubCategory subcategory)
        {
            new AdminManagmentDAL().EditSubCat(subcategory);
        }
        //Order
        public List<Order> GetOrders()
        {
            return new AdminManagmentDAL().GetOrders();
        }
        public void AddOrders(Order orders)
        {
            orders.CreatedAt = DateTime.UtcNow.AddHours(5);
            new AdminManagmentDAL().AddOrder(orders);
        }
        public void DelOrder(int Id)
        {
            new AdminManagmentDAL().DelOrder(Id);
        }
        public Order GetOrder(int Id)
        {
            return new AdminManagmentDAL().GetOrder(Id);
        }
        public void EditOrder(Order order)
        {
            new AdminManagmentDAL().EditOrder(order);
        }
        //Order Status
        public List<OrderStatus> GetOrderStatus()
        {
            return new AdminManagmentDAL().GetOrderStatus();
        }
        
        public void AddOrderStatus(OrderStatus orderStatuses)
        {
            new AdminManagmentDAL().AddOrderStatuses(orderStatuses);
        }
        public void DelOrderStatus(int Id)
        {
            new AdminManagmentDAL().DelOrderStatus(Id);
        }
        public OrderStatus GetOrderStatus(int Id)
        {
            return new AdminManagmentDAL().GetOrderStatus(Id);
        }
        public void EditOrderStatus(OrderStatus orderstatus)
        {
            new AdminManagmentDAL().EditOrderStatus(orderstatus);
        }
        //City
        public List<City> GetCities()
        {
            return new AdminManagmentDAL().GetCities();
        }
        public void AddCities(City cities)
        {
            new AdminManagmentDAL().AddCities(cities);
        }
        public void DelCity(int Id)
        {
            new AdminManagmentDAL().DelCity(Id);
        }
        public City GetCity(int Id)
        {
            return new AdminManagmentDAL().GetCity(Id);
        }
        public void EditCity(City city)
        {
            new AdminManagmentDAL().EditCity(city);
        }
        //Address Details
        public List<AddressDetail> GetAddressDetails()
        {
            return new AdminManagmentDAL().GetAddressDetails();
        }
        public void AddAddressDetails(AddressDetail AddressDetails)
        {
            new AdminManagmentDAL().AddAddressDetails(AddressDetails);
        }
        public void DelAddressDetails(int Id)
        {
            new AdminManagmentDAL().DelAddressDetails(Id);
        }
        public AddressDetail GetAddressDetails(int Id)
        {
            return new AdminManagmentDAL().GetAddressDetails(Id);
        }
        public void EditAddressDetails(AddressDetail addressDetail)
        {
            new AdminManagmentDAL().EditAddressDetails(addressDetail);
        }

    }
}
