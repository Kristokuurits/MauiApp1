using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.ViewModels
{
    public class ItemsViewModel
    {
        private readonly DatabaseContext _context;

        public ItemsViewModel(DatabaseContext context)
        {
            _context = context;
        }

    }
}
