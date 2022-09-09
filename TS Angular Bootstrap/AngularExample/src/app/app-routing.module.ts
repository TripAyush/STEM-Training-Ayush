import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculatorComponent } from './components/calculator/calculator.component';
import { ReactiveRegFormComponent } from './components/reactive-reg-form/reactive-reg-form.component';
import { TemplateRegFormComponent } from './components/template-reg-form/template-reg-form.component';
import { LoginComponent } from './components/login/login.component';
import { PipesExampleComponent } from './components/pipes-example/pipes-example.component';
import { ReadfileComponent } from './components/readfile/readfile.component';

const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent,
  },
  {
    path: 'reactive',
    component: ReactiveRegFormComponent,
  },
  {
    path: 'template',
    component: TemplateRegFormComponent,
  },
  {
    path: 'calc',
    component: CalculatorComponent,
  },
  {
    path: 'pExample', component: PipesExampleComponent
  },
  {
    path: 'rf', component: ReadfileComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
