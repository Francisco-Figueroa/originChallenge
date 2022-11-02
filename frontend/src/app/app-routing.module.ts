import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardFirstStepComponent } from './components/card-first-step/card-first-step.component';
import { CardSecondStepComponent } from './components/card-second-step/card-second-step.component';
import { OperationsComponent } from './components/operations/operations.component';


const appRoutes: Routes = [
  { path: '', redirectTo:'/', pathMatch: 'full'},
  { path: '', component: CardFirstStepComponent,  pathMatch: 'full'},
  { path: 'second-step', component: CardSecondStepComponent, pathMatch: 'full'},
  { path: 'operations', component: OperationsComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
