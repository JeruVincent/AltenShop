import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {

  checked: boolean = true;
  user: User = {id:1, name: "John Doe"};
  paths!: MenuItem[];
  home: MenuItem = { icon: 'pi pi-home', routerLink: '/' };

  constructor(private router: Router){}

  ngOnInit(){
    this.router.events.subscribe((routingEvent) => {
      if(routingEvent instanceof NavigationEnd){
        let newPath: MenuItem[] = [];
        routingEvent.urlAfterRedirects.split('/').forEach(routingElement => {
          if(routingElement != ""){
            newPath.push({label: routingElement, routerLink: this.routerLinkConstructor(newPath) + "/" + routingElement});
          }
        });
        this.paths = newPath;
      }
    });
    // this.user = 
  }

  /**
   * Method used to create an URL based on a given array of MenuItem. It extracts every label of each element and build an URL
   * @param path Array of MenuItem (must contains at least label element)
   * @returns A string built as an URL, splitted by /
   */
  routerLinkConstructor(path: MenuItem[]): string{
    let newRouterLink: string = "";
    path.forEach(pathElement => {
      newRouterLink = newRouterLink + "/" + pathElement.label;
    });
    return newRouterLink;
  }
}