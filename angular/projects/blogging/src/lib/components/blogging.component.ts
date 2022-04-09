import { Component, OnInit } from '@angular/core';
import { BloggingService } from '../services/blogging.service';

@Component({
  selector: 'lib-blogging',
  template: ` <p>blogging works!</p> `,
  styles: [],
})
export class BloggingComponent implements OnInit {
  constructor(private service: BloggingService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
