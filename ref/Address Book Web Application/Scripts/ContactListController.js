function ContactListController($scope, $location, Contact) {
	$scope.contacts = Contact.query();
	$scope.opened = undefined;

	$scope.open = function (contact) {
		$scope.opened = contact;
		$location.path("/Contact/" + contact.ContactId);
	};

	$scope.close = function () {
		$scope.opened = undefined;
	};

	$scope.isOpenClass = function (contact) {
		if ($scope.opened === contact)
			return "selected";

		return "";
	};

	$scope.add = function () {
		$location.path("/Contact/Add");
	};
}