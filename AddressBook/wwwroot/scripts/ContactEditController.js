function ContactEditController($scope, $routeParams, $location, Contact) {
	$scope.contact = Contact.get({ ContactId: $routeParams.ContactId });

	$scope.save = function () {
		$scope.contact.$update({ ContactId: $scope.contact.ContactId }, function () {
			$location.path("/Contact/" + $routeParams.ContactId);
		});
	};

	$scope.cancel = function () {
		$location.path("/Contact/" + $routeParams.ContactId);
	};
}