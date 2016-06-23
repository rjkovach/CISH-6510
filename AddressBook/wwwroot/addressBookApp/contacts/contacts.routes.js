(function () {
	'use strict';
	
	angular
		.module('addressBookApp.contacts')
		.config(configureRoutes);
	
	configureRoutes.$inject = ['$routeProvider'];
	
	function configureRoutes($routeProvider) {
		var templateUrlBase = '/addressBookApp/contacts/';
		
		$routeProvider
			.when('/contacts', {
				templateUrl: templateUrlBase + 'index.html',
				controller: 'ContactsController',
				controllerAs: 'vm'
			})
			.when('/contacts/:contactId', {
				templateUrl: templateUrlBase + 'detail.html',
				controller: 'ContactDetailController',
				controllerAs: 'vm'
			})
			.otherwise({
				redirectTo: '/contacts'
			});
	}
})();