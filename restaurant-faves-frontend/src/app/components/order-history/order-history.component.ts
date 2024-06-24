import { Component } from '@angular/core';
import { RestaurantService } from '../../services/restaurant.service';
import { Order } from '../../models/order';
import { FormsModule } from '@angular/forms';
import { AddOrderFormComponent } from '../add-order-form/add-order-form.component';

@Component({
  selector: 'app-order-history',
  standalone: true,
  imports: [FormsModule, AddOrderFormComponent],
  templateUrl: './order-history.component.html',
  styleUrl: './order-history.component.css',
})
export class OrderHistoryComponent {
  constructor(private _restaurantService: RestaurantService) {}
  allOrders: Order[] = [];
  filterRestaurant: string = '';
  filterOrderAgain: boolean = false;

  ngOnInit() {
    //works as soon as website is created
    this.getAll();
  }

  getAll() {
    this._restaurantService
    .getAllOrder(
      this.filterRestaurant !== '' ? this.filterRestaurant : undefined,
      this.filterOrderAgain !== false ? this.filterOrderAgain : undefined
    )
    .subscribe((response: Order[]) => {
      console.log(response);
      this.allOrders = response;
    });
  }

  deleteOrder(o: Order) {
    this._restaurantService.deleteOrder(o.id).subscribe((response) => {
      this.getAll();
    });
  }

  addOrder(o: Order) {
    this._restaurantService.addOrder(o).subscribe((response: Order) => {
      this.getAll();
    });
  }

  updateOrder(o: Order) {
    this._restaurantService.updateOrder(o).subscribe((response) => {
      this.getAll();
    });
  }
}
