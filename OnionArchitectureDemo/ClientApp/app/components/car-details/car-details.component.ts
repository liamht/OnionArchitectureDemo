import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
    selector: 'car-details',
    templateUrl: './car-details.component.html'
})
export class CarDetailsComponent {
    public car: CarDetails;
    private carId: number;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, private route: ActivatedRoute) {

        let sub = this.route.params.subscribe((params: Params) => {
            this.carId = params['id'];
            console.log("Current Car Id = " + this.carId)
        })

        http.get(baseUrl + 'api/Car/GetDetails?carId=' + this.carId)
            .subscribe(result => {
                this.car = result.json() as CarDetails;
            }, error => console.error(error));
    }
}

interface CarDetails {
    price: number;
    preSalePrice: number;
    make: string;
    model: string;
}
