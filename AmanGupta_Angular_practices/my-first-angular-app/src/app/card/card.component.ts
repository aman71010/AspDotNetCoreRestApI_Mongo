import { Component } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent {
  features: any[] = [
    {
      imgSrc: 'https://i.ibb.co/KhryrYT/icon-brand-recognition-removebg-preview.png',
      imgAlt: 'icon-brand-recognition',
      title: 'Brand Recongnition',
      description: 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est molestiae, voluptatibus facilis illum exercitationem quaerat! Officia voluptatum quia, facilis doloremque deserunt sapiente vel eius fugitimpedit vero qui aspernatur adipisci.'
    },
    {
      imgSrc: 'https://i.ibb.co/Kmjyc25/icon-detailed-records-1-removebg-preview.png',
      imgAlt: 'icon-detailed-records',
      title: 'Detailed Records',
      description: 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est molestiae, voluptatibus facilis illum exercitationem quaerat! Officia voluptatum quia, facilis doloremque deserunt sapiente vel eius fugitimpedit vero qui aspernatur adipisci.'
    },
    {
      imgSrc: 'https://i.ibb.co/YThMFkw/icon-fully-customizable-1-removebg-preview.png',
      imgAlt: 'icon-fully-customizable',
      title: 'Fully Customizable',
      description: 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Est molestiae, voluptatibus facilis illum exercitationem quaerat! Officia voluptatum quia, facilis doloremque deserunt sapiente vel eius fugitimpedit vero qui aspernatur adipisci.'
    }
  ];

  getTop(i: number){
    return i*40 + 'px';
  }

}
