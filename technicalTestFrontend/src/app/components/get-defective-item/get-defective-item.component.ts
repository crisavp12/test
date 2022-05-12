import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TestService } from 'src/app/services/test.service';
import { ItemModel } from '../../models/item.model';

@Component({
  selector: 'app-get-defective-item',
  templateUrl: './get-defective-item.component.html'
})
export class GetDefectiveItemComponent implements OnInit {
  
  items?:ItemModel[];

  constructor(private router:Router,
              private service: TestService) {
    this.GetItems();    
  }

  ngOnInit(): void {
  }

  goStorage(){
    this.router.navigate(['/storage'])
  }

  GetItems(){
    this.service.GetItems(1)
       .subscribe((data:any)=>{
         this.items = data;
         console.log(this.items);
         console.log('ya cargaron los items');
         
       });
   }

   ChangeState(Id:any){
    this.service.ChangeState(Id).subscribe((data:any)=>{
      console.log(data);
    });
    this.GetItems();
  }

  ItemOutput(Id:any){
    this.service.itemOutput(Id).subscribe((data:any)=>{
      console.log(data);
    });
    this.GetItems();
  }
}
