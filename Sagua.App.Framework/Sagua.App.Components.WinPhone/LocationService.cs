﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks; 
using Microsoft.Phone.Net.NetworkInformation;
using Microsoft.Phone.Tasks;
using Sagua.App.Components;
using Xamarin.Geolocation;
using Xamarin.Media;
using Sagua.App.Components.WinPhone;
using Xamarin.Forms;
[assembly: Dependency(typeof(LocationService))]
namespace Sagua.App.Components.WinPhone
{
    public class LocationService : ILocationService
    {
        private readonly Geolocator locator;


        public LocationService()
        {
 
            this.locator = new Geolocator();
            this.locator.PositionChanged += this.OnPositionChanged;
            this.locator.PositionError += this.OnPositionError;
        }



        #region Internals

        private void OnPositionChanged(object sender, Xamarin.Geolocation.PositionEventArgs e)
        {
            if (this.PositionChanged != null)
            {
                var pos = ToFormsPosition(e.Position);
                this.PositionChanged(this, new PositionEventArgs(pos));
            }
        }


        private void OnPositionError(object sender, Xamarin.Geolocation.PositionErrorEventArgs e)
        {
            if (this.PositionError != null)
            {
                var error = (e.Error == GeolocationError.Unauthorized
                    ? GeoLocationError.Unauthorized
                    : GeoLocationError.PositionUnavailable
                );
                this.PositionError(this, new PositionErrorEventArgs(error));
            }
        }


        private static Position ToFormsPosition(Xamarin.Geolocation.Position pos)
        {
            return new Position
            {
                Accuracy = pos.Accuracy,
                Altitude = pos.Altitude,
                AltitudeAccuracy = pos.AltitudeAccuracy,
                Heading = pos.Heading,
                Latitude = pos.Latitude,
                Longitude = pos.Longitude,
                Speed = pos.Speed,
                Timestamp = pos.Timestamp
            };
        }

        #endregion

        #region ILocationService Members

        public double DesiredAccuracy
        {
            get { return this.locator.DesiredAccuracy; }
            set { this.locator.DesiredAccuracy = value; }
        }


        public bool IsListening
        {
            get { return this.locator.IsListening; }
        }


        public bool IsGeoLocationAvailable
        {
            get { return this.locator.IsGeolocationAvailable; }
        }


        public bool SupportsHeading
        {
            get { return this.locator.SupportsHeading; }
        }


        public void StartListening(int minTime, double minDistance, bool includeHeading = false)
        {
            this.locator.StartListening(minTime, minDistance, includeHeading);
        }


        public void StopListening()
        {
            this.locator.StopListening();
        }


        public async Task<Position> GetPositionAsync(int timeout = 30, bool includeHeading = false, CancellationToken cancelToken = default(CancellationToken))
        {
            var pos = await this.locator.GetPositionAsync(timeout, cancelToken, includeHeading);
            return ToFormsPosition(pos);
        }

        public event EventHandler<PositionEventArgs> PositionChanged;

        public event EventHandler<PositionErrorEventArgs> PositionError;

        #endregion
    }
}