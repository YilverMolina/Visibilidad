app.controller('GeneralController', [
  '$scope',
  '$http',
  function ($scope, $http, $sce) {
      var url = "http://localhost:63852/api/";

      $scope.getProgramas = function () {
          $http.get(url + 'programa/get_programa').success(function (data, status, headers, config) {
              $scope.listProgramas = data;
              
          }).error(function (data, status, headers, config) {
              console.log("Error> " + data);
          });
      };

      $scope.getProgramaSemillero = function (id) {
          $http.get(url + 'semillero/get_semillero_programa/' + id).success(function (data, status, headers, config) {
              $scope.listSemillerosP = data;
              if (data.length == 0) {
                  $scope.Result = "No se encontraron Semilleros registrados en este Programa Académico."
                  console.log("no hay");
              } else {
                  $scope.Result = "";
                  console.log("hay");
              }
          }).error(function (data, status, headers, config) {
              console.log("Error> " + data);
          });

      };

      $scope.getRoles = function () {
          $http.get(url + 'rol').success(function (data, status, headers, config) {
              $scope.listRoles = data;
          }).error(function (data, status, headers, config) {
              console.log("Error> " + data);
          });
      };

      $scope.getSemilleros = function () {
          $http.get('/api/semillero').success(function (data, status, headers, config) {
              $scope.listSemilleros = data;
          }).error(function (data, status, headers, config) {
              console.log("Error> " + data);
          });
      };

      $scope.getSemilleroById = function (id) {
          console.log(id);
          if (id != null) {
              $http.get(url + 'semillero/get_semillero_by_id/' + id).success(function (data, status, headers, config) {
                  $scope.DatosSemillero = data;
                  $scope.NameSemillero = data[0].SMLR_NOMBRE;
                  console.log(data[0].SMLR_NOMBRE);
                  $scope.Welcome = "Estás ingresando como líder de";

              }).error(function (data, status, headers, config) {
                  console.log("Error> " +JSON.stringify(data));
              });
          } else {
              $scope.NameSemillero = "GIECOM - Gestión del Conocimiento-Electrónica-Informática y Comunicaciones.";
              $scope.Welcome = "Estás ingresando a la plataforma de";
          }
      };
  }
]);
