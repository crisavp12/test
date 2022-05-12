import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styles: [
  ]
})
export class NavbarComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  goGoodItems(){
    this.router.navigate(['/goodItems'])
      .then(() => {
        window.location.reload();
      });
  }

  goAllItems(){
    this.router.navigate(['/home'])
      .then(() => {
        window.location.reload();
      });
  }

  goDefectiveItems(){
    this.router.navigate(['/defectiveItems'])
      .then(() => {
        window.location.reload();
      });
  }
}
