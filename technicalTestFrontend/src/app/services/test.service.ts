import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { form } from '../models/item.model';

@Injectable({
  providedIn: 'root'
})

export class TestService {

  constructor(private http:HttpClient) { }

  GetItems(type:number){
    return this.http.get(`https://localhost:44369/getItem/${type}`);
  }

  ChangeState(type:number){
    return this.http.get(`https://localhost:44369/changeStatus/${type}`);
  }

  itemOutput(type:number){
    return this.http.get(`https://localhost:44369/itemOutput/${type}`);
  }
  StorageItem(item:form){
    return this.http.post(`https://localhost:44369/storageItem`,item);
  }
}
