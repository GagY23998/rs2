using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class TransportOfferViewModel: BaseViewModel
    {
        public ObservableCollection<TransportOfferModel> transports { get; set; } = new ObservableCollection<TransportOfferModel>();

        private readonly APIService _tOfferservice = new APIService("transportoffer");
        private readonly APIService _tCompanyservice = new APIService("transportcompany");
        public TransportOfferViewModel(int? id = null)
        {
            _id = id;
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {

            try
            {
                List<TransportCompanyDTO> tCompanyData = null;
                List<TransportOfferDTO> tOfferData = null;

                var searchRequest = (_id.HasValue) ? new TransportOfferSearchRequest
                {
                    CityId = _id.Value,
                    StartDate = DateTime.MinValue,
                    EndDate = DateTime.MinValue,
                    IsActive = true
                } : new TransportOfferSearchRequest
                {
                    StartDate = DateTime.MinValue,
                    EndDate = DateTime.MinValue,
                    IsActive = true
                };
                   
                tOfferData = await _tOfferservice.Get<List<TransportOfferDTO>>(searchRequest);
                tCompanyData = await _tCompanyservice.Get<List<TransportCompanyDTO>>(null);
               
                foreach (var item in tOfferData)
                {
                    var model = new TransportOfferModel();

                    model.tOffer = item;
                    model.Name = tCompanyData.FirstOrDefault(_ => _.Id == item.TransportCompanyId).TransportCompanyName;
                    
                    transports.Add(model);
                }
            }
            catch (Exception)
            {

            }

        }

        private int? _id;

        public ICommand InitCommand { get; set; }
    }
}
