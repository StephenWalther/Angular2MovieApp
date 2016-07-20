import { provideRouter, RouterConfig } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import {ProductListComponent} from './product-list/product-list.component';
import {ProductDetailsComponent} from './product-details/product-details.component';


const routes: RouterConfig = [
    { path: '', component: HomeComponent },
    { path: 'about', component: AboutComponent },
    { path: 'product-list', component: ProductListComponent },
    { path: 'product-details/:id', component: ProductDetailsComponent }
];

export const APP_ROUTER_PROVIDERS = [
    provideRouter(routes)
];