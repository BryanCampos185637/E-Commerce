window.onload = function () {
    GetAll(1);
    peticion.get('api/categoryApi/', (data) => {
        dom.select(data['data'], 'CategoryId', 'categoryId', 'name');
    })
    peticion.get('api/supplierApi/', (data) => {
        dom.select(data['data'], 'SupplierId', 'supplierId', 'name');
    })
}
function GetAll(page) {
    peticion.get('api/ProductAPI/' + page, function (result) {
        let data = result['data'];
        dom.table(data['items'], ['ID', 'NOMBRE', 'DESCRIPCION', 'PROVEEDOR', 'CATEGORIA'],
            ['productId', 'name', 'description', 'supplierName', 'categoryName'], 'productId', true, true, 'exampleModal');
        dom.panelPagination(data);
    })
}
function BackPage(page) {
    if (page > 0)
        GetAll(page);
}
function NextPage(page) {
    GetAll(page);
}
form.submit('frmRegister', function () {
    let product = {
        'ProductId': form.getTextInputValue('ProductId'),
        'Name': form.getTextInputValue('Name'),
        'CategoryId': form.getTextInputValue('CategoryId'),
        'SupplierId': form.getTextInputValue('SupplierId'),
        'Description': form.getTextInputValue('Description'),
        'Price': form.getTextInputValue('Price'),
        'Quantity': form.getTextInputValue('Quantity'),
    }
    if (form.validateEmpty('dataFrmProduct')) {
        if (document.getElementById('ProductId').value > 0) {
            peticion.put('api/ProductAPI/modificar', product, function (data) {
                if (Number.parseInt(data['data']) > 0) {
                    document.getElementById('btnCloseModal').click();
                    message.success('Se modifico el producto');
                    GetAll(1);
                    form.clearForm('dataFrmProduct');
                } else {
                    message.warning(data['message'])
                }
            });
        } else {
            peticion.post('api/ProductAPI/insertar', product, function (data) {
                if (Number.parseInt(data['data']) > 0) {
                    document.getElementById('btnCloseModal').click();
                    message.success('Se guardo el producto');
                    GetAll(1);
                    form.clearForm('dataFrmProduct');
                } else {
                    message.warning(data['message'])
                }
            });
        }
    }
})
function GetRegister(id) {
    peticion.get('api/ProductAPI/obtenerPorId?id=' + id, function (result) {
        if (result['data'] != null) {
            form.setDataForm(result['data'], ['ProductId', 'Name', 'CategoryId', 'SupplierId', 'Description', 'Price', 'Quantity'])
        } else {
            message.warning(result['message']);
        }
    })
}
function DeleteRegister(id) {
    message.confirmWarning('Eliminar registro!', 'Estas seguro que deseas eliminar el producto?', true, () => {
        peticion.delete('api/ProductAPI/delete/' + id, null, (data) => {
            if (Number.parseInt(data['data']) > 0) {
                document.getElementById('btnCloseModal').click();
                message.success('Se elimino el producto');
                GetAll(1);
            } else {
                message.warning(data['message'])
            }
        });
    })
}