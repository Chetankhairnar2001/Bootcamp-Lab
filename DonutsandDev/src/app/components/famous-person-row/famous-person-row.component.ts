import { Component, Input } from '@angular/core';
import { Complete } from '../../models/dev-model';

@Component({
  selector: 'tr[famous-row]',
  standalone: true,
  imports: [],
  templateUrl: './famous-person-row.component.html',
  styleUrl: './famous-person-row.component.css'
})
export class FamousPersonRowComponent {

  @Input() DisplayDev: Complete = {} as Complete;


}
