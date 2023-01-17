import { Injectable } from '@angular/core';
import { Restaurant } from '../models/restaurant';

@Injectable({
  providedIn: 'root'
})
export class CurrentRestaurantService {

  private currentrest = new Restaurant(0, 0, "", "", "", "", "", [], [], []);
  constructor() { }

  setRestaurant(restaurant: Restaurant){
    this.currentrest = restaurant;
  }
  getRestaurant():Restaurant{
    return this.currentrest;
  }
}
