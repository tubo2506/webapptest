// script.js
// Get the form element
var form = document.getElementById("newsletter-form");

// Add a submit event listener
form.addEventListener("submit", function(event) {
    // Prevent the default form submission
    event.preventDefault();

    // Get the email input value
    var email = document.getElementById("email").value;

    // Validate the email format
    if (!validateEmail(email)) {
        // Show an alert message if the email is invalid
        alert("Please enter a valid email address.");
    } else {
        // Send the subscription request to the server
        // You can use C# or any other server-side language to handle the request
        // Here we use a dummy URL for demonstration
        var url = "https://example.com/subscribe?email=" + email;

        // Use jQuery to make an AJAX request
        $.ajax({
            type: "POST",
            url: url,
            success: function(data) {
                // Show an alert message if the request is successful
                alert("Thank you for subscribing to our newsletter!");
            },
            error: function(error) {
                // Show an alert message if the request fails
                alert("Sorry, something went wrong. Please try again later.");
            }
        });
    }
});

// A function to validate the email format
function validateEmail(email) {
    // Use a regular expression to test the email
    var regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    return regex.test(email);
}
