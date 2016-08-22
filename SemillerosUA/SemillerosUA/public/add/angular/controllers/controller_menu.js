app.controller('GeneralController', [
  '$scope',
  '$http',
  function($scope, $http, $sce) {

    $scope.getRoles = function() {
      $http.get('/api/rol').success(function(data, status, headers, config) {
        $scope.listRoles = data;
      }).error(function(data, status, headers, config) {
        console.log("Error> " + data);
      });
    };

    $scope.getSemilleros = function() {
      $http.get('/api/semillero').success(function(data, status, headers, config) {
        $scope.listSemilleros = data;
      }).error(function(data, status, headers, config) {
        console.log("Error> " + data);
      });
    };

    $scope.getSemilleroById = function(id) {
      if (id != null) {
        $http.get('/api/semillero/' + id).success(function(data, status, headers, config) {
          $scope.DatosSemillero = data;
          $scope.NameSemillero = data.smlr_nombre;
          $scope.Welcome = "Estás ingresando como líder de";

        }).error(function(data, status, headers, config) {
          console.log("Error> " + data);
        });
      } else {
        $scope.NameSemillero = "GIECOM - Gestión del Conocimiento-Electrónica-Informática y Comunicaciones.";
        $scope.Welcome = "Estás ingresando a la plataforma de";
      }
    };
  }
]);
