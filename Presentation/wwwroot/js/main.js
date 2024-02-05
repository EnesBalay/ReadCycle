/*price range*/

$('#sl2').slider();

var RGBChange = function () {
    $('#RGB').css('background', 'rgb(' + r.getValue() + ',' + g.getValue() + ',' + b.getValue() + ')')
};

/*scroll to top*/

$(document).ready(function () {
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
                errorElement.style.display = "block";
            }
            isValid = false;
        }
    }

    if (isValid) {
        var errors = document.querySelectorAll(".text-danger");
        errors.forEach((item) => {
            item.style.display = "none";
        })
        let postData = {
            Name: document.getElementById("Name").value,
            PhoneNumber: document.getElementById("PhoneNumber").value,
            EmailAddress: document.getElementById("RegisterEmailAddress").value,
            Password: document.getElementById("Password").value
        }
        $.ajax({
            type: "POST",
            url: "/Register/RegisterAjax",
            data: postData,
            success: function (response) {
                Swal.fire({
                    icon: "success",
                    title: "Kay�t Ger�ekle�ti!",
                    text: "Kay�t ba�ar�l� bir �ekilde ger�ekle�ti!"
                });
                console.log("Sunucudan d�nen yan�t: ", response);
            },
            error: function (xhr, status, error) {
                console.error("Bir Hata Olu�tu!");
                Swal.fire({
                    icon: "error",
                    title: "Bir Hata Olu�tu!",
                    text: "Bir hata olu�tu l�tfen tekrar deneyiniz!"
                });
                console.error("Hata detay�: ", error);
            }
        });
    }
}