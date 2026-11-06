
using System.Collections.Generic;
using DataLogicLayer.Models;

namespace PersonalMovieTracker.BusinessLogic
{
    public enum PurchaseResult { Success, AlreadyOwned, InsufficientBalance }

    public class MovieService
    {
        public const int MoviePrice = 100;

        public PurchaseResult Purchase(Account account, string movie)
        {
            if (account.Movies.Contains(movie))
                return PurchaseResult.AlreadyOwned;

            if (account.Balance < MoviePrice)
                return PurchaseResult.InsufficientBalance;

            account.Balance -= MoviePrice;
            account.Movies.Add(movie);
            return PurchaseResult.Success;
        }

        public bool AddMovie(Account account, string title)
        {
            if (account.Movies.Contains(title))
            {
                return false;
            }

            account.Movies.Add(title);
            return true;
        }
        public List<string> GetMovies(Account account)
        {
            return account.Movies;
        }
    }
}