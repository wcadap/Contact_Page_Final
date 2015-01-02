contactApp.config(['$routeProvider', function ($routeProvider) {
    
    $routeProvider.when('/', {
        templateUrl: "/app/Home/home.html"
    }),

    $routeProvider.when('/about', {
        templateUrl: "app/Home/about.html"
    }),

    $routeProvider.when('/mycontacts', {
        templateUrl: "app/contact/html/contactsList.html",
        controller: "contactController"
    }),

    $routeProvider.when('/mycontacts/newcontact', {
        templateUrl: "app/contact/html/contactForm.html",
        controller: "contactAddController"
    }),
    
    $routeProvider.when('/mycontacts/:id', {
        templateUrl: "app/contact/html/contactForm.html",
        controller: "contactEditController"
    }),

    $routeProvider.otherwise({
        redirectTo: '/'
    });

}]);
