import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './components/main/main.component';
import { DisplayMenuComponent } from './components/display-menu/display-menu.component';
import { RestaurantDetailsComponent } from './components/restaurant-details/restaurant-details.component';

const routes: Routes = [
  {path: "", redirectTo: "/home", pathMatch: "full"},
  {path: "home", component: MainComponent},
  {path: "menu", component: DisplayMenuComponent},
  {path:"details", component: RestaurantDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
