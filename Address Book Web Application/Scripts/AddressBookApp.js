angular.module("AddressBookApp", ["ContactService"]).config(["$routeProvider", function ($routeProvider) {
	$routeProvider.when("/Contact/Add", {
		templateUrl: "/views/contact/edit.html",
		controller: ContactAddController
	});
	$routeProvider.when("/Contact/:ContactId", {
		templateUrl: "/views/contact/detail.html",
		controller: ContactDetailController
	});
	$routeProvider.when("/Contact/:ContactId/Edit", {
		templateUrl: "/views/contact/edit.html",
		controller: ContactEditController
	});
}]);