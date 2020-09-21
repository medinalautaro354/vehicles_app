// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onload = () => {
    getVehicles();
}

const getVehicles = () => {
    $.ajax({
        method: "GET",
        url: "/vehicles",
        success: function (response) {

            if (response.length > 0) {

                response.forEach(vehicle => {
                    let row = `<tr id=${vehicle.id}>
                         <td>${vehicle.licensePlate}</td>
                        <td>${vehicle.brand}</td>
                        <td>${vehicle.numberOfDoors}</td>
                        <td>${vehicle.owner}</td>
                    </tr>`;

                    $('#table tbody').append(row);

                })
            }
            else {
                let row = `<tr>
                        <td>No</td>
                        <td>hay</td>
                        <td>vehiculos</td>
                        <td>cargados</td>
                    </tr>`;

                $('#table tbody').append(row);
            }
        }
    })
}