
function ValidateNumber(event) {

    if (event.shiftKey && ((event.keyCode >= 48 && event.keyCode <= 57)
            || (event.keyCode >= 186 && event.keyCode <= 222) || (event.keyCode >= 35 && event.keyCode <= 38)))// ||(event.keyCode!=51 ||event.keyCode!=52 || event.keyCode!=53 || event.keyCode!=55)
    {
        // Ensure that it is a number and stop the Special chars
        event.preventDefault();
    }
    else if ((event.shiftKey || event.ctrlKey) && (event.keyCode > 34 && event.keyCode < 40)) {
        // let it happen, don't do anything
    }
    else {
        // Allow only backspace , delete, numbers            || event.keyCode == 39     
        if (event.keyCode == 9 || event.keyCode == 46 || event.keyCode == 8 || event.keyCode == 37 || event.keyCode == 45 //|| event.keyCode==44  for , comma
                || (event.keyCode >= 48 && event.keyCode <= 57)) {
            // let it happen, don't do anything
        }
        else {
            // Ensure that it is a number and stop the key press
            event.preventDefault();
        }
    }
}