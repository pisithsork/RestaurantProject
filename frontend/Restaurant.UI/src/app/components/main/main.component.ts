import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../../models/restaurant';
import { RestaurantService } from '../../services/restaurant.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  AllRestaurant: Restaurant[] = [];

  constructor(private restService: RestaurantService){}

  ngOnInit(): void{
    this.restService.getAllRestaurant().subscribe(
        (resp) => this.AllRestaurant = resp,
        (error) => console.log(error)
    );
  }

}
