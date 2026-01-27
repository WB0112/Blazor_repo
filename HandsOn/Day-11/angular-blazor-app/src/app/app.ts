import { Component, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
    <h2>Angular 20 App</h2>
    <blazor-counter></blazor-counter>
  `,
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class App { }