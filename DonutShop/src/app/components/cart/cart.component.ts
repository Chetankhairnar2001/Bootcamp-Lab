import { Component } from '@angular/core';
import { DonutService } from '../../services/donut.service';
import { Donut } from '../../models/donut';
import { RouterLink } from '@angular/router';
import { DonutModel } from '../../models/donut-model';

@Component({
  selector: 'app-cart',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './cart.component.html',
  styleUrl: './cart.component.css'
})
export class CartComponent {
constructor(private _donutService:DonutService){}

  getCart():Donut[]{
    return this._donutService.cart;
  }

  totalcalories = this._donutService.totalcalories;
  totalprices = this._donutService.totalprices;

  deleteItem(i:Donut){
    this.totalcalories-=i.calories;
    this.totalprices-=1;
    this._donutService.removeFromCart(i);
  }

  getCartDistinct():Donut[]{ //references mapped version of array
    let map = new Map(this._donutService.cart.map(pos=> [pos.id,pos] ));
    return [...map.values()];
  }

  getItemQuantity(i:Donut):number{ //references to original array
    return this._donutService.cart.reduce((total:number, current:Donut) => current == i ? total + 1 : total, 0);
  }

}
