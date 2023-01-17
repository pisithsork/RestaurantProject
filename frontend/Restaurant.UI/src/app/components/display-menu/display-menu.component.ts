import { Component, OnInit } from '@angular/core';
import { Menu } from '../../models/menu';
import { Restaurant } from '../../models/restaurant';
import { CurrentRestaurantService } from '../../services/current-restaurant.service';

@Component({
  selector: 'app-display-menu',
  templateUrl: './display-menu.component.html',
  styleUrls: ['./display-menu.component.css']
})
export class DisplayMenuComponent implements OnInit {

  currentrest!: Restaurant;
  currentmenu!: Menu[];

  constructor(private currestrestservice: CurrentRestaurantService){ }

  ngOnInit():void{
    this.currentrest = this.currestrestservice.getRestaurant();
    this.currentmenu = this.currentrest.menu;
  }

}
