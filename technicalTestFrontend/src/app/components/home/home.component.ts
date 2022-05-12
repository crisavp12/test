import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TestService } from 'src/app/services/test.service';
import { ItemModel } from '../../models/item.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit{
  items?:ItemModel[];

  constructor(private router:Router,
              private service:TestService) 
  { 
    this.GetItems();
  }

  ngAfterViewInit(): void {}

  ngOnInit(): void {
    
  }

  goStorage(){
    this.router.navigate(['/storage'])
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

  GetItems(){
     this.service.GetItems(0)
        .subscribe((data:any)=>{
          this.items = data;
          console.log('ya cargaron los items');
        });
        
    }
}
