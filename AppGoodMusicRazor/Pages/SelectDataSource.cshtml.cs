﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Services;
using Configuration;

namespace AppMusicRazor.Pages
{
    public class SelectDataSourceModel : PageModel
    {
        readonly IMusicServiceActive _service = null;
        readonly ILogger<ListOfGroupsModel> _logger = null;

        //ModelBinding for Selections
        [BindProperty]
        public MusicDataSource SelectedDataSource { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            _service.ActiveDataSource = SelectedDataSource;
            return Page();
        }

        public SelectDataSourceModel(IMusicServiceActive service, ILogger<ListOfGroupsModel> logger)
        {
            _service = service;
            _logger = logger;

            SelectedDataSource = _service.ActiveDataSource;
        }
    }
}
