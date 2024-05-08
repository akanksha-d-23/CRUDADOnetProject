var SaveEmployee = function () {
    var EmpId = $("#SaveEmployee").val();
    var Name = $("#txtName").val();
    var Email = $("#txtEmail").val();
    var Passward = $("#passward").val();
    var Address = $("#txtAddress").val();
    var Mobile = $("#txtMobile").val();
    var City = $("#ddlCity").val();
    var State = $("#ddlState").val();

    model = {
        empId: EmpId,
        name: Name,
        email: Email,
        passward: Passward,
        address: Address,
        moblie: Mobile,
        city: City,
        state: State,
    };

    $.ajax({
        url: "/ADOnet/SaveEmployee",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            alert("Data has been saved successfully!!!");
            location.reload();
        },
        Error: function (response) {
            alert: (response.Message);
        }
    });

}

var List = function () {

}