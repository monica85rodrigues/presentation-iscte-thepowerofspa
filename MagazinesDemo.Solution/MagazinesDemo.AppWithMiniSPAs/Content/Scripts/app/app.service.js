window.app = window.app || {};

window.app.service = (function () {

    var baseMagazineUri = '/api/magazines/';
    var baseAuthorsUri = '/api/authors/';

    var serviceUrls = {
        getMagazines: function () { return baseMagazineUri + "GetMagazines"; },
        addMagazine: function () { return baseMagazineUri + "AddMagazine" },
        getAuthors: function () { return baseAuthorsUri + "GetAuthors" },
        addAuthor: function () { return baseAuthorsUri + "AddAuthor" }
    }

    function ajaxRequest(type, url, data) {
        var options = {
            url: url,
            headers: {
                Accept: "application/json"
            },
            contentType: "application/json",
            cache: false,
            type: type,
            data: data ? ko.toJSON(data) : null
        };
        return $.ajax(options);
    }

    return {
        getMagazines: function () {
            return ajaxRequest('GET', serviceUrls.getMagazines());
        },
        addMagazine: function (magazine) {
            return ajaxRequest('POST', serviceUrls.addMagazine(), magazine);
        },
        getAuthors: function() {
            return ajaxRequest('GET', serviceUrls.getAuthors());
        },
        addAuthor: function(author) {
            return ajaxRequest('POST', serviceUrls.addAuthor(), author);
        }
    };

})();