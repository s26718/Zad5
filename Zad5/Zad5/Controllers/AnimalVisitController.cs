using Microsoft.AspNetCore.Mvc;
using Zad5.Models;
using Zad5.Services;

namespace Zad5.Controllers;

[Route("api/animalvisits")]
[ApiController]
public class AnimalVisitController:ControllerBase
{
    private IAnimalVisitService _animalVisitService;

    public AnimalVisitController(IAnimalVisitService animalVisitService)
    {
        _animalVisitService = animalVisitService;
    }
    
    //create
    [HttpPost]
    public IActionResult CreateAnimalVisit(AnimalVisit animalVisit)
    {
        var affectedCount = _animalVisitService.CreateAnimalVisit(animalVisit);
        return NoContent();
    }
    //get for id 
    [HttpGet("{animalId:int}")]
    public IActionResult GetAnimalVisitsForAnimal(int animalId)
    {
        var visits = _animalVisitService.GetAnimalVisitsForAnimal(animalId);
        return Ok(visits);
    }
}