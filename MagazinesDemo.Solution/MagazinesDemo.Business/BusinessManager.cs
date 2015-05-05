using MagazinesDemo.Business.Services;

namespace MagazinesDemo.Business
{
    public class BusinessManager
    {

        #region Variables
        private static IMagazineService _magazineService;
        private static IAuthorService _authorService;

        #endregion 


        #region Properties

        public static IMagazineService MagazineService
        {
            get { return _magazineService ?? (_magazineService = new MagazineService()); }
        }

        public static IAuthorService AuthorService
        {
            get { return _authorService ?? (_authorService = new AuthorService()); }
        }

        #endregion



    }
}
