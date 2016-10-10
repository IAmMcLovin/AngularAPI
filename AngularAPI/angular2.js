var myApp =
angular.module ('myApp', ['store-products']);


var gems = null;

myApp.controller('myController', ['$http', '$scope', '$log', 'ProductService','Gravatar', function ($http, $scope, $log, ProductService, Gravatar) {
       $scope.model =[];
    
    ProductService.get().then(
                    function (response) {
                        $scope.model = response.data;
                    },
                    function (response) {
                        $scope.error = true;
                        $log.log("could not load products!" + response.status)
                    })
        $scope.gravatarUrl = function (email){
            return Gravatar (email);
        }
}]);

myApp.controller("ReviewController", function($http){
    this.review = {};
    this.addReview = function (product) {


        $http.post("api/reviews", product);

        if(!product.reviews)
            product.reviews = [];
        product.reviews.push(this.review);
        this.review ={};
    };
});


myApp.directive('myExample', function () {
    return { template: "<div>My Example Directive Here.</div>" };
});