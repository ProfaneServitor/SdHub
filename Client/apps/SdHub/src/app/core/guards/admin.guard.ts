import { Injectable } from '@angular/core';
import { Router, CanActivate } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Injectable()
export class AdminGuard implements CanActivate {

  constructor(private router: Router,
              private authService: AuthService) { }

  canActivate() {
    /*const user = this.authService.getCurrentUser();

    if (user && user.isAdmin) {
      return true;

    } else {
      void this.router.navigate(['/']);
      return false;
    }*/
    return false;
  }
}
