
var myApp = angular.module('myApp', []);

myApp.controller('ExcerisesJSCtrl', function () {
    ExerciseDropDown();
});


function ExerciseDropDown() {
    devices = 'one two three'.split(' ');

    selectedDevice = 'two';

    onChange(newValue) {
        console.log(newValue);
        this.selectedDevice = newValue;
        // ... do other stuff here ...
    };
};


//export class AppComponent {
//    devices = 'one two three'.split(' ');

//    selectedDevice = 'two';

//    onChange(newValue) {
//        console.log(newValue);
//        this.selectedDevice = newValue;
//        // ... do other stuff here ...
//    }
//};





