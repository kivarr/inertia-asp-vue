import route from 'ziggy-js';
const Ziggy = {
    routes: {
        "login": {
          "uri": "Home/Login",
          "methods": [
              "GET",
              "HEAD"
            ],
            "domain": null
        },
        "login.attempt": {
            "uri": "Home/Login",
            "methods": [
                "POST",
                "HEAD"
            ],
            "domain": null
        },
        "logout": {
            "uri": "Home/Logout",
            "methods": [
                "POST",
                "HEAD"
            ],
            "domain": null
        },
        
        "organizations": {
            "uri": "Home/Orgs",
            "methods": [
                "GET",
                "HEAD"
            ],
            "domain": null
        },
        "organizations.create": {
            "uri": "Home/Orgs/Create",
            "methods": [
                "GET",
                "HEAD"
            ],
            "domain": null
        },
        "organizations.store": {
            "uri": "Home/Orgs",
            "methods": [
                "POST",
                "HEAD"
            ],
            "domain": null
        },
        "organizations.edit": {
            "uri": "Home/Orgs/{org}/Edit",
            "methods": [
                "GET",
                "HEAD"
            ],
            "domain": null
        },
        "organizations.update": {
            "uri": "Home/Orgs/{organization}",
            "methods": [
                "PUT",
                "HEAD"
            ],
            "domain": null
        },
        "organizations.destroy": {
            "uri": "Home/Orgs/{organization}",
            "methods": [
                "DELETE",
                "HEAD"
            ],
            "domain": null
        },
        "organizations.restore": {
            "uri": "Home/Orgs/{organization}/restore",
            "methods": [
                "GET",
                "HEAD"
            ],
            "domain": null
        },
    },
    url: 'https://localhost:3000',
    port: true,
    defaults: {
        
    }
};

const routeHelper = (name: any, params: {} = {}, absolute = false, config = Ziggy) => {
    return route(name, params, absolute, config);
}

export { Ziggy, routeHelper };