import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { ActivatedRoute, Params } from '@angular/router';

@Component({
    selector: 'car-details',
    templateUrl: './car-details.component.html'
})
export class CarDetailsComponent {
    public CarDetails: CarDetails;
    private carId: number;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, private route: ActivatedRoute) {

        let sub = this.route.params.subscribe((params: Params) => {
            this.carId = params['id'];
            console.log("Current Car Id = " + this.carId)
        })

        http.get(baseUrl + 'api/SampleData/GetCarDetails?carId=' + this.carId)
            .subscribe(result => {
                this.CarDetails = result.json() as CarDetails;
            }, error => console.error(error));
    }
}

interface CarDetails {
    carName: string;
    make: string;
    model: string;
    hasSpareWheel: boolean;
}
