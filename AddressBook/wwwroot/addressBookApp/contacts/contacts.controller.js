(function () {
	'use strict';
	
	angular
		.module('addressBookApp.contacts')
		.controller('ContactsController', ContactsController);
	
	ContactsController.$inject = ['$scope', '$routeParams', '$location', 'contactService'];
	
	function ContactsController($scope, $routeParams, $location, contactService) {
		var vm = this;
		vm.contacts = [];
		vm.opened = {};

		vm.open = open;
		vm.close = close;
		vm.toggle = toggle;
		vm.isOpenClass = isOpenClass;
		
		activate();
		
		function activate() {
			return getContacts();
		}
		
		function getContacts() {
			return contactService
				.query({}, function (contacts) {
					vm.contacts = contacts;
					
					return vm.contacts;
				});
		}

		function open(contact) {
			vm.opened = contact;
			$location.path("/contacts/" + contact.ContactId);
		}

		function close() {
			vm.opened = {};
			$location.path("/contacts/");
		}

		function toggle(contact) {
			if (vm.opened === contact)
				close();
			else
				open(contact);
		}

		function isOpenClass(contact) {
			if (vm.opened === contact)
				return "selected";

			return "";
		}
	}
})();