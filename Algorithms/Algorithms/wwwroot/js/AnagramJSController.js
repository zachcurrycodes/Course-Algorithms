var myApp = angular.module('myApp', []);

function myAnagramCtrl(scope, http) {
    scope.displayResult = '';

    scope.update = function (text1, text2) {
        http({
            url: 'Anagram/Calculate',
            method: 'POST',
            data: {
                text1: text1,
                text2: text2
            },
            dataType: 'json',
            success: afterCalculate
        });
    };

    var afterCalculate = function (data) {
        scope.displayResult = response.data;
        //scope.anagramModel = data.data;
        //scope.displayResult = anagramModel.displayResult;
    }


};

