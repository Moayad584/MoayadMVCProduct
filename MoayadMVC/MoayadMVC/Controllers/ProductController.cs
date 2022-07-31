using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoayadMVC.Models;
using System;
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
            ProductModel productModel = new ProductModel();
            DataTable dtbleProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT * FROM Product where ProductId= @ProductId";

                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@ProductId", id);
                sqlDa.Fill(dtbleProduct);

             
            }
            if(dtbleProduct.Rows.Count == 1)
            {
                productModel.ProductId = Convert.ToInt32(dtbleProduct.Rows[0][0].ToString());
                productModel.ProductName = dtbleProduct.Rows[0][1].ToString();
                productModel.Price = Convert.ToDecimal(dtbleProduct.Rows[0][2].ToString());
                productModel.Quantity = Convert.ToInt32(dtbleProduct.Rows[0][3].ToString());

                return View(productModel);
            }
            else
                return RedirectToAction("Index");

            
        }

        // POST: ProductController/Edit/5
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductModel productModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "UPDATE Product SET  ProductName= @ProductName , Price= @Price , Quantity= @Quantity where ProductId= @ProductId";
                SqlCommand sqlcmd = new SqlCommand(query, sqlCon);
                sqlcmd.Parameters.AddWithValue("@ProductId", productModel.ProductId);
                sqlcmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                sqlcmd.Parameters.AddWithValue("@Price", productModel.Price);
                sqlcmd.Parameters.AddWithValue("@Quantity", productModel.Quantity);
                sqlcmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");

        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "DELETE FROM Product where ProductId= @ProductId";
                SqlCommand sqlcmd = new SqlCommand(query, sqlCon);
                sqlcmd.Parameters.AddWithValue("@ProductId", id);
                
                sqlcmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        
        
    }
}
