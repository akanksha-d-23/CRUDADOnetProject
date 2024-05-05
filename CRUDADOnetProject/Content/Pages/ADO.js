var SaveEmployee = function () {
    var EmpId = $("#hdnEmpId").val();
    var Name = $("#txtName").val();
    var Email = $("#txtEmail").val();
    var Address = $("#txtAddress").val();
    var Mobile = $("#txtMobile").val();
    var City = $("#ddlCity").val();
    var State = $("#ddlState").val();

    model = {
        EmpId: EmpId,
        Name: Name,
        Email: Email,
        Address: Address,
        Moblie: Mobile,
        City: City,
        State: State
    };

    $.ajax({
        url: "/ADOnet/SaveEmployee",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
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