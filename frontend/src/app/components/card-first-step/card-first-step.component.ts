import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CardService } from 'src/app/services/login.service';

@Component({
  selector: 'app-card-first-step',
  templateUrl: './card-first-step.component.html',
  styleUrls: ['./card-first-step.component.scss']
})
export class CardFirstStepComponent {
  
  form = new FormGroup({
      cardNumber: new FormControl('', Validators.compose([Validators.required, Validators.nullValidator]))
  })

  constructor(private cardService: CardService, private router: Router) {
  }

  ngOnInit() {
  }

  checkCardNumber(formValue: any) {
    var cardNumber = formValue.cardNumber
    let cardNumberToInt = parseInt(cardNumber);
    console.log(cardNumberToInt)
    this.cardService.checkCardNumber(cardNumberToInt).subscribe(exists => this.redirectTo(exists, cardNumberToInt));
  }

  redirectTo(exists: boolean, cardNumberToInt: number) {
    if(exists) {
      localStorage.setItem('cardNumber', cardNumberToInt.toString())
      this.router.navigateByUrl('/second-step');
    } else {
      this.router.navigateByUrl('/error');
    }
  }
}
