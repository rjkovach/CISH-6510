(function () {
	'use strict';
	
	angular
		.module('addressBookApp.core')
		.factory('contactService', contactService);
	
	contactService.$inject = ['$resource'];
	
	function contactService($resource) {
		return $resource('/api/contacts/:contactId', { contactId: '@contactId' });
	}
})();