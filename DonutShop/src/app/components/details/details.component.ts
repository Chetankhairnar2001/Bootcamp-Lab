import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DonutService } from '../../services/donut.service';
import { Donut } from '../../models/donut';
import { response } from 'express';

@Component({
  selector: 'app-details',
  standalone: true,
  imports: [],
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {
  constructor(private activateRoute:ActivatedRoute, private _donutService:DonutService){}
  DisplayDonut:Donut = {} as Donut;

  ngOnInit(){
    this.activateRoute.paramMap.subscribe((paramMap)=>{
      let id = Number(paramMap.get("id"));
      console.log(id);
      this._donutService.getDonutById(id).subscribe((response:Donut)=>{
        console.log(response);
        this.DisplayDonut = response;
      })
    })
  }

  addToCart(){
    this._donutService.addToCart(this.DisplayDonut);
    this._donutService.totalcalories+=this.DisplayDonut.calories;
    this._donutService.totalprices+=1;
  }

}
