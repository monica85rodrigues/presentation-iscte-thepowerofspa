using System.Collections.Generic;
using MagazinesDemo.Business.Entities;

namespace MagazinesDemo.Business.Data
{
    internal class MagazineData
    {
        public static Dictionary<int, Magazine> Magazines = new Dictionary<int, Magazine>();

        static MagazineData()
        {
            Magazines.Add(1, new Magazine { Id = 1, Link = "http://www.revista-programar.info/edicoes/edicao-1-marco-2006/", Title = "Edição 1 - Março 2006	 ", Year = 2006 });
            Magazines.Add(2, new Magazine { Id = 2, Link = "http://www.revista-programar.info/edicoes/edicao-2-maio-2006/	", Title = "Edição 2 - Maio 2006	 ", Year = 2006 });
            Magazines.Add(3, new Magazine { Id = 3, Link = "http://www.revista-programar.info/edicoes/edicao-3-julho-2006/", Title = "Edição 3 - Julho 2006	 ", Year = 2006 });
            Magazines.Add(4, new Magazine { Id = 4, Link = "http://www.revista-programar.info/edicoes/edicao-4-setembro-2006/", Title = "Edição 4 - Setembro 2006", Year = 2006 });
            Magazines.Add(5, new Magazine { Id = 5, Link = "http://www.revista-programar.info/edicoes/edicao-5-novembro-2006/", Title = "Edição 5 - Novembro 2006", Year = 2006 });
            Magazines.Add(6, new Magazine { Id = 6, Link = "http://www.revista-programar.info/edicoes/edicao-6-janeiro-2007/", Title = "Edição 6 - Janeiro 2007", Year = 2007 });
            Magazines.Add(7, new Magazine { Id = 7, Link = "http://www.revista-programar.info/edicoes/edicao-7-marco-2007/", Title = "Edição 7 - Mar;o 2007	 ", Year = 2007 });
            Magazines.Add(8, new Magazine { Id = 8, Link = "http://www.revista-programar.info/edicoes/edicao-8-maio-2007/	", Title = "Edição 8 - Maio 2007	 ", Year = 2007 });
            Magazines.Add(9, new Magazine { Id = 9, Link = "http://www.revista-programar.info/edicoes/edicao-9-julho-2007/", Title = "Edição 9 - Julho 2007	 ", Year = 2007 });
            Magazines.Add(10, new Magazine { Id = 10, Link = "http://www.revista-programar.info/edicoes/edicao-10-setembro-2007/", Title = "Edição 10 - Setembro 2007", Year = 2007 });
            Magazines.Add(11, new Magazine { Id = 11, Link = "http://www.revista-programar.info/edicoes/edicao-11-novembro-2007/", Title = "Edição 11 - Novembro 2007", Year = 2007 });
            Magazines.Add(12, new Magazine { Id = 12, Link = "http://www.revista-programar.info/edicoes/edicao-12-janeiro-2008/", Title = "Edição 12 - Janeiro 2008", Year = 2008 });
            Magazines.Add(13, new Magazine { Id = 13, Link = "http://www.revista-programar.info/edicoes/edicao-13-marco-2008/", Title = "Edição 13 - Março 2008", Year = 2008 });
            Magazines.Add(14, new Magazine { Id = 14, Link = "http://www.revista-programar.info/edicoes/edicao-14-maio-2008/", Title = "Edição 14 - Maio 2008", Year = 2008 });
            Magazines.Add(15, new Magazine { Id = 15, Link = "http://www.revista-programar.info/edicoes/edicao-15-agosto-2008/", Title = "Edição 15 - Agosto 2008", Year = 2008 });
            Magazines.Add(16, new Magazine { Id = 16, Link = "http://www.revista-programar.info/edicoes/edicao-16-outubro-2008/", Title = "Edição 16 - Outubro 2008", Year = 2008 });
            Magazines.Add(17, new Magazine { Id = 17, Link = "http://www.revista-programar.info/edicoes/edicao-17-dezembro-2008/", Title = "Edição 17 - Dezembro 2008", Year = 2008 });
            Magazines.Add(18, new Magazine { Id = 18, Link = "http://www.revista-programar.info/edicoes/edicao-18-fevereiro-2009/", Title = "Edição 18 - Fevereiro 2009", Year = 2009 });
            Magazines.Add(19, new Magazine { Id = 19, Link = "http://www.revista-programar.info/edicoes/edicao-19-abril-2009/", Title = "Edição 19 - Abril 2009", Year = 2009 });
            Magazines.Add(20, new Magazine { Id = 20, Link = "http://www.revista-programar.info/edicoes/edicao-20-junho-2009/", Title = "Edição 20 - Junho 2009", Year = 2009 });
            Magazines.Add(21, new Magazine { Id = 21, Link = "http://www.revista-programar.info/edicoes/edicao-21-stembro-2009/", Title = "Edição 21 - Setembro 2009", Year = 2009 });
            Magazines.Add(22, new Magazine { Id = 22, Link = "http://www.revista-programar.info/edicoes/edicao-22-novembro-2009/", Title = "Edição 22 - Novembro 2009", Year = 2009 });
            Magazines.Add(23, new Magazine { Id = 23, Link = "http://www.revista-programar.info/edicoes/edicao-23-marco-2010/", Title = "Edição 23 - Março 2010", Year = 2010 });
            Magazines.Add(24, new Magazine { Id = 24, Link = "http://www.revista-programar.info/edicoes/edicao-24-junho-2010/", Title = "Edição 24 - Junho 2010", Year = 2010 });
            Magazines.Add(25, new Magazine { Id = 25, Link = "http://www.revista-programar.info/edicoes/edicao-25-setembro-2010/", Title = "Edição 25 - Setembro 2010", Year = 2010 });
            Magazines.Add(26, new Magazine { Id = 26, Link = "http://www.revista-programar.info/edicoes/edicao-26-dezembro-2010/", Title = "Edição 26 - Dezembro 2010", Year = 2010 });
            Magazines.Add(27, new Magazine { Id = 27, Link = "http://www.revista-programar.info/edicoes/edicao-27-fevereiro-2011/", Title = "Edição 27 - Fevereiro 2011", Year = 2011 });
            Magazines.Add(28, new Magazine { Id = 28, Link = "http://www.revista-programar.info/edicoes/edicao-28-abril-2011/", Title = "Edição 28 - Abril 2011", Year = 2011 });
            Magazines.Add(29, new Magazine { Id = 29, Link = "http://www.revista-programar.info/edicoes/edicao-29-junho-2011/", Title = "Edição 29 - Junho 2011", Year = 2011 });
            Magazines.Add(30, new Magazine { Id = 30, Link = "http://www.revista-programar.info/edicoes/edicao-30-agosto-2011/", Title = "Edição 30 - Agosto 2011", Year = 2011 });
            Magazines.Add(31, new Magazine { Id = 31, Link = "http://www.revista-programar.info/edicoes/edicao-31-outubro-2011/", Title = "Edição 31 - Outubro 2011", Year = 2011 });
            Magazines.Add(32, new Magazine { Id = 32, Link = "http://www.revista-programar.info/edicoes/edicao-32-dezembro-2011/", Title = "Edição 32 - Dezembro 2011", Year = 2011 });
            Magazines.Add(33, new Magazine { Id = 33, Link = "http://www.revista-programar.info/edicoes/edicao-33-fevereiro-2012/", Title = "Edição 33 - Fevereiro 2012", Year = 2012 });
            Magazines.Add(34, new Magazine { Id = 34, Link = "http://www.revista-programar.info/edicoes/edicao-34-abril-2012/", Title = "Edição 34 - Abril 2012", Year = 2012 });
            Magazines.Add(35, new Magazine { Id = 35, Link = "http://www.revista-programar.info/edicoes/edicao-35-junho-2012/", Title = "Edição 35 - Junho 2012", Year = 2012 });
            Magazines.Add(36, new Magazine { Id = 36, Link = "http://www.revista-programar.info/edicoes/edicao-36-agosto-2012/", Title = "Edição 36 - Agosto 20012", Year = 2012 });
            Magazines.Add(37, new Magazine { Id = 37, Link = "http://www.revista-programar.info/edicoes/edicao-37-outubro-2012/", Title = "Edição 37 - Outubro 2012", Year = 2012 });
            Magazines.Add(38, new Magazine { Id = 38, Link = "http://www.revista-programar.info/edicoes/edicao-38-dezembro-2012/", Title = "Edição 38 - Dezembro 2012", Year = 2012 });
            Magazines.Add(39, new Magazine { Id = 39, Link = "http://www.revista-programar.info/edicoes/edicao-39-fevereiro-2013/", Title = "Edição 39 - Fevereiro 2013", Year = 2013 });
            Magazines.Add(40, new Magazine { Id = 40, Link = "http://www.revista-programar.info/edicoes/edicao-40-abril-2013/", Title = "Edição 40 - Abril 2013", Year = 2013 });
            Magazines.Add(41, new Magazine { Id = 41, Link = "http://www.revista-programar.info/edicoes/edicao-41-junho-2013/", Title = "Edição 41 - Junho 2013", Year = 2013 });
            Magazines.Add(42, new Magazine { Id = 42, Link = "http://www.revista-programar.info/edicoes/edicao-42-agosto-2013/", Title = "Edição 42 - Agosto 2013", Year = 2013 });
            Magazines.Add(43, new Magazine { Id = 43, Link = "http://www.revista-programar.info/edicoes/edicao-43-dezembro-2013/", Title = "Edição 43 - Dezembro 2013", Year = 2013 });
            Magazines.Add(44, new Magazine { Id = 44, Link = "http://www.revista-programar.info/edicoes/edicao-44-fevereiro-2014/", Title = "Edição 44 - Fevereiro 2014", Year = 2014 });
            Magazines.Add(45, new Magazine { Id = 45, Link = "http://www.revista-programar.info/edicoes/edicao-45-maio-2014/", Title = "Edição 45 - Maio 2014", Year = 2014 });
            Magazines.Add(46, new Magazine { Id = 46, Link = "http://www.revista-programar.info/edicoes/edicao-46-setembro-2014/", Title = "Edição 46 - Setembro 2014", Year = 2014 });
            Magazines.Add(47, new Magazine { Id = 47, Link = "http://www.revista-programar.info/edicoes/edicao-47-dezembro-2014/", Title = "Edição 47 - Dezembro 2014", Year = 2014 });
            Magazines.Add(48, new Magazine { Id = 48, Link = "http://www.revista-programar.info/edicoes/edicao-48-marco-2015/", Title = "Edição 48 - Março 2015", Year = 2015 });
        }
    }
}
