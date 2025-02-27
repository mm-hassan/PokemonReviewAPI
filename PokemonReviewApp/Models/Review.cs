﻿namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Rating { get; set; }

        public Reviewer Reviewer { get; set; }

        public Pokemon Pokemon { get; set; }
    }
}
