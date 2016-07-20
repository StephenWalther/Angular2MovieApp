import {Component} from '@angular/core';
import {ActivatedRoute} from '@angular/router';

@Component({
    moduleId: module.id,
    templateUrl: './product-details.component.html'
})
export class ProductDetailsComponent {
    public productId;

    constructor(route: ActivatedRoute) {
        this.productId = route.snapshot.params['id'];
    }

}