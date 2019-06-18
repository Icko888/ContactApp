using ContactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Data
{
    public static class ContactDatabase
    {
        public static List<Contact> contactsList = new List<Contact>
        {
                new Contact("Angel","Trajkov",false,078359420),
                new Contact("Blagoj","Veslinovski",false,075639782),
                new Contact("Dejan","Savev",true,070650402),
                new Contact("Ema","Velkovska",true,077213100),
                new Contact("Goran","Manev",false,075340890),
                new Contact("Igor","Trajanov",false,079450450),
                new Contact("Kire","Georgievski",true,072300585),
                new Contact("Lazar","Andov",false,071777802),
                new Contact("Marinela","Minova",true,078379654),
                new Contact("Simona","Arsova",true,070320456),
                new Contact("Viktor","Apostolov",false,079856369),
                new Contact("Zarko","Gligorov",true,076241776)

        };
    }
}
