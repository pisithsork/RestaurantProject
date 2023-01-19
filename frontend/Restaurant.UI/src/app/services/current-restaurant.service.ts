import { Injectable } from '@angular/core';
import { Restaurant } from '../models/restaurant';
import { Menu } from '../models/menu';
import { Score } from '../models/score';
import { Grade } from '../models/grade';

@Injectable({
  providedIn: 'root'
})
export class CurrentRestaurantService {

  private currentrest = new Restaurant(0, 0, "", "", "", "", [], [], [], []);
  constructor() { }

  setRestaurant(restaurant: Restaurant){
    this.currentrest = restaurant;
  }
  getRestaurant():Restaurant{
    return this.currentrest;
  }
  setMenu(menu: Menu[]){
    this.currentrest.menu = menu;
  }
  getMenu():Menu[]{
    return this.currentrest.menu;
  }
  setScores(scores: Score[]){
    this.currentrest.score = scores;
  }
  getScores():Score[]{
    return this.currentrest.score;
  }
  setGrades(grades: Grade[]){
    this.currentrest.grade = grades;
  }
  getGrades():Grade[]{
    return this.currentrest.grade;
  }
}
