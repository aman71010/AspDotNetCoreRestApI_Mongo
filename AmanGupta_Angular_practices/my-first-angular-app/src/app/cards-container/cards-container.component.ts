import { Component } from '@angular/core';

@Component({
  selector: 'app-cards-container',
  templateUrl: './cards-container.component.html',
  styleUrls: ['./cards-container.component.css']
})
export class CardsContainerComponent {
  features: any[] = [
    {
      title: 'Brand Recongnition',
      description: 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est molestiae, voluptatibus facilis illum exercitationem quaerat! Officia voluptatum quia, facilis doloremque deserunt sapiente vel eius fugitimpedit vero qui aspernatur adipisci.'
    },
    {
      title: 'Detailed Records',
      description: 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est molestiae, voluptatibus facilis illum exercitationem quaerat! Officia voluptatum quia, facilis doloremque deserunt sapiente vel eius fugitimpedit vero qui aspernatur adipisci.'
    },
    {
      title: 'Fully Customizable',
      description: 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est molestiae, voluptatibus facilis illum exercitationem quaerat! Officia voluptatum quia, facilis doloremque deserunt sapiente vel eius fugitimpedit vero qui aspernatur adipisci.'
    }
  ];
}
