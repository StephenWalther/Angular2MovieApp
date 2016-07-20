
import {Component} from '@angular/core';
import {MessageComponent} from '../message/message.component';
import {TaxService} from '../shared/tax.service';
import {Http} from '@angular/http';


@Component({
    moduleId: module.id,
    templateUrl: './home.component.html',
    directives: [MessageComponent],
    providers: [TaxService]
})
export class HomeComponent {

 
    public movies;

    constructor(private http: Http) {
        this.http.get('/api/movies').toPromise().then((response) => {
            this.movies = response.json();
        });
    }

}