$(document).ready(function () {
    $('#checking').hide();
    $('#checking1').hide();
    $('#checking2').hide();
    $('#checking3').hide();

   // alert("aaaaaaaaaaaaaaa");
   

    $('#_date').datepicker({ dateFormat: 'mm/dd/yy' });




    $('#createKlass').on("click", function () {

        var name = $('VerifyInput').val();
        var degree = $('Degree').val();
        var Date = $('_date').val();



        if (name == '')
            $('#checking1').show();
        else if (degree == '')
            $('#checking2').show();
        else if (Date == '')
            $('#checking3').show();
        else
            @Url.Action("klassCreate","admin");





    });



    $('#VerifyInput').on("blur", function () {
          //alert("blur");
        var input = $('#VerifyInput').val();
        if (input == null)
            $('#result').text("Please Enter a Class Name");
        else {
            //alert(' Name = ' + input);
            $('#checking').show();
            $.getJSON("/Admin/CheckklassName?klassNameKey=" + input, function (data) {
                $('#checking').hide();
                if (data) {
                    $('#result').text("User Name is available");

                }
                else {
                    $('#result').text("User  already exists in database");
                }
            });
        }
    });

    
    $('#VerifyUser').on("blur", function () {
          alert("blur2");
        var input = $('#VerifyUser').val();
        if (input == null)
            $('#result').text("Please Enter a User Name");
        else {
            //alert(' Name = ' + input);
            $('#checking').show();
            $.getJSON("/Admin/CheckUserName?UserNameKey=" + input, function (data) {
                $('#checking').hide();
                if (data) {
                    $('#result').text("User Name is available");

                }
                else {
                    $('#result').text("User  already exists in database");
                }
            });
        }
    });



});