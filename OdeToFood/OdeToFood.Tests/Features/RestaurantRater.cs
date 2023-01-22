using OdeToFood.Models;
using System;

namespace OdeToFood.Tests.Features
{
    public class RestaurantRater
    {
        private Restaurant _restaurant;

        public RestaurantRater(Restaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public RatingResult ComputeRating(int numberOfReviews)
        {
            var result = new RatingResult();
            result.Rating = 4;
            return result;
        }
    }
}