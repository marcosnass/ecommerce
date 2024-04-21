using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ecommerce.Contexts;
using ecommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Controllers;

public class ProductController : Controller
    {

    private readonly ecommerceContext _context;

    public ProductController(ecommerceContext context){
        _context = context;
    }

    public IActionResult Index(){

        ViewData["Title"] = "Lista dos produtos Disponíveis";
        var products = _context.Products.ToList();

        return View(products);
    }

    public IActionResult UserMaster(){

        ViewData["Title"] = "Tabela dos Produtos";
        var products = _context.Products.ToList();

        return View("UserMaster", products);
    }

    public IActionResult AddCar(){
        return View("Cart");
    }

    public IActionResult Signup(){
        ViewData["Title"] = "Cadastro";
        return View("Signup");
    }

    [HttpPost]
    public IActionResult Signup(Product p){
        _context.Products.Add(p);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Create(Product p){
        _context.Products.Add(p);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Create(){
        ViewData["Title"] = "Adicionar Produto";
        return View("Form");
    }

    public IActionResult Edit(int id){
        var p = _context.Products.Find(id);
        ViewData["Title"] = "Editar Produto";
        return View("Form", p);
    }

    [HttpPost]
    public IActionResult Edit(Product p){
        _context.Products.Update(p);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult ChangeUser(Boolean code){
        if(code){
            code=false;
        }else{
            code=true;
        }
        return RedirectToAction("Index");
    }
    public IActionResult Delete(int id){
        var p = _context.Products.Find(id);
        ViewData["Title"] = "Deletar Usuário";
        return View(p);
    }

    [HttpPost]
    public IActionResult Delete(Product p){
        _context.Products.Remove(p);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}