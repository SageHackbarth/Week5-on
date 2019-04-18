function searchEmployee() {
    var search = $("#searchString").val();

    $.ajax({
        url: "Search",
        data: { searchString: search }
    }).done(function(data) {
        $("#employeeId").val(data.EmployeeId);
        $("#employeeName").val(data.EmployeeName);
        $("#employeeEmail").val(data.Email);
        $("#employeeRole").val(data.Role);
    });
}

function updateEmployee() {
    var employeeId = $("#employeeId").val();
    var employeeName = $("#employeeName").val();
    var employeeEmail = $("#employeeEmail").val();
    var employeeRole = $("#employeeRole").val();

    alert("yep");

    $.ajax({
        url: "UpdateEmployee",
        dataType: "json",
        data: {
            EmployeeId: employeeId,
            EmployeeName: employeeName,
            Role: employeeRole,
            Email: employeeEmail
        }
    }).done(function(data) {
        if (data) {
            $("#successMessage").removeClass("hidden").addClass("visible");
        } else {
            $("#errorMessage").removeClass("hidden").addClass("visible");
        }
    });
}