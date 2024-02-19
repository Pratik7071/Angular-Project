import { TestBed } from '@angular/core/testing';

import { TataCliqWebApi } from './TataCliqWebApi';

describe('GetAllProductsService', () => {
  let service: TataCliqWebApi;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TataCliqWebApi);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
