angular.module("ContactService", ["ngResource"]).factory("Contact", function ($resource) {
	var ContactService = $resource("/api/contacts/:ContactId", {}, { update: { method: "PUT" } });

	ContactService.prototype.FullName = function () {
		var fullName = this.FirstName;

		if (this.MiddleName !== null)
			fullName += " " + this.MiddleName;

		fullName += " " + this.LastName;

		if (this.Suffix !== null)
			fullName += ", " + this.Suffix;

		return fullName;
	};

	ContactService.prototype.SortName = function () {
		var sortName = this.LastName;

		if (this.Suffix !== null)
			sortName += " " + this.Suffix;

		sortName += ", " + this.FirstName;

		if (this.MiddleName !== null)
			sortName += " " + this.MiddleName;

		return sortName;
	};

	return ContactService;
});