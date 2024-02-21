using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercatorisAdiutor.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private PlannerViewModel plannerViewModel;
        private CatalogViewModel catalogViewModel;
        private DetailsViewModel detailsViewModel;

        public MainViewModel()
        {
            plannerViewModel = new PlannerViewModel();
            catalogViewModel = new CatalogViewModel();
            detailsViewModel = new DetailsViewModel();
        }

        public PlannerViewModel PlannerViewModel => plannerViewModel;
        
        public CatalogViewModel CatalogViewModel => catalogViewModel;
        
        public DetailsViewModel DetailsViewModel => detailsViewModel;
    }
}
