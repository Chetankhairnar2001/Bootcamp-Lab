import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DonutModel } from '../models/donut-model';
import { Donut } from '../models/donut';

@Injectable({
  providedIn: 'root'
})
export class DonutService {

  constructor(private http: HttpClient) { }
  totalcalories:number = 0;
  totalprices:number = 0;

  getDonuts():Observable<DonutModel>{
    return this.http.get<DonutModel>('https://grandcircusco.github.io/demo-apis/donuts.json');
  }

  getDonutById(id:number):Observable<Donut>{
    return this.http.get<Donut>(`https://grandcircusco.github.io/demo-apis/donuts/${id}.json`);
  }

  cart:Donut[] = [];

  addToCart(d:Donut):void{
    this.cart.push(d);
    console.log(this.cart);
  }

  removeFromCart(d:Donut):void{
    let index = this.cart.findIndex(p=>p==d);
    this.cart.splice(index,1);
  }

}
