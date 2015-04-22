using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Leaflet.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<KeyValuePair<string, Location>> Get()
        {
            var locations = new List<KeyValuePair<string, Location>>();
            locations.Add(new KeyValuePair<string, Location>("Landmark, Exeter", new Location() { Lng = -3.464761, Lat = 50.720282 }));
            locations.Add(new KeyValuePair<string, Location>("Landmark, Reading", new Location() { Lng = -0.974534, Lat = 51.420104 }));
            locations.Add(new KeyValuePair<string, Location>("Landmark, Godalming", new Location() { Lng = -0.618375, Lat = 51.185865 }));
            locations.Add(new KeyValuePair<string, Location>("Landmark, Brighton", new Location() { Lng = -0.145218, Lat = 50.824563 }));
            locations.Add(new KeyValuePair<string, Location>("Landmark, London", new Location() { Lng = -0.027018, Lat = 51.508994 }));

            locations.Add(new KeyValuePair<string, Location>("Hobsons, Cincinnati", new Location() { Lng = -84.365097, Lat = 39.283263 }));
            locations.Add(new KeyValuePair<string, Location>("Hobsons, Washington", new Location() { Lng = -77.094498, Lat = 38.888185 }));
            locations.Add(new KeyValuePair<string, Location>("Hobsons, Oklahoma", new Location() { Lng = -97.511902, Lat = 35.586609 }));
            locations.Add(new KeyValuePair<string, Location>("Hobsons, Oakland", new Location() { Lng = -122.256615, Lat = 37.827730 }));
            locations.Add(new KeyValuePair<string, Location>("Hobsons, Portland", new Location() { Lng = -122.538130, Lat = 45.620128 }));

            return locations;
        }
    }

    public class Location
    {
        public double Lng { get; set; }
        public double Lat { get; set; }
    }
}
