import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public cars: Car[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/GetCars').subscribe(result => {
            this.cars = result.json() as Car[];
        }, error => console.error(error));
    }
}

interface Car {
    carName: string;
    make: string;
    model: string;
    hasSpareWheel: boolean;
    salesListingId: number;
}
