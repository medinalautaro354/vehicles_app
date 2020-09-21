window.onload = () => {
    loadNumbersOfDoors();
    loadBrands();
    loadOwners();
}

$(function () {
	$('#form-vehicle').on('submit', function (event) {
		event.preventDefault();

        var data = {};
        $('input').each(function () {
            data[this.name] = this.value;
        });

        $('select').each(function () {
            data[this.name] = this.value;
        });

        postVehicle(data);
	});
});

const postVehicle = (data) => {
    $.ajax({
        method: "POST",
        contentType: 'application/json',
        data: JSON.stringify(data),
        dataType: 'json',
        url: "/vehicles",
        success: function (response) {
            alert('Se guardo exitosamente!');
            cleanForm();

        }
    })
}

const cleanForm = () => {
    $('#licensePlate').val('')
    $('#brand').val(0);
    $('#numberOfDoors').val(3);
    $('#owner').val('');
}

const loadNumbersOfDoors = () => {
    let numberOfDoors = [3, 5];

    numberOfDoors.forEach((item) => {
        let row = `<option value=${item}>${item}</option>`;
        $('#numberOfDoors').append(row)
    })
}

const loadBrands = () => {
    $.ajax({
        method: "GET",
        url: "/brands",
        success: function (response) {

            response.forEach((item) => {
                let row = `<option value=${item.id}>${item.name}</option>`;
                $('#brand').append(row);
            })
        }
    })
}

const loadOwners = () => {
    getOwnersByPage(1);
    getOwnersByPage(2);
    getOwnersByPage(3);
}

const getOwnersByPage = (page) => {
    $.ajax({
        method: "GET",
        url: `https://reqres.in/api/users?page=${page}`,
        success: function (response) {

            if (response.data.length > 0) {
                response.data.forEach((item) => {
                    let row = `<option value='${item.first_name} ${item.last_name}'>${item.first_name} ${item.last_name}</option>`;
                    $('#owner').append(row);
                })
            }
        }
    })
}

