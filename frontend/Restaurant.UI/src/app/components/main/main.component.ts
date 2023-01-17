import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../../models/restaurant';
import { Menu } from '../../models/menu';
import { RestaurantService } from '../../services/restaurant.service';
import { MenuService } from '../../services/menu.service';
import { CurrentRestaurantService } from '../../services/current-restaurant.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  AllRestaurant: Restaurant[] = [];

  constructor(private restService: RestaurantService, private menuService: MenuService, private currentrestservice: CurrentRestaurantService, private router: Router){}

  ngOnInit(): void{
    this.restService.getAllRestaurant().subscribe(
        (resp) => this.AllRestaurant = resp,
        (error) => console.log(error)
    );
  }

  getCurrentMenu(rest_id: number, id: number){
    this.menuService.getCurrentMenu(rest_id).subscribe(
      (resp) => {
        this.AllRestaurant[id - 1].menu = resp
        this.currentrestservice.setRestaurant(this.AllRestaurant[id - 1])
        this.router.navigate(['menu']);
      },
      (error) => console.log(error)
    )
  }

}
