using EidAssignment.BAL;
using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EidAssignment.Controllers
{
    public class AdminController : Controller
    {

        // GET: Amin
       //EidiAssignmentContext db = new EidiAssignmentContext();
        public ActionResult Index()
        { 
            return View(new AdminManagmentBAL().GetProducts());
        }
        ////Role
        public ActionResult Roles()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.Roles.ToList();
            //return View(model);
            return View(new AdminManagmentBAL().GetRoles());
        }

        public ActionResult AddRole()
        {
            return View();
        }
        public ActionResult DelRole(int Id)
        {
            new AdminManagmentBAL().DelRole(Id);
            return RedirectToAction("Roles");
        }
        public ActionResult EditRole(int Id)
        {

            return View(new AdminManagmentBAL().GetRole(Id));
        }
        [HttpPost]
        public ActionResult EditRole(Role role)
        {
            new AdminManagmentBAL().EditRole(role);
            return RedirectToAction("Roles");
        }
        [HttpPost]
        public ActionResult AddRole(Role role)
        {

            //new AdminManagmentBAL().AddRole(role);
            //return RedirectToAction("Roles");

            new AdminManagmentBAL().AddRole(role);
            return RedirectToAction("Roles");
        }
        ////User Page
        public ActionResult Users()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.Users.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetUsers());

        }
        public ActionResult AddUser()
        {
            //ViewBag.Roles = db.Roles.ToList();
            ViewBag.Roles = new AdminManagmentBAL().GetRoles();
            return View();
        }
        public ActionResult DelUser(int Id)
        {
            new AdminManagmentBAL().DelUser(Id);
            return RedirectToAction("Users");

        }
        public ActionResult EditUser(int Id)
        {
            ViewBag.Roles = new AdminManagmentBAL().GetRoles();
            return View(new AdminManagmentBAL().GetUser(Id));
        }
        [HttpPost]
        public ActionResult EditUser(User user)
        {
            new AdminManagmentBAL().EditUser(user);
            return RedirectToAction("Users");
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            ////user.RoleId = 3;
            //user.JoinedOn = DateTime.UtcNow.AddHours(5);
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.Users.Add(user);
            //db.SaveChanges();
            new AdminManagmentBAL().AddUsers(user);
            return RedirectToAction("Users");
        }
        //Products 
        public ActionResult Products()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.Products.ToList();
            //return View(model);
            
            return View(new AdminManagmentBAL().GetProducts());

        }
        public ActionResult DelProduct(int Id)
        {
            new AdminManagmentBAL().DelProduct(Id);
            return RedirectToAction("Products");

        }
        public ActionResult AddProducts()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //ViewBag.Users = db.Users.ToList();
            //ViewBag.SubCategories = db.SubCategories.ToList();
            //ViewBag.ProductStatuses = db.ProductStatuses.ToList();

            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            ViewBag.SubCategories = new AdminManagmentBAL().GetSubCategories();
            ViewBag.ProductStatuses = new AdminManagmentBAL().GetProductStatuses();


            return View();
        }
    
        public ActionResult EditProduct(int Id)
        {
            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            ViewBag.SubCategories = new AdminManagmentBAL().GetSubCategories();
            ViewBag.ProductStatuses = new AdminManagmentBAL().GetProductStatuses();
            return View(new AdminManagmentBAL().GetProduct(Id));
        }
        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            new AdminManagmentBAL().EditProduct(product);
            return RedirectToAction("Products");
        }
        [HttpPost]
        public ActionResult AddProducts(Product product)
        {

            //product.MerchantId = 3;
            //product.SubCategoryId = 5;
            //product.ProductStatusId = 2;
            //db.Products.Add(product);
            //db.SaveChanges();
            new AdminManagmentBAL().AddProduct(product);
            return RedirectToAction("Products");
        }
        //Product Status
        public ActionResult ProductStatuses()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.ProductStatuses.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetProductStatuses());

        }
        public ActionResult DelProductStatus(int Id)
        {
            new AdminManagmentBAL().DelProductStatus(Id);
            return RedirectToAction("ProductStatuses");
        }
        public ActionResult AddProductStatuses()
        {
           
            return View();
        }
        public ActionResult EditProductStatus(int Id)
        {

            return View(new AdminManagmentBAL().GetProductStatus(Id));
        }
        [HttpPost]
        public ActionResult EditProductStatus(ProductStatus productStatus)
        {
            new AdminManagmentBAL().EditProductStatus(productStatus);
            return RedirectToAction("ProductStatuses");
        }
        [HttpPost]
        public ActionResult AddProductStatuses(ProductStatus productStatuses)
        {

            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.ProductStatuses.Add(productStatuses);
            //db.SaveChanges();
            new AdminManagmentBAL().AddProductStatuses(productStatuses);
            return RedirectToAction("ProductStatuses");
        }
        //categories
        public ActionResult Categories()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.Categories.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetCategories());

        }
        public ActionResult AddCategories()
        {

            return View();
        }
        public ActionResult AddCat()
        {
            return View();
        }
        public ActionResult Delcat(int Id)
        {
            new AdminManagmentBAL().DelCat(Id);
            return RedirectToAction("Categories");
        }
        public ActionResult EditCat(int Id)
        {

            return View(new AdminManagmentBAL().GetCat(Id));
        }
        [HttpPost]
        public ActionResult EditCat(Category category)
        {
            new AdminManagmentBAL().EditCat(category);
            return RedirectToAction("Categories");
        }
        [HttpPost]
        public ActionResult AddCategories(Category categories)
        {

            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.Categories.Add(categories);
            //db.SaveChanges();
            new AdminManagmentBAL().AddCategories(categories);
            return RedirectToAction("Categories");
        }
        //subcategories 
        public ActionResult Subcategories()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.SubCategories.ToList();
            //return View(model);
            return View(new AdminManagmentBAL().GetSubCategories());

        }
        public ActionResult DelSubCat(int Id)
        {
            new AdminManagmentBAL().DelSubCat(Id);
            return RedirectToAction("SubCategories");
        }
        public ActionResult AddSubcategories()
        {
            
            ViewBag.Categories = new AdminManagmentBAL().GetCategories();
            return View();
        }
        public ActionResult EditSubCat(int Id)
        {
            
            ViewBag.Categories = new AdminManagmentBAL().GetCategories();
            return View(new AdminManagmentBAL().GetSubCat(Id));
        }
        
        [HttpPost]
        public ActionResult EditSubCat(SubCategory subcategory)
        {
            
            new AdminManagmentBAL().EditSubCat(subcategory);
            return RedirectToAction("Subcategories");
        }
 
        [HttpPost]
        public ActionResult AddSubcategories(SubCategory subcategories)
        {

            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.SubCategories.Add(subcategories);
            //db.SaveChanges();
            new AdminManagmentBAL().AddSubCategories(subcategories);
            return RedirectToAction("SubCategories");
        }
        //Order
        public ActionResult Orders()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.Orders.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetOrders());

        }
        public ActionResult AddOrders()
        {
           
            ViewBag.OrderStatuses = new AdminManagmentBAL().GetOrderStatus();
            ViewBag.Products = new AdminManagmentBAL().GetProducts();
            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            return View();
        }
        public ActionResult AddOrder()
        {
            return View();
        }
        public ActionResult DelOrder(int Id)
        {
            new AdminManagmentBAL().DelOrder(Id);
            return RedirectToAction("Orders");
        }
        public ActionResult EditOrder(int Id)
        { 
            ViewBag.OrderStatuses = new AdminManagmentBAL().GetOrderStatus();
            ViewBag.Products = new AdminManagmentBAL().GetProducts();
            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            return View(new AdminManagmentBAL().GetOrder(Id));
        }
        [HttpPost]
        public ActionResult EditOrder(Order order)
        {
            new AdminManagmentBAL().EditOrder(order);
            return RedirectToAction("Orders");
        }
        [HttpPost]
        public ActionResult AddOrders(Order orders)
        {
            //orders.ClientId = 4;
            //orders.OrderStatusId = 1;
            //orders.ProductId = 8;
          
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.Orders.Add(orders);
            //db.SaveChanges();
            new AdminManagmentBAL().AddOrders(orders);
            return RedirectToAction("Orders");
        }
        //order status
        public ActionResult OrderStatuses()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.OrderStatuses.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetOrderStatus());

        }
        public ActionResult AddOrderStatuses()
        {

            return View();
        }
        public ActionResult DelOrderStatus(int Id)
        {
            new AdminManagmentBAL().DelOrderStatus(Id);
            return RedirectToAction("OrderStatuses");
        }
        public ActionResult EditOrderStatus(int Id)
        {
            ViewBag.OrderStatuses = new AdminManagmentBAL().GetOrderStatus();
            ViewBag.Products = new AdminManagmentBAL().GetProducts();
            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            return View(new AdminManagmentBAL().GetOrderStatus(Id));
        }
        [HttpPost]
        public ActionResult EditOrderStatus(OrderStatus orderstatus)
        {
            new AdminManagmentBAL().EditOrderStatus(orderstatus);
            return RedirectToAction("OrderStatuses");
        }
        [HttpPost]
        public ActionResult AddOrderStatuses(OrderStatus orderstatuses)
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.OrderStatuses.Add(orderstatuses);
            //db.SaveChanges();
            new AdminManagmentBAL().AddOrderStatus(orderstatuses);
            return RedirectToAction("OrderStatuses");
        }
        //City Details
        public ActionResult Cities()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.Cities.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetCities());

        }
        public ActionResult AddCities()
        {

            return View();
        }
        public ActionResult AddCity()
        {

            return View();
        }
        public ActionResult DelCity(int Id)
        {
            new AdminManagmentBAL().DelCity(Id);
            return RedirectToAction("Cities");
        }
        public ActionResult EditCity(int Id)
        {
           
            return View(new AdminManagmentBAL().GetCity(Id));
        }
        [HttpPost]
        public ActionResult Editcity(City city)
        {
            new AdminManagmentBAL().EditCity(city);
            return RedirectToAction("Cities");
        }
        [HttpPost]
        public ActionResult AddCities(City cities)
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.Cities.Add(cities);
            //db.SaveChanges();
            new AdminManagmentBAL().AddCities(cities);
            return RedirectToAction("Cities");
        }

        //AdressDetils 

        public ActionResult AddressDetails()
        {
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //var model = db.AddressDetails.ToList();
            //return View(model);

            return View(new AdminManagmentBAL().GetAddressDetails());

        }
        public ActionResult AddAddressDetails()
        {
            
            ViewBag.Cities = new AdminManagmentBAL().GetCities();
            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            return View();
        }
        [HttpPost]
        public ActionResult AddAddressDetails(AddressDetail addressDetails)
        {
            //AddressDetails.CityId = 1;
            //AddressDetails.UserId = 3;
            //EidiAssignmentContext db = new EidiAssignmentContext();
            //db.AddressDetails.Add(AddressDetails);
            //db.SaveChanges();
            new AdminManagmentBAL().AddAddressDetails(addressDetails);
            return RedirectToAction("AddressDetails");
        }
        public ActionResult DelAddressDetails(int Id)
        {
            new AdminManagmentBAL().DelAddressDetails(Id);
            return RedirectToAction("AddressDetails");
        }
        public ActionResult EditAddressDetails(int Id)
        {
            ViewBag.Cities = new AdminManagmentBAL().GetCities();
            ViewBag.Users = new AdminManagmentBAL().GetUsers();
            return View(new AdminManagmentBAL().GetAddressDetails(Id));
        }
        [HttpPost]
        public ActionResult EditAddressDetails(AddressDetail addressDetail)
        {
            new AdminManagmentBAL().EditAddressDetails(addressDetail);
            return RedirectToAction("AddressDetails");
        }
    }
}