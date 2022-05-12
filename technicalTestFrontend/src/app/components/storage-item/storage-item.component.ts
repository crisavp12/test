import { Component, OnInit } from '@angular/core';
import { form } from '../../models/item.model';
import { Router, NavigationExtras } from '@angular/router';
import { NgForm } from '@angular/forms';
import { TestService } from '../../services/test.service';

@Component({
  selector: 'app-storage-item',
  templateUrl: './storage-item.component.html'
})
export class StorageItemComponent implements OnInit {
  
  itemForm:form =({
    Name:"",
    State:1
  });

  constructor(private router:Router,
              private service:TestService) { }

  ngOnInit(): void {
  }

  Storage(form:NgForm){
    this.itemForm.Name = form.value.Name;
    this.service.StorageItem(this.itemForm)
    .subscribe();

    this.router.navigate(['/Home'])
  }
}
