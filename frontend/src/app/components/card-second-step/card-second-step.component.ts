import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CardService } from 'src/app/services/login.service';

@Component({
  selector: 'app-card-second-step',
  templateUrl: './card-second-step.component.html',
  styleUrls: ['./card-second-step.component.scss']
})
export class CardSecondStepComponent {
  
  form = new FormGroup({
      pinNumber: new FormControl('', Validators.compose([Validators.required, Validators.nullValidator]))
  })

  constructor(private cardService: CardService, private router: Router) {
  }

  ngOnInit() {
  }

  checkPinNumber(formValue: any) {
    let cardNumber = ''
    let cardNumberToInt = 0;
    let pinNumber = formValue.pinNumber
    let pinNumberToInt = parseInt(pinNumber);
    let temp = localStorage.getItem('cardNumber')
    if(temp) {
      cardNumberToInt = parseInt(temp.toString())
    }
    this.cardService.checkPinNumber(pinNumberToInt, cardNumberToInt).subscribe(exists => this.redirectTo(exists));
  }

  redirectTo(exists: boolean) {
    if(exists) {
      this.router.navigateByUrl('/operations');
    }
  }
}

