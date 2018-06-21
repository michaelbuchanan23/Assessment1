using MVCEFRazorAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEFRazorAssessment.ViewModels {
	public class VehiclesForOwner {

		public Owner Owner{ get; set; }
		public IEnumerable<Vehicle> Vehicles{ get; set; }
	}
}