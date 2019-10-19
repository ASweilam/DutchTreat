


var theForm = $("#theForm");

theForm.hide();

var button = $("#BuyButton");

button.on("click", function () {
    console.log("Buying Item");
});


var productInfo = $(".product-props li");
productInfo.on("click", function () {
    console.log("You clicked on" + $(this).text);
});
