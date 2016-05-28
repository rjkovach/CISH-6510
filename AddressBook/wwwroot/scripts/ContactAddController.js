function ContactAddController($scope, $routeParams, $location, Contact) {
	$scope.contact = new Contact();

	$scope.save = function () {
		$scope.contact.$save(function (newContact) {
			$location.path("/Contact/" + newContact.ContactId);
		});
	};

	$scope.cancel = function () {
		$location.path("");
	};
}