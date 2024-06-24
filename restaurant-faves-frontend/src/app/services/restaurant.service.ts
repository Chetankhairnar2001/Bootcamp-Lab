import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Order } from '../models/order';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  constructor(private http:HttpClient) { }
  url:string = "https://localhost:7235";

  getAllOrder(restaurant?:string, orderAgain?: boolean):Observable<Order[]>{
      //optmized way
      let params = new HttpParams();
      if (restaurant) {
        params = params.append('res', restaurant);
      }
      if (orderAgain !== undefined) {
        params = params.append('orderagain', orderAgain.toString());
      }
      return this.http.get<Order[]>(`${this.url}/api/Orders`, { params });
  }

  getById(id:number):Observable<Order>{
    return this.http.get<Order>(`${this.url}/api/Orders/${id}`);
  }

  addOrder(newOrder:Order):Observable<Order>{
    return this.http.post<Order>(`${this.url}/api/Orders`,newOrder);
  }

  updateOrder(updatedOrder:Order):Observable<void>{
    return this.http.put<void>(`${this.url}/api/Orders/${updatedOrder.id}`,updatedOrder);
  }

  deleteOrder(id:number):Observable<void>{ //since delete does not return anything
    return this.http.delete<void>(`${this.url}/api/Orders/${id}`);
  }

}
