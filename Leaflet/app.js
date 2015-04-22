var app = angular.module("demoapp", ["leaflet-directive"]);
app.controller('DemoController', ['$scope', '$http', function ($scope, $http) {
    angular.extend($scope, {
        center: {
            lat:  50.720282,  
            lng: -3.464761,
            zoom: 14
        },
        data: { markers: {} }
    });

    $scope.initMarkers = function (markers) {

        $scope.data.markers = {};

        angular.forEach(markers, function (marker, index) {

            $scope.data.markers[index] = {
                message: marker.Key,
                lat: marker.Value.Lat,
                lng: marker.Value.Lng
            }

        });

    };

    $http.get('/api/values').
      success(function (data, status, headers, config) {
          // this callback will be called asynchronously
          // when the response is available
          $scope.initMarkers(data);
      }).
      error(function (data, status, headers, config) {
          // called asynchronously if an error occurs
          // or server returns response with an error status.
      });

    $scope.centerNorthAmerica = function () {

        angular.extend($scope, {
            center: {
                lat: 38.749694,
                lng: -99.726475,
                zoom: 5
            },
            defaults: {
                scrollWheelZoom: false
            }
        });
    }

    $scope.centerEurope = function () {

        angular.extend($scope, {
            center: {
                lat: 51.505,
                lng: -0.09,
                zoom: 7
            },
            defaults: {
                scrollWheelZoom: false
            }
        });
    }



}]);