window.app = window.app || {};

window.app.authorsVm = function() {

    var self = this;

    self.authors = ko.observableArray([]);
    self.author = ko.observable(new _buildAuthor());
    self.addMode = ko.observable(false);


    self.init = function () {

        window.app.service.getAuthors().done(function(authors) {
            self.authors(authors);
        });

        ko.applyBindings(self);
    };

    self.addNewAuthor = function() {
        self.addMode(true);
    };

    self.cancel = function() {
        self.addMode(false);
        self.author(new _buildAuthor());
    };

    self.backToList = function() {
        self.addMode(false);
    };

    self.addAuthor = function() {
        app.service.addAuthor(self.author()).done(function() {
            self.authors.push(self.author());
            self.addMode(false);
            self.author(new _buildAuthor());
        });
    };

    function _buildAuthor(name) {
        this.Name = ko.observable(name ? name: "");
    };

};