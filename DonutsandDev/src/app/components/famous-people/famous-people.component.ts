import { Component } from '@angular/core';
import { DevService } from '../../services/dev.service';
import { DevModel } from '../../models/dev-model';
import { FamousPersonRowComponent } from '../famous-person-row/famous-person-row.component';

@Component({
  selector: 'app-famous-people',
  standalone: true,
  imports: [FamousPersonRowComponent],
  templateUrl: './famous-people.component.html',
  styleUrl: './famous-people.component.css'
})
export class FamousPeopleComponent {
  DevResults:DevModel = {} as DevModel;
  display:boolean = true;
  constructor(private _devservice:DevService){}

  ngOnInit(){
    this._devservice.getDevs().subscribe((response:DevModel)=>{
      console.log(response);
      this.DevResults = response;
    });
  }

  toggleDisplay():void{
    this.display=!this.display;
  }

}
