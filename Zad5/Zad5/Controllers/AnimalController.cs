using Microsoft.AspNetCore.Mvc;
using Zad5.Models;
using Zad5.Repositories;
using Zad5.Services;

namespace Zad5.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalController: ControllerBase
{

    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }


    //get the whole list
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();
        return Ok(animals);
    }
    //get by id
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimal(id);

        if (animal == null)
        {
            return NotFound("Animal not found");
        }

        return Ok(animal);
    }
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        var affectedCount = _animalService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id,Animal animal)
    {
        _animalService.UpdateAnimal(animal);
        return NoContent();
    }
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
         _animalService.DeleteAnimal(id);
        return NoContent();
    }
}