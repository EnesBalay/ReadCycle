/*price range*/

 $('#sl2').slider();

	var RGBChange = function() {
	  $('#RGB').css('background', 'rgb('+r.getValue()+','+g.getValue()+','+b.getValue()+')')
	};	
		
/*scroll to top*/

$(document).ready(function(){
	$(function () {
		$.scrollUp({
	        scrollName: 'scrollUp', // Element ID
	        scrollDistance: 300, // Distance from top/bottom before showing element (px)
	        scrollFrom: 'top', // 'top' or 'bottom'
	        scrollSpeed: 300, // Speed back to top (ms)
	        easingType: 'linear', // Scroll to top easing (see http://easings.net/)
	        animation: 'fade', // Fade, slide, none
	        animationSpeed: 200, // Animation in speed (ms)
	        scrollTrigger: false, // Set a custom triggering element. Can be an HTML string or jQuery object
					//scrollTarget: false, // Set a custom target element for scrolling to the top
	        scrollText: '<i class="fa fa-angle-up"></i>', // Text for element, can contain HTML
	        scrollTitle: false, // Set a custom <a> title if required.
	        scrollImg: false, // Set true to use image
	        activeOverlay: false, // Set CSS color to display scrollUp active point, e.g '#00FFFF'
	        zIndex: 2147483647 // Z-Index for the overlay
		});
	});
});


function LoginRegisterSection() {
    let form = document.getElementById("registerForm");
    var elements = form.elements;
    var isValid = true;
    for (var i = 0; i < elements.length; i++) {
        var element = elements[i];
        if (!element.checkValidity()) {
            var errorMessage = element.validationMessage;
            var errorElementId = element.id + "-error";
            var errorElement = document.getElementById(errorElementId);
            if (errorElement) {
                errorElement.textContent = errorMessage;
                errorElement.style.display = "block"; // Hata mesajýný görünür hale getir
            }
            isValid = false;
        }
    }

    if (isValid) {
        var formData = new FormData(form);
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/RegisterAjax");
        xhr.onload = function () {
            if (xhr.status === 200) {
                var response = JSON.parse(xhr.responseText);
                if (response.success === "true") {
                    // Baþarýlý durumda yapýlacak iþlemler
                    console.log("Kayýt baþarýlý!");
                } else {
                    // Hata durumunda yapýlacak iþlemler
                    console.log("Kayýt baþarýsýz!");
                }
            }
        };
        xhr.send(formData);
    }
}