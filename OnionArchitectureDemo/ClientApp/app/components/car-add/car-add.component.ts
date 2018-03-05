import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
    selector: 'car-add',
    templateUrl: './car-add.component.html'
})
export class CarAddComponent {

    public car: CarAdd;
    private baseUrl: string;
    private http: Http;
    private router: Router;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, router: Router) {
        this.http = http;
        

        this.baseUrl = baseUrl;
        this.router = router;

        http.get(baseUrl + 'api/Car/Create')
            .subscribe(result => {
                var model = result.json();
                this.car = model;
            }, error => console.error(error));            
    }

    onSubmit() {
        
        this.http.post(this.baseUrl + 'api/Car/Create', this.car)
            .subscribe(result => {
                this.router.navigate(['/cars'])
            }, error => console.error(error));
    }
}

interface CarAdd {
    price: number;
    make: string;
    model: string;
}