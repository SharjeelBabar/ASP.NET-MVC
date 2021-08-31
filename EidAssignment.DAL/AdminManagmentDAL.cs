using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EidAssignment.DAL
{
    public class AdminManagmentDAL
    {
      private readonly EidiAssignmentContext db = new EidiAssignmentContext();
        //Roles
        public List<Role> GetRoles()
        {
            return db.Roles.ToList();
        }
        public Role GetRole(int Id)
        {
            return db.Roles.Where(x=>x.Id==Id).FirstOrDefault();
        }
        public void AddRole(Role role)
        {
            db.Roles.Add(role);
            db.SaveChanges();
        }
        public void EditRole(Role role)
        {
            var DbRole = db.Roles.Where(x => x.Id == role.Id).FirstOrDefault(); 
           if(DbRole!= null)
            {
                if (!string.IsNullOrEmpty(role.Name))
                {
                    DbRole.Name = role.Name;
                }
            }
            db.SaveChanges();
        }
        public void DelRole(int Id)
        {
            
            db.Roles.Remove(db.Roles.Find(Id));
            db.SaveChanges();
        }
        //USers
        public List<User> GetUsers()
        {
            return db.Users.ToList();
        }
        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
       
        public void DelUser(int Id)
        {
            db.Users.Remove(db.Users.Find(Id));
            db.SaveChanges();
        }
        public User GetUser(int Id)
        {
            return db.Users.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditUser(User user)
        {
            var DbUser = db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
            if (DbUser != null)
            {
                if (!string.IsNullOrEmpty(user.Name))
                {
                    DbUser.Name = user.Name;
                }
                if (!string.IsNullOrEmpty(user.PhoneNo))
                {
                    DbUser.PhoneNo = user.PhoneNo;
                }
                if (!string.IsNullOrEmpty(user.Password))
                {
                    DbUser.Password = user.Password;
                }
                if (!string.IsNullOrEmpty(user.Email))
                {
                    DbUser.Email = user.Email;
                }
                if (!string.IsNullOrEmpty(user.RoleId.ToString()))
                {
                    DbUser.RoleId = user.RoleId;
                }
            }
            db.SaveChanges();
        }
        //Products
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        public void AddProducts(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void DelProduct(int Id)
        {
            db.Products.Remove(db.Products.Find(Id));
            db.SaveChanges();
        }
        public Product GetProduct(int Id)
        {
            return db.Products.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditProduct(Product product)
        {
            var DbProduct = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (DbProduct != null)
            {
                if (!string.IsNullOrEmpty(product.Title))
                {
                    DbProduct.Title = product.Title;
                }
                if (!string.IsNullOrEmpty(product.Descrpition))
                {
                    DbProduct.Descrpition = product.Descrpition;
                }
                if (!string.IsNullOrEmpty(product.EndTime))
                {
                    DbProduct.EndTime = product.EndTime;
                
                }
                if (!string.IsNullOrEmpty(product.Price.ToString()))
                {
                    DbProduct.Price = product.Price;
                }
                if (!string.IsNullOrEmpty(product.MerchantId.ToString()))
                {
                    DbProduct.MerchantId = product.MerchantId;
                }
                if (!string.IsNullOrEmpty(product.SubCategoryId.ToString()))
                {
                    DbProduct.SubCategoryId = product.SubCategoryId;
                }

            }
            db.SaveChanges();
        }
        //Product Statuses
        public List<ProductStatus> GetProductStatuses()
        {
            return db.ProductStatuses.ToList();
        }
        public void AddProductStatuses(ProductStatus ProductStatuses)
        {
            db.ProductStatuses.Add(ProductStatuses);
            db.SaveChanges();
        }
        public void DelProductStatus(int Id)
        {
            db.ProductStatuses.Remove(db.ProductStatuses.Find(Id));
            db.SaveChanges();
        }
        public ProductStatus GetProductStatus(int Id)
        {
            return db.ProductStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditProductStatus(ProductStatus productStatus)
        {
            var DbProductStatus = db.ProductStatuses.Where(x => x.Id == productStatus.Id).FirstOrDefault();
            if (DbProductStatus != null)
            {
                if (!string.IsNullOrEmpty(productStatus.Name))
                {
                    DbProductStatus.Name = productStatus.Name;
                }
            }
            db.SaveChanges();
        }
        //Category
        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }
        public void AddCategories(Category categories)
        {
            db.Categories.Add(categories);
            db.SaveChanges();
        }
        public void DelCat(int Id)
        {
            db.Categories.Remove(db.Categories.Find(Id));
            db.SaveChanges();
        }
        public Category GetCat(int Id)
        {
            return db.Categories.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditCat(Category category)
        {
            var DbCat = db.Categories.Where(x => x.Id == category.Id).FirstOrDefault();
            if (DbCat != null)
            {
                if (!string.IsNullOrEmpty(category.Name))
                {
                    DbCat.Name = category.Name;
                }
                if (!string.IsNullOrEmpty(category.Icon))
                {
                    DbCat.Icon = category.Icon;
                }
            }
            db.SaveChanges();
        }
        //SubCategory
        public List<SubCategory> GetSubCategories()
        {
            return db.SubCategories.ToList();
        }
        public void AddSubCategories(SubCategory SubCategories)
        {
            db.SubCategories.Add(SubCategories);
            db.SaveChanges();
        }
        public void DelSubCat(int Id)
        {
            db.SubCategories.Remove(db.SubCategories.Find(Id));
            db.SaveChanges();
        }
        public SubCategory GetSubCat(int Id)
        {
            return db.SubCategories.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditSubCat(SubCategory subcategory)
        {
            var DbSubCat = db.SubCategories.Where(x => x.Id == subcategory.Id).FirstOrDefault();
            if (DbSubCat != null)
            {
                if (!string.IsNullOrEmpty(subcategory.Name))
                {
                    DbSubCat.Name = subcategory.Name;
                }
                if (!string.IsNullOrEmpty(subcategory.Descrition))
                {
                    DbSubCat.Descrition = subcategory.Descrition;
                }
                if (!string.IsNullOrEmpty(subcategory.Icon))
                {
                    DbSubCat.Icon = subcategory.Icon;
                }
                if (!string.IsNullOrEmpty(subcategory.CategoryId.ToString()))
                {
                    DbSubCat.CategoryId = subcategory.CategoryId;
                }
            }
            db.SaveChanges();
        }
        //Order
        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }
        public void AddOrder(Order Orders)
        {
            db.Orders.Add(Orders);
            db.SaveChanges();
        }
        public void DelOrder(int Id)
        {
            db.Orders.Remove(db.Orders.Find(Id));
            db.SaveChanges();
        }
        public Order GetOrder(int Id)
        {
            return db.Orders.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditOrder(Order order)
        {
            var DbOrder = db.Orders.Where(x => x.Id == order.Id).FirstOrDefault();
            if (DbOrder != null)
            {
                if (!string.IsNullOrEmpty(order.ShippingAddress) && !string.IsNullOrEmpty(order.Amount.ToString()))
                {
                    DbOrder.ShippingAddress = order.ShippingAddress;
                    DbOrder.Amount = order.Amount;
                }
                if (!string.IsNullOrEmpty(order.ProductId.ToString()))
                {
                    DbOrder.ProductId = order.ProductId;
                }
                if (!string.IsNullOrEmpty(order.OrderStatusId.ToString()))
                {
                    DbOrder.OrderStatusId = order.OrderStatusId;
                }
            }
            db.SaveChanges();
        }
        //OrderStatus
        public List<OrderStatus> GetOrderStatus()
        {
            return db.OrderStatuses.ToList();
        }
        public void AddOrderStatuses(OrderStatus OrderStatuses)
        {
            db.OrderStatuses.Add(OrderStatuses);
            db.SaveChanges();
        }
        public void DelOrderStatus(int Id)
        {
            db.OrderStatuses.Remove(db.OrderStatuses.Find(Id));
            db.SaveChanges();
        }
        public OrderStatus GetOrderStatus(int Id)
        {
            return db.OrderStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditOrderStatus(OrderStatus orderStatus)
        {
            var DbOrderStatus = db.OrderStatuses.Where(x => x.Id == orderStatus.Id).FirstOrDefault();
            if (DbOrderStatus != null)
            {
                if (!string.IsNullOrEmpty(orderStatus.Name) )
                {
                    DbOrderStatus.Name = orderStatus.Name;
                }
            }
            db.SaveChanges();
        }
        //City
        public List<City> GetCities()
        {
            return db.Cities.ToList();
        }
        public void AddCities(City cities)
        {
            db.Cities.Add(cities);
            db.SaveChanges();
        }
        public void DelCity(int Id)
        {
            db.Cities.Remove(db.Cities.Find(Id));
            db.SaveChanges();
        }
        public City GetCity(int Id)
        {
            return db.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditCity(City city)
        {
            var Dbcity = db.Cities.Where(x => x.Id == city.Id).FirstOrDefault();
            if (Dbcity != null)
            {
                if (!string.IsNullOrEmpty(city.Name))
                {
                    Dbcity.Name = city.Name;
                }
            }
            db.SaveChanges();
        }
        //AddressDetails
        public List<AddressDetail> GetAddressDetails()
        {
            return db.AddressDetails.ToList();
        }
        public void AddAddressDetails(AddressDetail addressDetail)
        {
            db.AddressDetails.Add(addressDetail);
            db.SaveChanges();
        }
        public void DelAddressDetails(int Id)
        {
            db.AddressDetails.Remove(db.AddressDetails.Find(Id));
            db.SaveChanges();
        }
        public AddressDetail GetAddressDetails(int Id)
        {
            return db.AddressDetails.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditAddressDetails(AddressDetail addressDetail)
        {
            var DbAddress = db.AddressDetails.Where(x => x.Id == addressDetail.Id).FirstOrDefault();
            if (DbAddress != null)
            {
                if (!string.IsNullOrEmpty(addressDetail.Area))
                {
                    DbAddress.Area = addressDetail.Area;
                }
                if (!string.IsNullOrEmpty(addressDetail.HouseNo))
                {
                    DbAddress.HouseNo = addressDetail.HouseNo;
                }
                if (!string.IsNullOrEmpty(addressDetail.StreetNo))
                {
                    DbAddress.StreetNo = addressDetail.StreetNo;
                }
                if (!string.IsNullOrEmpty(addressDetail.CityId.ToString()))
                {
                    DbAddress.CityId = addressDetail.CityId;
                }
                if (!string.IsNullOrEmpty(addressDetail.UserId.ToString()))
                {
                    DbAddress.UserId = addressDetail.UserId;
                }
            }
            db.SaveChanges();
        }

    }
}
