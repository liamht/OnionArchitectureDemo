import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/Nav/navmenu.component';
import { HomeComponent } from './components/Home/home.component';
import { CarListComponent } from './components/Cars/List/List.component';
import { CarDetailsComponent } from './components/Cars/Details/Details.component';
import { CarAddComponent } from './components/Cars/Add/Add.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CarListComponent,
        HomeComponent,
        CarDetailsComponent,
        CarAddComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'cars', component: CarListComponent },
            { path: 'cars/add', component: CarAddComponent },
            { path: 'cars/:id', component: CarDetailsComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
