import { Routes } from '@angular/router';
import { DonutComponent } from './components/donut/donut.component';
import { DetailsComponent } from './components/details/details.component';
import { CartComponent } from './components/cart/cart.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

export const routes: Routes = [
    {path:"",redirectTo:"/donuts",pathMatch:'full'},
    {path:"donuts",component:DonutComponent},
    {path:"donuts/:id",component:DetailsComponent},
    {path:"cart",component:CartComponent},
    {path:"**",component:NotFoundComponent}
];
