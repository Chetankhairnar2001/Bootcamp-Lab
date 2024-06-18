import { Component } from '@angular/core';
import { DonutService } from '../../services/donut.service';
import { DonutModel } from '../../models/donut-model';
import { DonutItemComponent } from '../donut-item/donut-item.component';

@Component({
  selector: 'app-donuts',
  standalone: true,
  imports: [DonutItemComponent],
  templateUrl: './donuts.component.html',
  styleUrl: './donuts.component.css'
})
export class DonutsComponent {
  DonutsResult:DonutModel = {}  as DonutModel;
  display:boolean = true;
  constructor(private _donutService:DonutService){}

  ngOnInit(){
    this._donutService.getDonuts().subscribe((response:DonutModel)=>{
      console.log(response);
      this.DonutsResult = response;
    });  }

  toggleDisplay(){
    this.display = !this.display;
  }

}
