import {Component} from '@angular/core';


@Component({
    moduleId: module.id,
    templateUrl: './message.component.html',
    selector: 'my-message',
    styleUrls: ['./message.component.css']
})
export class MessageComponent {

    public doSomething() {
        
    }


    public message = 'I like Pizza';

}


