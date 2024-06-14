import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuItem } from './models/menu-item';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CurrencyPipe],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'chirpus_pizza';
  menu_item: MenuItem[] = [
    {
      name: 'Chicken Fingures',
      category: 'Dinner',
      price: 11.99,
      vegetarian: false,
      soldOut: false,
    },
    {
      name: 'PiZZa',
      category: 'Dinner',
      price: 11.99,
      vegetarian: true,
      soldOut: false,
    },
    {
      name: 'Pepproni Pizza',
      category: 'Breakfast',
      price: 8.99,
      vegetarian: false,
      soldOut: false,
    },
    {
      name: 'Chicken Sandwich',
      category: 'Sides',
      price: 4.99,
      vegetarian: false,
      soldOut: true,
    },
    {
      name: 'Cinnamon Rolls',
      category: 'Dessert',
      price: 2.99,
      vegetarian: true,
      soldOut: false,
    },
    {
      name: 'Ice Cream',
      category: 'Dessert',
      price: 8.99,
      vegetarian: true,
      soldOut: true,
    }
  ];

  total: number = 0;
  addToOrder(price:number):void{
    this.total += price;
  }
  resetOrder():void{
    this.total = 0;
  }
}
