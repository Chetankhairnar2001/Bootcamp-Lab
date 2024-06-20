import { Component } from '@angular/core';
import { DonutService } from '../../services/donut.service';
import { DonutModel } from '../../models/donut-model';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-donut',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './donut.component.html',
  styleUrl: './donut.component.css'
})
export class DonutComponent {
  constructor(private _donutService:DonutService){}

  DonutsResult:DonutModel={} as DonutModel;

  ngOnInit(){
    this._donutService.getDonuts().subscribe((response:DonutModel)=>{
      // console.log(response);
      this.DonutsResult = response;
    });  }


}
