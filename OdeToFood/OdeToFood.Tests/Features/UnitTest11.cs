using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Models;
using System;
using System.Collections.Generic;

namespace OdeToFood.Tests.Features
{
    [TestClass]
    public class UnitTest11
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var data = new Restaurant();
            data.Reviews = new List<RestaurantReview>();
            data.Reviews.Add(new RestaurantReview() { Rating = 4 });

            var rater = new RestaurantRater(data);
            var result = rater.ComputeRating(10);

            Assert.AreEqual(4, result.Rating);
        }
    }
}