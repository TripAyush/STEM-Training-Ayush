import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http'
import { AppComponent } from './app.component';
import { CalculatorComponent } from './components/calculator/calculator.component';
import { ReactiveRegFormComponent } from './components/reactive-reg-form/reactive-reg-form.component';
import { TemplateRegFormComponent } from './components/template-reg-form/template-reg-form.component';
import { LoginComponent } from './components/login/login.component';
import { PipesExampleComponent } from './components/pipes-example/pipes-example.component';
import { ReadfileComponent } from './components/readfile/readfile.component';

@NgModule({
  declarations: [
    AppComponent,
    CalculatorComponent,
    ReactiveRegFormComponent,
    TemplateRegFormComponent,
    LoginComponent,
    PipesExampleComponent,
    ReadfileComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
