// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var bottomButton = document.getElementById("bottomButton");
var isBouncing = false;

document.addEventListener("scroll", function () {
  var scrollPosition = window.scrollY;
  var windowHeight = window.innerHeight;
  var documentHeight = document.body.scrollHeight;

  // Calculate how close the user is to the bottom
  var scrollPercentage = (scrollPosition + windowHeight) / documentHeight;

  if (scrollPercentage > 0.98) {
    // When the user is 95% close to the bottom, show the button
    bottomButton.style.animation= "fadeIn 1.5s ease forwards, bounce 0.5s infinite alternate";
    bottomButton.style.display = "block";

    // Start bouncing animation if not already started
    if (!isBouncing) {
      bottomButton.style.animationPlayState = "running";
      isBouncing = true;
    }
  } else if (scrollPercentage < 0.98) {
    // Hide the button
      bottomButton.style.animation = "fadeOut 0.35s ease forwards";
   // bottomButton.style.display = "none";

    // Reset bouncing animation
    //bottomButton.style.animationPlayState = "paused";
    isBouncing = false;
  }
});

