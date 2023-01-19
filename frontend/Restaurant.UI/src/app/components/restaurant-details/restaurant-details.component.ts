import { Component, OnInit } from '@angular/core';
import { CurrentRestaurantService } from '../../services/current-restaurant.service';
import { ScoreService } from '../../services/score.service';
import { GradeService } from '../../services/grade.service';
import { Router } from '@angular/router';
import { Restaurant } from '../../models/restaurant';

@Component({
  selector: 'app-restaurant-details',
  templateUrl: './restaurant-details.component.html',
  styleUrls: ['./restaurant-details.component.css']
})
export class RestaurantDetailsComponent implements OnInit {

  currentrest!: Restaurant;
  restavgscore!: any;
  menu: boolean = false;
  menu_btn: string = 'Show Menu'
  
  constructor(private currentrestservice:CurrentRestaurantService, private scoreService: ScoreService, private router: Router){ }

  ngOnInit(): void {
    this.currentrest = this.currentrestservice.getRestaurant();
    // this.currentrest.grade = this.currentrestservice.getGrades();
    // this.currentrest.score  = this.currentrestservice.getScores();
    this.scoreService.getRestaurantAvgScore(this.currentrest.id).subscribe(
      (resp) => {
        this.restavgscore = resp;
      }
    );
    console.log(typeof this.restavgscore)
    // console.log("Current Restaurant details: ")
    // console.log(this.currentrest.id);
    // console.log(this.currentrest.rest_id);
    // console.log(this.currentrest.name);
    // console.log(this.currentrest.address);
    // console.log(this.currentrest.city);
    // console.log(this.currentrest.state);
    // console.log(this.currentrest.menu);
    // console.log(this.currentrest.grade);
    // console.log(this.currentrest.score);
    
  }

  IO_Menu(){
    if(this.menu){
      this.menu = false;
      this.menu_btn = "Show Menu";
    }
    else{
      this.menu = true;
      this.menu_btn = "Hide Menu";
    }
  }

}
