using System;
using System.Text.RegularExpressions;

namespace Triangle.Models
{
  public class Measurements
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }
    public string TriangleType { get; set; }

    public Measurements (string measureOne, string measureTwo, string measureThree)
    {
      Regex regex = new Regex(@"\d+");
      Match resultOne = regex.Match(measureOne);
      Match resultTwo = regex.Match(measureTwo);
      Match resultThree = regex.Match(measureThree);
      if (resultOne.Success && resultTwo.Success && resultThree.Success) {
        SideOne = int.Parse(measureOne);
        SideTwo = int.Parse(measureTwo);
        SideThree = int.Parse(measureThree);
      } else {
        throw new Exception();
      }
    }
    public void TriangleCalc()
    {
      if (SideOne != SideTwo && SideTwo != SideThree && SideThree != SideOne) {
        TriangleType = "Scalene";
      } else if (SideOne != SideTwo || SideTwo != SideThree || SideThree != SideOne) {
        TriangleType = "Isosceles";
      } else {
        TriangleType = "Equilateral";
      }
    }
  }
}
