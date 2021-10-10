let dom = {
    table: function (data,head, body, key, optionEdit = true, optionDelete = true, idModal='') {
        let content = '', i = 0, j = 0, objActual, propertyActual;
        //pinta la cabezera de la tabla
        content += '<tr>';
        while (i < head.length) {
            content += '<th>' + head[i] + '</th>';
            i++;
        }
        if (optionDelete || optionEdit) content += '<th>ACCIONES<th>';
        content += '</tr>';
        document.getElementById('tbHead').innerHTML = content;
        //pinta el cuerpo de la tabla
        i = 0; content = '';
        while (i < data.length) {
            content += '<tr>';
            objActual = data[i];
            for (j = 0; j < body.length; j++) {
                propertyActual = body[j];
                content += '<td>' + objActual[propertyActual] + '</td>';
            }
            if (optionDelete || optionEdit) {
                content += '<td>';
                if (optionEdit) {
                    if (idModal != '') {
                        content += '<a class="btn-sm btn-success mr-2" data-bs-toggle="modal" data-bs-target="#' + idModal + '" onclick="GetRegister(' + objActual[key] + ')"><i class="fas fa-edit"></i></a> ';
                    } else {
                        content += '<a class="btn-sm btn-success mr-2" onclick="GetRegister(' + objActual[key] + ')"><i class="fas fa-edit"></i></a> ';
                    }
                }
                if (optionDelete) {
                    content += '<a class="btn-sm btn-danger mr-2" onclick="DeleteRegister(' + objActual[key] + ')"><i class="fas fa-trash"></i></a>';
                }
                content += '</td>';
            }
            content += '</tr>';
            i++;
        }
        if (data.length > 0)
            document.getElementById('tbBody').innerHTML = content;
    },
    panelPagination: function (data, idTag = 'panelControl') {
        let content = '';
        content += '<nav aria-label="Page navigation example">';
        content += '<ul class="pagination justify-content-center" >';
        content += '<li class="page-item" id="btnBackPage">';
        content += '<a class="page-link" href="#" onclick="BackPage(' + Number.parseInt(data['page']-1) + ')"><<</a>';
        content += '</li>';
        content += '<li class="page-item">';
        content += '<a class="page-link" href="#">Pagina ' + data['page'] + ' de ' + data['pages'] + '</a>';
        content += '</li>';
        content += '<li class="page-item" id="btnNextPage">';
        content += '<a class="page-link"  href="#" onclick="NextPage(' + Number.parseInt(data['page'] + 1) + ')">>></a>';
        content += '</li>';
        content += '</ul>';
        content += '</nav>';
        //pintamos
        if (data['items'].length > 0) {
            document.getElementById(idTag).innerHTML = content;
            if (data['page'] == data['pages']) {
                document.getElementById('btnNextPage').disabled = true;
            }
            if (data['page'] == 1) {
                document.getElementById('btnBackPage').disabled = true;
                }
        }
    },
    cardProduct: function (data,idTag) {
        let content = '';
        for (var i = 0; i < data.length; i++) {
            let objActual = data[i];
            content += '<div class="col-md-4 col-sm-12 col-lg-3 mt-4">'
            content += '<div class="card">'
            content += '<div class="card-body">'
            content += '<h4 class="h4 mt-3">' + objActual['name'] + '</h4>'
            content += '<img src="/img/simbolo.png" class="img-fluid mt-3" />'
            content += '<p>Descripcion: ' + objActual['description'] + '</p>'
            content += '<p>Categoria: ' + objActual['categoryName'] + '</p>'
            content += '<p>Precio: $' + objActual['price'] + '</p>'
            content += '<p>Disponible: ' + objActual['quantity'] + '</p>'
            //botonera
            /*
            content += '<nav aria-label="Page navigation example">';
            content += '<ul class="pagination justify-content-center" >';
            content += '<li class="page-item" >';
            content += '<a class="page-link" href="#">-</a>';
            content += '</li>';
            content += '<li class="page-item">';
            content += '<a class="page-link" href="#">Agregar a carrito</a>';
            content += '</li>';
            content += '<li class="page-item">';
            content += '<a class="page-link"  href="#">+</a>';
            content += '</li>';
            content += '</ul>';
            content += '</nav>';
            */
            content += '</div>'
            content += '</div>'
            content += '</div>'
            document.getElementById(idTag).innerHTML = content;
        }
    },
    select: function (data, idTag, val, text) {
        let content = '<option value="">Selecciona una opción</option>';
        for (var i = 0; i < data.length; i++) {
            let objActual = data[i];
            content += '<option value="' + objActual[val] + '">' + objActual[text] + '</option>';
            document.getElementById(idTag).innerHTML = content;
        }
    }
}
let form = {
    submit: function (idTag, callback) {
        document.getElementById(idTag).onsubmit = function (event) {
            event.preventDefault();
            callback();
        }
    },
    getTextInputValue: function (idTag) {
        return document.getElementById(idTag).value;
    },
    setTextInput: function (idTag, val) {
        document.getElementById(idTag).value = val;
    },
    validateEmpty: function (classCss) {
        let controls = document.getElementsByClassName(classCss);
        let result = true, idTextError = '', span = document.createElement('span');
        for (let i = 0; i < controls.length; i++) {
            idTextError = 'txtError' + controls[i].name;
            if (controls[i].value.trim() == '') {
                result = false;
                if (document.getElementById('txtError' + controls[i].name) == undefined) {
                    span.id = idTextError;
                    span.className = 'text-danger'
                    controls[i].after(span);
                }
            } else {
                controls[i].style.boderColor = '#ccc';
                if (document.getElementById('txtError' + controls[i].name) != undefined)
                    document.getElementById('txtError' + controls[i].name).remove();
            }
        }
        return result;
    },
    catchDataWithJquery: function (nameClass) {
        let frmData = new FormData();
        let textBox = document.getElementsByClassName(nameClass);
        for (let i = 0; i < textBox.length; i++) {
            frmData.append(textBox[i].name, textBox[i].value);
        }
        return frmData;
    },
    setDataForm: function (jsonData, arrayProperties) {
        for (let i = 0; i < arrayProperties.length; i++) {
            //verificamos si existe el input con el name
            let input = document.getElementById(arrayProperties[i]);
            if (input != undefined) {
                //cambiamos la primer letra a minuscula
                let firstCharacter = arrayProperties[i].charAt(0).toLowerCase(), property = arrayProperties[i];
                property = firstCharacter + property.substring(1, property.length);
                input.value = jsonData[property];
            } else {
                message.warning('No se encontro el input con el id ' + arrayProperties[i]);
            }
        }
    }
}
let message = {
    confirmWarning: function (title, message, showButtonCancel = true, callback) {
        Swal.fire({
            title: title,
            text: message,
            icon: 'warning',
            showCancelButton: showButtonCancel,
            confirmButtonColor: '#162967',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Ok!',
            cancelButtonText: 'Cancelar!'
        }).then((result) => {
            if (result.isConfirmed) {
                callback();
            }
        })
    },
    confirmSuccess: function (title, message, showButtonCancel = true, callback) {
        Swal.fire({
            title: title,
            text: message,
            icon: 'success',
            showCancelButton: showButtonCancel,
            confirmButtonColor: '#162967',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Ok!',
            cancelButtonText: 'Cancelar!'
        }).then((result) => {
            if (result.isConfirmed) {
                callback();
            }
        })
    },
    success: function (message) { Swal.fire({ position: "center", icon: 'success', title: message, showConfirmButton: false, timer: 2000, }) },
    error: function (message) { Swal.fire({ position: "center", icon: 'error', title: message, showConfirmButton: true, /*timer: 1500,*/ }) },
    warning: function (message) { Swal.fire({ position: "center", icon: 'warning', title: message, showConfirmButton: true, /*timer: 1500,*/ }) }
}
