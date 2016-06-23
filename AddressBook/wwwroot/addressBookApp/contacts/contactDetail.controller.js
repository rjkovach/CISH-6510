(function () {
	'use strict';
	
	angular
		.module('addressBookApp.contacts')
		.controller('ContactDetailController', ContactDetailController);
	
	ContactDetailController.$inject = ['$routeParams', 'contactService'];
	
	function ContactDetailController($routeParams, contactService) {
		var vm = this;
		vm.contact = {};
		
		activate();
		
		function activate() {
			return getContact($routeParams.contactId);
		}
		
		function getContact(contactId) {
			return contactService
				.get({ contactId: contactId }, function (contact) {
					vm.contact = contact;
					
					return vm.contact;
				})
		}
	}
})();