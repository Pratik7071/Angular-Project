// api-error.component.ts

import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-api-error',
  template: `
    <div class="api-error">
      <p>{{errorMessage }}</p>
    </div>
  `,
  styles: [
    `
      .api-error {
        color: red;
        font-weight: bold;
      }
    `,
  ],
})
export class ApiErrorComponent {
  errorMessage: string = '';

  openErrorDialog(message: string): void {
    this.errorMessage = message;
  }

  }
