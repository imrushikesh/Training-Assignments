import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomPipe1Component } from './custom-pipe1/custom-pipe1.component';
import { DivisionPipe } from './division.pipe';
import { StrformatPipe } from './strformat.pipe';
import { StringComponent } from './string/string.component';
import { WordsPipe } from './words.pipe';
import { StringWordsComponent } from './string-words/string-words.component';
import { RepeatPipe } from './repeat.pipe';
import { RepeatstrComponent } from './repeatstr/repeatstr.component';
import { PersonComponent } from './person/person.component';

@NgModule({
  declarations: [
    AppComponent,
    CustomPipe1Component,
    DivisionPipe,
    StrformatPipe,
    StringComponent,
    WordsPipe,
    StringWordsComponent,
    RepeatPipe,
    RepeatstrComponent,
    PersonComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
