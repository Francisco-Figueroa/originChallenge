import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class CardService {

  apiUrl = `${environment.apiUrl}/Card`;

  constructor(private http: HttpClient) { }

  checkCardNumber(cardNumber: number) {
    return this.http.post<any>(`${this.apiUrl}/checkCardNumber`, { cardNumber });
  }

  checkPinNumber(pinNumber: number, cardNumber: number) {
    return this.http.post<any>(`${this.apiUrl}/checkPinNumber`, { pinNumber, cardNumber });
  }


}