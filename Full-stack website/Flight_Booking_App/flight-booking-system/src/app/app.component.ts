import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SearchFlightComponent } from './search-flight/search-flight.component';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, SearchFlightComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'flight-booking-system';
}
