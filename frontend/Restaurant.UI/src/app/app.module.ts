import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './components/main/main.component';
import { HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { DisplayMenuComponent } from './components/display-menu/display-menu.component';
import { RestaurantDetailsComponent } from './components/restaurant-details/restaurant-details.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    DisplayMenuComponent,
    RestaurantDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
