function ContactDetailController($scope, $routeParams, $location, Contact) {
	$scope.contact = Contact.get({ ContactId: $routeParams.ContactId });

	$scope.edit = function () {
		$location.path("/Contact/" + $routeParams.ContactId + "/Edit");
	};

	$scope.delete = function () {
		if (confirm("Are you sure you want to delete " + $scope.contact.FullName() + "?")) {
			$scope.contact.$delete({ ContactId: $scope.contact.ContactId });
			$location.path("");
		}
	};

	$scope.done = function () {
		$location.path("");
	};
}