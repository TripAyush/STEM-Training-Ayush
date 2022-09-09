import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-readfile',
  templateUrl: './readfile.component.html',
  styleUrls: ['./readfile.component.css']
})
export class ReadfileComponent implements OnInit {
  http!: HttpClient;
  constructor(http: HttpClient) {
    this.http = http;
  }

  ngOnInit(): void {
  }

  fetch() {
    this.getJSON().subscribe(data => console.log(data)
    )
  }

  getJSON(): Observable<any> {
    return this.http.get('./assets/data.json');
  }

}
