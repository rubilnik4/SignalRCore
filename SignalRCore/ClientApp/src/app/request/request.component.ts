import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from "@angular/router";
import { NgForm } from '@angular/forms';
import { environment } from '../../environments/environment';

@Component({
  selector: 'request',
  templateUrl: './request.component.html'
})
export class RequestComponent {
  invalidLogin: boolean;

  constructor(private router: Router, private http: HttpClient) { }

}
