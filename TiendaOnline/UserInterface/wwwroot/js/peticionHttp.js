let link = window.location.protocol + '//' + window.location.host + '/';
let peticion = {
    get: function (url, callback) {
        url = link + url;
        fetch(url).then((resp) => {
            if (resp.ok) {
                return resp.json();
            } else {
                message.error(resp.statusText + ' status: ' + resp.status);
            }
        }).then(resp => {
            callback(resp);
        });
    },
    post: function (url, data, callback) {
        url = link + url;
        fetch(url, {
            method: 'POST',
            body: JSON.stringify(data),
            headers: {
                'Accept': 'aplication/json',
                'Content-Type': 'application/json'
            }
        }).then((resp) => {
            if (resp.ok) {
                return resp.json();
            } else {
                message.error(resp.statusText + ' status: ' + resp.status);
            }
        }).then(resp => {
            callback(resp);
        })
    },
    put: function (url, data, callback) {
        url = link + url;
        fetch(url, {
            method: 'PUT',
            body: JSON.stringify(data),
            headers: {
                'Accept': 'aplication/json',
                'Content-Type': 'application/json'
            }
        }).then((resp) => {
            console.log(resp);
            if (resp.ok) {
                return resp.json();
            } else {
                message.error(resp.statusText + ' status: ' + resp.status);
            }
        }).then(resp => {
            callback(resp);
        })
    },
    delete: function (url, data, callback) {
        url = link + url;
        fetch(url, {
            method: 'DELETE',
            body: JSON.stringify(data),
            headers: {
                'Accept': 'aplication/json',
                'Content-Type': 'application/json'
            }
        }).then((resp) => {
            if (resp.ok) {
                return resp.json();
            } else {
                message.error(resp.statusText + ' status: ' + resp.status);
            }
        }).then(resp => {
            callback(resp);
        })
    }
}