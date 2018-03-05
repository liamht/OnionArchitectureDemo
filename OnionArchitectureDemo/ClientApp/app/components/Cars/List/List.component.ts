import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'car-list',
    templateUrl: './List.component.html'
})
export class CarListComponent {
    public cars: Car[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Car/GetAll').subscribe(result => {
            this.cars = result.json() as Car[];
        }, error => console.error(error));
    }
}

interface Car {
    carName: string;
    salesListingId: number;
}
