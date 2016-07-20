import {Injectable} from '@angular/core';


@Injectable()
export class TaxService {

    public calculate(amount: number) {
        return amount * .08;
    }

}