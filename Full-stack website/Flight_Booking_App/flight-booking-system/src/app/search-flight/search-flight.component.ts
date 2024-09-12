import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-search-flight',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './search-flight.component.html',
  styleUrl: './search-flight.component.css'
})
export class SearchFlightComponent implements OnInit {
  searchResult : FlightRm[] =[
    {
      airline : "Vietnam Airline",
      remainingNoOfSeats : 500,
      departure : {time: Date.now().toString(), place: "Hanoi"},
      arrival : {time: Date.now().toString(), place: "Ausburg"},
      price: "350",
      },
      {
        airline : "Singapore Airline",
        remainingNoOfSeats : 300,
        departure : {time: Date.now().toString(), place: "Singapore"},
        arrival : {time: Date.now().toString(), place: "UAE"},
        price: "400",
      },
      {
        airline : "Scoot Airline",
        remainingNoOfSeats : 200,
        departure : {time: Date.now().toString(), place: "Tokyo"},
        arrival : {time: Date.now().toString(), place: "Paris"},
        price: "250",
      }
  ]
  constructor(){

  }
  ngOnInit(): void {
    console.log("Search flight initialized");
  }

}

export interface FlightRm{
    airline: string;
    arrival: TimePlaceRm;
    departure: TimePlaceRm;
    price: string;
    remainingNoOfSeats: number;
}

export interface TimePlaceRm{
  place: string;
  time: string
}
