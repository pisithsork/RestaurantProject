import { TestBed } from '@angular/core/testing';

import { CurrentRestaurantService } from './current-restaurant.service';

describe('CurrentRestaurantService', () => {
  let service: CurrentRestaurantService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CurrentRestaurantService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
