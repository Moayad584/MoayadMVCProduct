using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoayadMVC.Models;
using System.Data;
using System.Data.SqlClient;

namespace MoayadMVC.Controllers
{
    public class ProductController : Controller
    {
        string connectionString = @"Data Source=DESKTOP-9OU2CPR; Initial Catalog = MvcProductDB ;Integrated Security=True";

        [HttpGet]
        public ActionResult Index()
        {
            DataTable dtbleProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Product",sqlCon);
                sqlDa.Fill(dtbleProduct);
            }
            return View(dtbleProduct);
        }

       

        [HttpGet]
        public ActionResult Create()
        {

            return View(new ProductModel ());
        }


        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel productModel)
        {
           using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open ();
                string query = "INSERT INTO Product VALUES(@ProductName,@Price,@Quantity)";
                SqlCommand sqlcmd = new SqlCommand (query, sqlCon);
               // sqlcmd.Parameters.AddWithValue("@ProductId", productModel.ProductId);
                sqlcmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                sqlcmd.Parameters.AddWithValue("@Price", productModel.Price);
                sqlcmd.Parameters.AddWithValue("@Quantity", productModel.Quantity);
                sqlcmd.ExecuteNonQuery();
            }

           return RedirectToAction("Index");
            
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
