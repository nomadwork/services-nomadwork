(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/app.component.html":
/*!**************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/app.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<router-outlet>\r\n</router-outlet>\r\n<ngx-alerts></ngx-alerts>"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/header/header.component.html":
/*!************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/header/header.component.html ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<nav class=\"nav\">\r\n    <div>\r\n        <a [routerLink]=\"['']\" class=\"nav__link\" routerLinkActive=\"nav__link--active\"\r\n            [routerLinkActiveOptions]=\"{exact: true}\">Mapa</a>\r\n            <a class=\"nav__link\" *ngIf=\"user && user.admin\" (click)=\"showEstablishments()\"> Estabelecimentos</a>\r\n    </div>\r\n\r\n    <div>\r\n        <span *ngIf=\"user\">Bem vindo {{ user.name }} </span>\r\n        <a class=\"nav__link mr-auto\" routerLinkActive=\"nav__link--active\" (click)=\"logout()\">\r\n            Sair\r\n        </a>\r\n    </div>\r\n</nav>"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/login/login.component.html":
/*!**********************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/login/login.component.html ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-progress-bar *ngIf=\"loading\" mode=\"indeterminate\"></mat-progress-bar>\r\n<perfect-scrollbar class=\"align father\" [defaultImage]=\"defaultImage\" [lazyLoad]=\"image\">\r\n\r\n  <div class=\"grid\">\r\n    <h2 class=\"title\">Nomad Work</h2>\r\n\r\n    <div class=\"register\">\r\n      <div [@dash]=\"stateStep\" *ngIf=\"step\">\r\n        <form class=\"form\">\r\n          <div class=\"login\">\r\n            <div class=\"input-div\">\r\n              <h2>E-mail :</h2>\r\n            </div>\r\n            <input #loginEmail class=\"input\" type=\"text\" [(ngModel)]=\"email\" name=\"email-login\" />\r\n            <div class=\"camp-validate\"></div>\r\n            <button class=\"btn btn--success button-spacing\" (click)=\"validateEmail()\" (keyup.enter)=\"validateEmail()\"\r\n              [disabled]=\"verifyEmailSubmit()\">\r\n              Próximo\r\n            </button>\r\n            <span (click)=\"newUser()\" class=\"link__bottom\">Não possui uma conta? Clique aqui</span>\r\n          </div>\r\n\r\n          <div class=\"login\">\r\n            <div class=\"form__field\" (click)=\"goStepOne()\">\r\n              <mat-icon class=\"mat-validate\">remove_circle_outline</mat-icon>\r\n              <!-- <input\r\n                disabled=\"true\"\r\n                class=\"input\"\r\n                type=\"email\"\r\n                placeholder=\"E-mail\"\r\n                [(ngModel)]=\"email\"\r\n                name=\"email-login2\"\r\n                [class.form-validate]=\"formValidateText\"\r\n              /> -->\r\n              <h2>{{email}}</h2>\r\n            </div>\r\n\r\n            <div class=\"input-div\">\r\n              <h2>Senha:</h2>\r\n            </div>\r\n            <input class=\"input\" type=\"password\" name=\"password-login\" [(ngModel)]=\"password\" />\r\n\r\n            <div class=\"camp-validate\" *ngIf=\"formValidateText\">\r\n              <mat-icon class=\"mat-validate\">warning</mat-icon>\r\n              <span>\r\n                {{ formValidateText }}\r\n              </span>\r\n            </div>\r\n            <input (click)=\"login()\" (keyup.enter)=\"login()\" class=\"btn btn--success button-spacing\" type=\"submit\"\r\n              [disabled]=\"verifyPasswordSubmit()\" value=\"Entrar\" />\r\n          </div>\r\n        </form>\r\n      </div>\r\n\r\n      <div *ngIf=\"formNewUser\">\r\n        <form class=\"formRegister\" [formGroup]=\"formRegister\" (ngSubmit)=\"registerSubmit()\">\r\n          <div>\r\n            <h2>Nome e Sobrenome:</h2>\r\n            <input class=\"input\" type=\"text\" formControlName=\"name\" />\r\n\r\n            <!-- Componente que valida e mostra a mensagem de erro dinamicamente -->\r\n            <app-error-msg [control]=\"formRegister.get('name')\" label=\"Nome\">\r\n            </app-error-msg>\r\n          </div>\r\n          <div>\r\n            <h2>E-mail:</h2>\r\n\r\n            <input class=\"input\" type=\"email\" formControlName=\"email\" />\r\n\r\n            <!-- Componente que valida e mostra a mensagem de erro dinamicamente -->\r\n            <app-error-msg [control]=\"formRegister.get('email')\" label=\"E-mail\">\r\n            </app-error-msg>\r\n          </div>\r\n          <div>\r\n            <h2>Senha:</h2>\r\n\r\n            <input class=\"input\" type=\"password\" formControlName=\"password\" />\r\n\r\n            <!-- Componente que valida e mostra a mensagem de erro dinamicamente -->\r\n            <app-error-msg [control]=\"formRegister.get('password')\" label=\"Senha\">\r\n            </app-error-msg>\r\n          </div>\r\n          <div>\r\n            <h2>Confirmar Senha:</h2>\r\n\r\n            <input class=\"input\" type=\"password\" formControlName=\"passwordRepeat\" />\r\n\r\n            <!-- Componente que valida e mostra a mensagem de erro dinamicamente -->\r\n            <app-error-msg [control]=\"formRegister.get('passwordRepeat')\" label=\"Confirmar Senha\">\r\n            </app-error-msg>\r\n          </div>\r\n          <div>\r\n            <h2>Data de Nascimento:</h2>\r\n\r\n            <mat-form-field>\r\n              <input matInput [matDatepicker]=\"picker\" formControlName=\"dateborn\" />\r\n              <mat-datepicker-toggle matSuffix [for]=\"picker\"></mat-datepicker-toggle>\r\n              <mat-datepicker #picker></mat-datepicker>\r\n              <!-- Componente que valida e mostra a mensagem de erro dinamicamente -->\r\n              <app-error-msg [control]=\"formRegister.get('dateborn')\" label=\"Data\">\r\n              </app-error-msg>\r\n            </mat-form-field>\r\n          </div>\r\n\r\n          <div>\r\n            <h2>Gênero:</h2>\r\n            <div class=\"radios\">\r\n              <label class=\"container\">Masculino\r\n                <input type=\"radio\" formControlName=\"gender\" value=\"0\" />\r\n                <span class=\"checkmark\"></span>\r\n              </label>\r\n              <label class=\"container\">Feminino\r\n                <input type=\"radio\" formControlName=\"gender\" value=\"1\" />\r\n                <span class=\"checkmark\"></span>\r\n              </label>\r\n              <label class=\"container\">Outro\r\n                <input type=\"radio\" formControlName=\"gender\" value=\"2\" />\r\n                <span class=\"checkmark\"></span>\r\n              </label>\r\n            </div>\r\n          </div>\r\n\r\n          <button class=\"btn btn--success\" [disabled]=\"!formRegister.valid\" type=\"submit\">\r\n            Cadastrar\r\n          </button>\r\n        </form>\r\n\r\n        <div class=\"link-entrar\">\r\n          <span (click)=\"goLogin()\" class=\"link__bottom\">Entrar</span>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</perfect-scrollbar>"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/shared/dialog-establishments/dialog-establishments.component.html":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/shared/dialog-establishments/dialog-establishments.component.html ***!
  \*************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<h2 mat-dialog-title>Seus estabelecimentos</h2>\r\n\r\n<mat-dialog-content class=\"mat-typography\">\r\n\r\n    <perfect-scrollbar mat-dialog-content style=\"height: 75vh\" *ngIf=\"stepOne; else step2\">\r\n        <a *ngFor=\"let e of establishments\" (click)=\"details(e.id, e.name)\"\r\n            class=\"pointer list-group-item list-group-item-action\">\r\n            {{ e.name}}\r\n        </a>\r\n    </perfect-scrollbar>\r\n\r\n    <ng-template #step2>\r\n        <button (click)=\"changeStep()\" class=\"btn btn--success\">\r\n            Voltar\r\n        </button>\r\n\r\n        <div class=\"col-12 text-center\">\r\n            <span class=\"title-establishment\">\r\n                {{ showName}}\r\n            </span>\r\n        </div>\r\n\r\n        <mat-tab-group>\r\n            <mat-tab label=\"Gêneros\">\r\n                <ngx-charts-bar-vertical [view]=\"view\" [scheme]=\"colorScheme\" [results]=\"single\" [gradient]=\"gradient\"\r\n                    [xAxis]=\"showXAxis\" [yAxis]=\"showYAxis\" [legend]=\"showLegend\" [showXAxisLabel]=\"showXAxisLabel\"\r\n                    [showYAxisLabel]=\"showYAxisLabel\" [xAxisLabel]=\"xAxisLabel\" [yAxisLabel]=\"yAxisLabel\">\r\n                </ngx-charts-bar-vertical>\r\n            </mat-tab>\r\n            <mat-tab label=\"Idades\">\r\n                <ngx-charts-bar-vertical [view]=\"view\" [results]=\"singleTwo\" [gradient]=\"gradient\" [xAxis]=\"showXAxis\"\r\n                    [yAxis]=\"showYAxis\" [legend]=\"showLegend\" [showXAxisLabel]=\"showXAxisLabel\"\r\n                    [showYAxisLabel]=\"showYAxisLabel\" [xAxisLabel]=\"xAxisLabelTwo\" [yAxisLabel]=\"yAxisLabelTwo\">\r\n                </ngx-charts-bar-vertical>\r\n            </mat-tab>\r\n        </mat-tab-group>\r\n\r\n\r\n    </ng-template>\r\n\r\n</mat-dialog-content>"

/***/ }),

/***/ "./node_modules/raw-loader/index.js!./src/app/utils/error-msg/error-msg.component.html":
/*!************************************************************************************!*\
  !*** ./node_modules/raw-loader!./src/app/utils/error-msg/error-msg.component.html ***!
  \************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"errorMessage != null\">\r\n  <span>{{ errorMessage }}</span>\r\n  <i class=\"material-icons\">\r\n    error\r\n  </i>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/app-layout.component.ts":
/*!*****************************************!*\
  !*** ./src/app/app-layout.component.ts ***!
  \*****************************************/
/*! exports provided: AppLayoutComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppLayoutComponent", function() { return AppLayoutComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AppLayoutComponent = class AppLayoutComponent {
};
AppLayoutComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-app-main',
        template: `
    <app-header></app-header>
    <router-outlet></router-outlet>
      `,
    })
], AppLayoutComponent);



/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _services_auth_guard_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./services/auth-guard.service */ "./src/app/services/auth-guard.service.ts");
/* harmony import */ var _login_login_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./login/login.component */ "./src/app/login/login.component.ts");
/* harmony import */ var _app_layout_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./app-layout.component */ "./src/app/app-layout.component.ts");






const routes = [
    { path: 'login', component: _login_login_component__WEBPACK_IMPORTED_MODULE_4__["LoginComponent"] },
    {
        path: '',
        component: _app_layout_component__WEBPACK_IMPORTED_MODULE_5__["AppLayoutComponent"],
        canActivate: [_services_auth_guard_service__WEBPACK_IMPORTED_MODULE_3__["AuthGuardService"]],
        children: [
            {
                path: '', loadChildren: () => __webpack_require__.e(/*! import() | home-home-module */ "home-home-module").then(__webpack_require__.bind(null, /*! ./home/home.module */ "./src/app/home/home.module.ts")).then(m => m.HomeModule), canActivate: [_services_auth_guard_service__WEBPACK_IMPORTED_MODULE_3__["AuthGuardService"]],
            }
        ]
    },
    {
        path: '**', redirectTo: ''
    }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
    })
], AppRoutingModule);



/***/ }),

/***/ "./src/app/app.component.scss":
/*!************************************!*\
  !*** ./src/app/app.component.scss ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AppComponent = class AppComponent {
};
AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-root',
        template: __webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/index.js!./src/app/app.component.html"),
        styles: [__webpack_require__(/*! ./app.component.scss */ "./src/app/app.component.scss")]
    })
], AppComponent);



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _login_login_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./login/login.component */ "./src/app/login/login.component.ts");
/* harmony import */ var _header_header_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./header/header.component */ "./src/app/header/header.component.ts");
/* harmony import */ var _app_layout_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./app-layout.component */ "./src/app/app-layout.component.ts");
/* harmony import */ var _shared_module__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./shared.module */ "./src/app/shared.module.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm2015/animations.js");
/* harmony import */ var ngx_alerts__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ngx-alerts */ "./node_modules/ngx-alerts/fesm2015/ngx-alerts.js");
/* harmony import */ var ng_lazyload_image__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ng-lazyload-image */ "./node_modules/ng-lazyload-image/fesm2015/ng-lazyload-image.js");
/* harmony import */ var _swimlane_ngx_charts__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @swimlane/ngx-charts */ "./node_modules/@swimlane/ngx-charts/release/esm.js");
/* harmony import */ var ngx_swiper_wrapper__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ngx-swiper-wrapper */ "./node_modules/ngx-swiper-wrapper/dist/ngx-swiper-wrapper.es5.js");
/* harmony import */ var _auth_interceptor_module__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./auth/interceptor.module */ "./src/app/auth/interceptor.module.ts");
/* harmony import */ var _shared_dialog_establishments_dialog_establishments_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./shared/dialog-establishments/dialog-establishments.component */ "./src/app/shared/dialog-establishments/dialog-establishments.component.ts");



















const DEFAULT_SWIPER_CONFIG = {
    direction: 'horizontal',
    slidesPerView: 'auto'
};
let AppModule = class AppModule {
};
AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
        declarations: [
            _app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"],
            _login_login_component__WEBPACK_IMPORTED_MODULE_6__["LoginComponent"],
            _header_header_component__WEBPACK_IMPORTED_MODULE_7__["HeaderComponent"],
            _app_layout_component__WEBPACK_IMPORTED_MODULE_8__["AppLayoutComponent"],
            _shared_dialog_establishments_dialog_establishments_component__WEBPACK_IMPORTED_MODULE_17__["DialogEstablishmentsComponent"]
        ],
        imports: [
            ngx_swiper_wrapper__WEBPACK_IMPORTED_MODULE_15__["SwiperModule"],
            _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_11__["BrowserAnimationsModule"],
            _swimlane_ngx_charts__WEBPACK_IMPORTED_MODULE_14__["NgxChartsModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_10__["FormsModule"],
            _shared_module__WEBPACK_IMPORTED_MODULE_9__["SharedModule"],
            _auth_interceptor_module__WEBPACK_IMPORTED_MODULE_16__["Interceptor"],
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_3__["AppRoutingModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_5__["HttpClientModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_10__["FormsModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_10__["ReactiveFormsModule"],
            ng_lazyload_image__WEBPACK_IMPORTED_MODULE_13__["LazyLoadImageModule"],
            ngx_alerts__WEBPACK_IMPORTED_MODULE_12__["AlertModule"].forRoot({ maxMessages: 5, timeout: 5000, position: 'right' }),
        ],
        providers: [{
                provide: ngx_swiper_wrapper__WEBPACK_IMPORTED_MODULE_15__["SWIPER_CONFIG"],
                useValue: DEFAULT_SWIPER_CONFIG
            }],
        entryComponents: [_shared_dialog_establishments_dialog_establishments_component__WEBPACK_IMPORTED_MODULE_17__["DialogEstablishmentsComponent"]],
        bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"]]
    })
], AppModule);



/***/ }),

/***/ "./src/app/auth/interceptor.module.ts":
/*!********************************************!*\
  !*** ./src/app/auth/interceptor.module.ts ***!
  \********************************************/
/*! exports provided: HttpsRequestInterceptor, Interceptor */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HttpsRequestInterceptor", function() { return HttpsRequestInterceptor; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Interceptor", function() { return Interceptor; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let HttpsRequestInterceptor = class HttpsRequestInterceptor {
    intercept(req, next) {
        const token = localStorage.getItem('token');
        let dupReq = req.clone({});
        if (token) {
            dupReq = req.clone({
                headers: req.headers.set('Authorization', `${token}`),
            });
        }
        return next.handle(dupReq);
    }
};
HttpsRequestInterceptor = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
], HttpsRequestInterceptor);

let Interceptor = class Interceptor {
};
Interceptor = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        providers: [
            {
                provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HTTP_INTERCEPTORS"],
                useClass: HttpsRequestInterceptor,
                multi: true,
            },
        ],
    })
], Interceptor);



/***/ }),

/***/ "./src/app/header/header.component.scss":
/*!**********************************************!*\
  !*** ./src/app/header/header.component.scss ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "nav {\n  position: relative;\n  z-index: 99;\n}\n\n.material-icons {\n  font-size: 20px;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvaGVhZGVyL0M6XFxVc2Vyc1xcamVyc29cXERvY3VtZW50c1xcUHJvamV0b3NcXGZyb250ZW5kLW5vbWFkd29yay9zcmNcXGFwcFxcaGVhZGVyXFxoZWFkZXIuY29tcG9uZW50LnNjc3MiLCJzcmMvYXBwL2hlYWRlci9oZWFkZXIuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDSSxrQkFBQTtFQUNBLFdBQUE7QUNDSjs7QURFQTtFQUNDLGVBQUE7QUNDRCIsImZpbGUiOiJzcmMvYXBwL2hlYWRlci9oZWFkZXIuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyJuYXZ7XHJcbiAgICBwb3NpdGlvbjogcmVsYXRpdmU7XHJcbiAgICB6LWluZGV4OiA5OTtcclxufVxyXG5cclxuLm1hdGVyaWFsLWljb25ze1xyXG4gZm9udC1zaXplOiAyMHB4O1xyXG59XHJcbiIsIm5hdiB7XG4gIHBvc2l0aW9uOiByZWxhdGl2ZTtcbiAgei1pbmRleDogOTk7XG59XG5cbi5tYXRlcmlhbC1pY29ucyB7XG4gIGZvbnQtc2l6ZTogMjBweDtcbn0iXX0= */"

/***/ }),

/***/ "./src/app/header/header.component.ts":
/*!********************************************!*\
  !*** ./src/app/header/header.component.ts ***!
  \********************************************/
/*! exports provided: HeaderComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HeaderComponent", function() { return HeaderComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _services_login_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../services/login.service */ "./src/app/services/login.service.ts");
/* harmony import */ var _services_user_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../services/user.service */ "./src/app/services/user.service.ts");
/* harmony import */ var _angular_material_dialog__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/material/dialog */ "./node_modules/@angular/material/esm2015/dialog.js");
/* harmony import */ var _shared_dialog_establishments_dialog_establishments_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../shared/dialog-establishments/dialog-establishments.component */ "./src/app/shared/dialog-establishments/dialog-establishments.component.ts");






let HeaderComponent = class HeaderComponent {
    constructor(loginService, userService, matDialog) {
        this.loginService = loginService;
        this.userService = userService;
        this.matDialog = matDialog;
    }
    ngOnInit() {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function* () {
            this.isLoggedIn$ = yield this.loginService.isLoggedIn;
            this.user = this.userService.user;
        });
    }
    showEstablishments() {
        this.matDialog.open(_shared_dialog_establishments_dialog_establishments_component__WEBPACK_IMPORTED_MODULE_5__["DialogEstablishmentsComponent"], {
            width: '90%',
            height: '90%',
            data: this.user.establishmments
        });
    }
    logout() {
        this.loginService.logout();
    }
};
HeaderComponent.ctorParameters = () => [
    { type: _services_login_service__WEBPACK_IMPORTED_MODULE_2__["LoginService"] },
    { type: _services_user_service__WEBPACK_IMPORTED_MODULE_3__["UserService"] },
    { type: _angular_material_dialog__WEBPACK_IMPORTED_MODULE_4__["MatDialog"] }
];
HeaderComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-header',
        template: __webpack_require__(/*! raw-loader!./header.component.html */ "./node_modules/raw-loader/index.js!./src/app/header/header.component.html"),
        styles: [__webpack_require__(/*! ./header.component.scss */ "./src/app/header/header.component.scss")]
    })
], HeaderComponent);



/***/ }),

/***/ "./src/app/login/login.component.scss":
/*!********************************************!*\
  !*** ./src/app/login/login.component.scss ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".button-spacing {\n  margin-top: 1em;\n  margin-bottom: 1em;\n}\n\nmat-progress-bar {\n  position: fixed;\n  top: 0;\n  left: 0;\n}\n\n.input-div {\n  width: 100%;\n  text-align: left;\n}\n\n.login {\n  display: flex;\n  flex-direction: column;\n  justify-content: space-around;\n  align-items: center;\n  min-width: 290px;\n  margin: 0 80px 0 0;\n}\n\n.form {\n  display: flex;\n}\n\n.form__field {\n  display: flex;\n  justify-content: flex-start;\n  align-items: center;\n  align-content: center;\n  color: #03A9F4;\n  cursor: pointer !important;\n  margin-bottom: 20px !important;\n  padding: 8px;\n  border: 2px solid #03A9F4;\n  border-radius: 5px;\n}\n\n.form__field mat-icon {\n  margin-right: 5px;\n}\n\n.form__field input {\n  cursor: pointer;\n}\n\n.father {\n  background-color: #03A9F4;\n  background: url(http://localhost:3000/files/nomadworkbg-lq.jpg) no-repeat center center fixed;\n  background-size: cover;\n  filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src=\".nomadworkbg.jpg\", sizingMethod=\"scale\");\n  -ms-filter: \"progid:DXImageTransform.Microsoft.AlphaImageLoader(src='nomadworkbg.jpg', sizingMethod='scale')\";\n}\n\n* {\n  box-sizing: border-box;\n}\n\n.align {\n  align-items: center;\n  display: flex;\n  flex-direction: row;\n}\n\n.grid {\n  margin: 0 auto;\n  text-align: center;\n  max-width: 25rem;\n  width: 100%;\n}\n\n.title {\n  font-size: 2.75rem;\n  font-weight: 500;\n  box-shadow: 0 -5px 10px rgba(0, 0, 0, 0.78);\n  text-transform: uppercase;\n  z-index: 2;\n  color: #f3f3f3;\n  background: rgba(3, 168, 244, 0.733);\n  border-radius: 5px;\n  padding: 5px 0px;\n  border-bottom-left-radius: 0px;\n  border-bottom-right-radius: 0px;\n  position: relative;\n  margin: 20px 0 0px 0px;\n}\n\n.container {\n  font-size: 18px;\n  font-weight: normal;\n  margin: 0px;\n}\n\n.radios {\n  margin: 20px;\n}\n\nh2 {\n  color: #000;\n}\n\n.input:disabled {\n  color: #03A9F4 !important;\n  border-bottom: 0px !important;\n  font-weight: bold !important;\n  font-size: 19px !important;\n}\n\n.formRegister {\n  display: flex;\n  flex-direction: column;\n  justify-content: center;\n  align-items: center;\n}\n\n.formRegister > div {\n  width: 100%;\n  margin: 0 0 25px 0;\n}\n\n.animate {\n  width: calc(400px * 2);\n  display: flex;\n  justify-content: space-between;\n}\n\n.error-msg {\n  display: flex;\n  justify-content: space-between;\n  align-items: center;\n  padding: 5px;\n}\n\n.register {\n  margin: 0 0 20px 0px;\n}\n\n.link-entrar {\n  text-align: center;\n  width: 100%;\n  padding: 10px;\n}\n\n.link__bottom {\n  padding: 10px;\n  cursor: pointer;\n}\n\n.link__bottom:hover {\n  font-weight: 500;\n}\n\n@media (min-width: 374px) {\n  .login {\n    min-width: 340px;\n    margin: 0 35px 0 0;\n  }\n}\n\n@media (min-width: 376px) {\n  .login {\n    min-width: 360px;\n  }\n}\n\n@media (min-width: 420px) {\n  .register {\n    padding: 2rem 2rem 0rem 2rem;\n  }\n\n  .login {\n    min-width: 340px;\n  }\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvbG9naW4vQzpcXFVzZXJzXFxqZXJzb1xcRG9jdW1lbnRzXFxQcm9qZXRvc1xcZnJvbnRlbmQtbm9tYWR3b3JrL3NyY1xcYXBwXFxsb2dpblxcbG9naW4uY29tcG9uZW50LnNjc3MiLCJzcmMvYXBwL2xvZ2luL2xvZ2luLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUlBO0VBQ0UsZUFBQTtFQUNBLGtCQUFBO0FDSEY7O0FETUE7RUFDRSxlQUFBO0VBQ0EsTUFBQTtFQUNBLE9BQUE7QUNIRjs7QURPQTtFQUNFLFdBQUE7RUFDQSxnQkFBQTtBQ0pGOztBRE9BO0VBQ0UsYUFBQTtFQUNBLHNCQUFBO0VBQ0EsNkJBQUE7RUFDQSxtQkFBQTtFQUNBLGdCQUFBO0VBQ0Esa0JBQUE7QUNKRjs7QURNQTtFQUNFLGFBQUE7QUNIRjs7QURNQTtFQUNFLGFBQUE7RUFDQSwyQkFBQTtFQUNBLG1CQUFBO0VBQ0EscUJBQUE7RUFDQSxjQXBDVztFQXFDWCwwQkFBQTtFQUNBLDhCQUFBO0VBQ0EsWUFBQTtFQUNBLHlCQUFBO0VBQ0Esa0JBQUE7QUNIRjs7QURLRTtFQUNFLGlCQUFBO0FDSEo7O0FES0U7RUFDRSxlQUFBO0FDSEo7O0FET0E7RUFDRSx5QkFwRFc7RUFxRFgsNkZBQUE7RUFJQSxzQkFBQTtFQUNBLHdHQUFBO0VBQ0EsNkdBQUE7QUNKRjs7QURPQTtFQUNFLHNCQUFBO0FDSkY7O0FET0E7RUFFSSxtQkFBQTtFQUNBLGFBQUE7RUFDQSxtQkFBQTtBQ0xKOztBRFlBO0VBQ0UsY0FBQTtFQUNBLGtCQUFBO0VBQ0EsZ0JBTGU7RUFNZixXQUxXO0FDSmI7O0FEWUE7RUFDRSxrQkFBQTtFQUNBLGdCQUFBO0VBQ0EsMkNBQUE7RUFDQSx5QkFBQTtFQUNBLFVBQUE7RUFFQSxjQTdGYztFQThGZCxvQ0FBQTtFQUNBLGtCQUFBO0VBQ0EsZ0JBQUE7RUFDQSw4QkFBQTtFQUNBLCtCQUFBO0VBQ0Esa0JBQUE7RUFDQSxzQkFBQTtBQ1ZGOztBRFlBO0VBQ0UsZUFBQTtFQUNBLG1CQUFBO0VBQ0EsV0FBQTtBQ1RGOztBRFlBO0VBQ0UsWUFBQTtBQ1RGOztBRFlBO0VBQ0UsV0FBQTtBQ1RGOztBRFlBO0VBQ0UseUJBQUE7RUFDQSw2QkFBQTtFQUNBLDRCQUFBO0VBQ0EsMEJBQUE7QUNURjs7QURZQTtFQUNFLGFBQUE7RUFDQSxzQkFBQTtFQUNBLHVCQUFBO0VBQ0EsbUJBQUE7QUNURjs7QURVRTtFQUNFLFdBQUE7RUFDQSxrQkFBQTtBQ1JKOztBRFlBO0VBQ0Usc0JBQUE7RUFDQSxhQUFBO0VBQ0EsOEJBQUE7QUNURjs7QURZQTtFQUNFLGFBQUE7RUFDQSw4QkFBQTtFQUNBLG1CQUFBO0VBQ0EsWUFBQTtBQ1RGOztBRFlBO0VBQ0Usb0JBQUE7QUNURjs7QURjQTtFQUNFLGtCQUFBO0VBQ0EsV0FBQTtFQUNBLGFBQUE7QUNYRjs7QURjQTtFQUNFLGFBQUE7RUFDQSxlQUFBO0FDWEY7O0FEWUU7RUFDRSxnQkFBQTtBQ1ZKOztBRGVBO0VBQ0U7SUFDRSxnQkFBQTtJQUNBLGtCQUFBO0VDWkY7QUFDRjs7QURlQTtFQUNFO0lBQ0UsZ0JBQUE7RUNiRjtBQUNGOztBRGlCQTtFQUNFO0lBQ0UsNEJBQUE7RUNmRjs7RURpQkE7SUFDRSxnQkFBQTtFQ2RGO0FBQ0YiLCJmaWxlIjoic3JjL2FwcC9sb2dpbi9sb2dpbi5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIiRjb2xvci1wcmltYXJ5OiAjZjNmM2YzO1xyXG4kY29sb3ItYWNjZW50OiAjMDY0Nzg5O1xyXG4kY29sb3ItYmFzZTogIzAzQTlGNDtcclxuXHJcbi5idXR0b24tc3BhY2luZyB7XHJcbiAgbWFyZ2luLXRvcDogMWVtO1xyXG4gIG1hcmdpbi1ib3R0b206IDFlbTtcclxufVxyXG5cclxubWF0LXByb2dyZXNzLWJhcntcclxuICBwb3NpdGlvbjogZml4ZWQ7XHJcbiAgdG9wOjA7XHJcbiAgbGVmdDowO1xyXG5cclxufVxyXG5cclxuLmlucHV0LWRpdiB7XHJcbiAgd2lkdGg6IDEwMCU7XHJcbiAgdGV4dC1hbGlnbjogbGVmdDtcclxufVxyXG5cclxuLmxvZ2luIHtcclxuICBkaXNwbGF5OiBmbGV4O1xyXG4gIGZsZXgtZGlyZWN0aW9uOiBjb2x1bW47XHJcbiAganVzdGlmeS1jb250ZW50OiBzcGFjZS1hcm91bmQ7XHJcbiAgYWxpZ24taXRlbXM6IGNlbnRlcjtcclxuICBtaW4td2lkdGg6IDI5MHB4O1xyXG4gIG1hcmdpbjogMCA4MHB4IDAgMDtcclxufVxyXG4uZm9ybSB7XHJcbiAgZGlzcGxheTogZmxleDtcclxufVxyXG5cclxuLmZvcm1fX2ZpZWxkIHtcclxuICBkaXNwbGF5OiBmbGV4O1xyXG4gIGp1c3RpZnktY29udGVudDogZmxleC1zdGFydDtcclxuICBhbGlnbi1pdGVtczogY2VudGVyO1xyXG4gIGFsaWduLWNvbnRlbnQ6IGNlbnRlcjtcclxuICBjb2xvcjogJGNvbG9yLWJhc2U7XHJcbiAgY3Vyc29yOiBwb2ludGVyICFpbXBvcnRhbnQ7XHJcbiAgbWFyZ2luLWJvdHRvbTogMjBweCAhaW1wb3J0YW50O1xyXG4gIHBhZGRpbmc6OHB4O1xyXG4gIGJvcmRlcjoycHggc29saWQgJGNvbG9yLWJhc2U7XHJcbiAgYm9yZGVyLXJhZGl1czogNXB4O1xyXG4gIC8vIGJhY2tncm91bmQ6ICNlMGUwZTA7XHJcbiAgbWF0LWljb24ge1xyXG4gICAgbWFyZ2luLXJpZ2h0OiA1cHg7XHJcbiAgfVxyXG4gIGlucHV0IHtcclxuICAgIGN1cnNvcjogcG9pbnRlcjtcclxuICB9XHJcbn1cclxuXHJcbi5mYXRoZXIge1xyXG4gIGJhY2tncm91bmQtY29sb3I6ICRjb2xvci1iYXNlO1xyXG4gIGJhY2tncm91bmQ6IHVybChodHRwOi8vbG9jYWxob3N0OjMwMDAvZmlsZXMvbm9tYWR3b3JrYmctbHEuanBnKSBuby1yZXBlYXQgY2VudGVyIGNlbnRlciBmaXhlZDtcclxuICAtd2Via2l0LWJhY2tncm91bmQtc2l6ZTogY292ZXI7XHJcbiAgLW1vei1iYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xyXG4gIC1vLWJhY2tncm91bmQtc2l6ZTogY292ZXI7XHJcbiAgYmFja2dyb3VuZC1zaXplOiBjb3ZlcjtcclxuICBmaWx0ZXI6IHByb2dpZDpEWEltYWdlVHJhbnNmb3JtLk1pY3Jvc29mdC5BbHBoYUltYWdlTG9hZGVyKHNyYz0nLm5vbWFkd29ya2JnLmpwZycsIHNpemluZ01ldGhvZD0nc2NhbGUnKTtcclxuICAtbXMtZmlsdGVyOiBcInByb2dpZDpEWEltYWdlVHJhbnNmb3JtLk1pY3Jvc29mdC5BbHBoYUltYWdlTG9hZGVyKHNyYz0nbm9tYWR3b3JrYmcuanBnJywgc2l6aW5nTWV0aG9kPSdzY2FsZScpXCI7XHJcbn1cclxuXHJcbioge1xyXG4gIGJveC1zaXppbmc6IGJvcmRlci1ib3g7XHJcbn1cclxuXHJcbi5hbGlnbiB7XHJcbiBcclxuICAgIGFsaWduLWl0ZW1zOiBjZW50ZXI7XHJcbiAgICBkaXNwbGF5OiBmbGV4O1xyXG4gICAgZmxleC1kaXJlY3Rpb246IHJvdztcclxuICBcclxufVxyXG5cclxuJGlucHV0LXBsYWNlaG9sZGVyLWNvbG9yOiAjN2U4YmEzO1xyXG4kZ3JpZC1tYXgtd2lkdGg6IDI1cmVtO1xyXG4kZ3JpZC13aWR0aDogMTAwJTtcclxuLmdyaWQge1xyXG4gIG1hcmdpbjogMCBhdXRvO1xyXG4gIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICBtYXgtd2lkdGg6ICRncmlkLW1heC13aWR0aDtcclxuICB3aWR0aDogJGdyaWQtd2lkdGg7XHJcbn1cclxuXHJcbi50aXRsZSB7XHJcbiAgZm9udC1zaXplOiAyLjc1cmVtO1xyXG4gIGZvbnQtd2VpZ2h0OiA1MDA7XHJcbiAgYm94LXNoYWRvdzogMCAtNXB4IDEwcHggcmdiYSgwLCAwLCAwLCAwLjc4KTtcclxuICB0ZXh0LXRyYW5zZm9ybTogdXBwZXJjYXNlO1xyXG4gIHotaW5kZXg6IDI7XHJcbiAgLy8gdGV4dC1zaGFkb3c6IDBweCAwIDNweCAkY29sb3ItcHJpbWFyeTtcclxuICBjb2xvcjogJGNvbG9yLXByaW1hcnk7XHJcbiAgYmFja2dyb3VuZDogcmdiYSgzLCAxNjgsIDI0NCwgMC43MzMpO1xyXG4gIGJvcmRlci1yYWRpdXM6IDVweDtcclxuICBwYWRkaW5nOjVweCAwcHg7XHJcbiAgYm9yZGVyLWJvdHRvbS1sZWZ0LXJhZGl1czogMHB4O1xyXG4gIGJvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOiAwcHg7XHJcbiAgcG9zaXRpb246IHJlbGF0aXZlO1xyXG4gIG1hcmdpbjogMjBweCAwIDBweCAwcHg7XHJcbn1cclxuLmNvbnRhaW5lciB7XHJcbiAgZm9udC1zaXplOiAxOHB4O1xyXG4gIGZvbnQtd2VpZ2h0OiBub3JtYWw7XHJcbiAgbWFyZ2luOjBweDtcclxufVxyXG5cclxuLnJhZGlvc3tcclxuICBtYXJnaW46IDIwcHg7XHJcbn1cclxuXHJcbmgyIHtcclxuICBjb2xvcjogIzAwMDtcclxufVxyXG5cclxuLmlucHV0OmRpc2FibGVke1xyXG4gIGNvbG9yOiRjb2xvci1iYXNlIWltcG9ydGFudDtcclxuICBib3JkZXItYm90dG9tOiAwcHggIWltcG9ydGFudDtcclxuICBmb250LXdlaWdodDogYm9sZCFpbXBvcnRhbnQ7XHJcbiAgZm9udC1zaXplOiAxOXB4IWltcG9ydGFudDtcclxufVxyXG5cclxuLmZvcm1SZWdpc3RlciB7XHJcbiAgZGlzcGxheTogZmxleDtcclxuICBmbGV4LWRpcmVjdGlvbjogY29sdW1uO1xyXG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xyXG4gIGFsaWduLWl0ZW1zOiBjZW50ZXI7XHJcbiAgJiA+IGRpdiB7XHJcbiAgICB3aWR0aDogMTAwJTtcclxuICAgIG1hcmdpbjogMCAwIDI1cHggMDtcclxuICB9XHJcbn1cclxuXHJcbi5hbmltYXRlIHtcclxuICB3aWR0aDogY2FsYyg0MDBweCAqIDIpO1xyXG4gIGRpc3BsYXk6IGZsZXg7XHJcbiAganVzdGlmeS1jb250ZW50OiBzcGFjZS1iZXR3ZWVuO1xyXG59XHJcblxyXG4uZXJyb3ItbXNnIHtcclxuICBkaXNwbGF5OiBmbGV4O1xyXG4gIGp1c3RpZnktY29udGVudDogc3BhY2UtYmV0d2VlbjtcclxuICBhbGlnbi1pdGVtczogY2VudGVyO1xyXG4gIHBhZGRpbmc6IDVweDtcclxufVxyXG5cclxuLnJlZ2lzdGVyIHtcclxuICBtYXJnaW46IDAgMCAyMHB4IDBweDtcclxufVxyXG5cclxuXHJcblxyXG4ubGluay1lbnRyYXIge1xyXG4gIHRleHQtYWxpZ246IGNlbnRlcjtcclxuICB3aWR0aDogMTAwJTtcclxuICBwYWRkaW5nOiAxMHB4O1xyXG59XHJcblxyXG4ubGlua19fYm90dG9tIHtcclxuICBwYWRkaW5nOiAxMHB4O1xyXG4gIGN1cnNvcjogcG9pbnRlcjtcclxuICAmOmhvdmVyIHtcclxuICAgIGZvbnQtd2VpZ2h0OiA1MDA7XHJcbiAgfVxyXG59XHJcblxyXG5cclxuQG1lZGlhIChtaW4td2lkdGg6IDM3NHB4KSB7XHJcbiAgLmxvZ2luIHtcclxuICAgIG1pbi13aWR0aDogMzQwcHg7XHJcbiAgICBtYXJnaW46IDAgMzVweCAwIDA7XHJcbiAgfVxyXG59XHJcblxyXG5AbWVkaWEgKG1pbi13aWR0aDogMzc2cHgpIHtcclxuICAubG9naW4ge1xyXG4gICAgbWluLXdpZHRoOiAzNjBweDtcclxuICB9XHJcbn1cclxuXHJcblxyXG5AbWVkaWEgKG1pbi13aWR0aDogNDIwcHgpIHtcclxuICAucmVnaXN0ZXIge1xyXG4gICAgcGFkZGluZzogMnJlbSAycmVtIDByZW0gMnJlbTtcclxuICB9XHJcbiAgLmxvZ2luIHtcclxuICAgIG1pbi13aWR0aDogMzQwcHg7XHJcbiAgfVxyXG59XHJcbiIsIi5idXR0b24tc3BhY2luZyB7XG4gIG1hcmdpbi10b3A6IDFlbTtcbiAgbWFyZ2luLWJvdHRvbTogMWVtO1xufVxuXG5tYXQtcHJvZ3Jlc3MtYmFyIHtcbiAgcG9zaXRpb246IGZpeGVkO1xuICB0b3A6IDA7XG4gIGxlZnQ6IDA7XG59XG5cbi5pbnB1dC1kaXYge1xuICB3aWR0aDogMTAwJTtcbiAgdGV4dC1hbGlnbjogbGVmdDtcbn1cblxuLmxvZ2luIHtcbiAgZGlzcGxheTogZmxleDtcbiAgZmxleC1kaXJlY3Rpb246IGNvbHVtbjtcbiAganVzdGlmeS1jb250ZW50OiBzcGFjZS1hcm91bmQ7XG4gIGFsaWduLWl0ZW1zOiBjZW50ZXI7XG4gIG1pbi13aWR0aDogMjkwcHg7XG4gIG1hcmdpbjogMCA4MHB4IDAgMDtcbn1cblxuLmZvcm0ge1xuICBkaXNwbGF5OiBmbGV4O1xufVxuXG4uZm9ybV9fZmllbGQge1xuICBkaXNwbGF5OiBmbGV4O1xuICBqdXN0aWZ5LWNvbnRlbnQ6IGZsZXgtc3RhcnQ7XG4gIGFsaWduLWl0ZW1zOiBjZW50ZXI7XG4gIGFsaWduLWNvbnRlbnQ6IGNlbnRlcjtcbiAgY29sb3I6ICMwM0E5RjQ7XG4gIGN1cnNvcjogcG9pbnRlciAhaW1wb3J0YW50O1xuICBtYXJnaW4tYm90dG9tOiAyMHB4ICFpbXBvcnRhbnQ7XG4gIHBhZGRpbmc6IDhweDtcbiAgYm9yZGVyOiAycHggc29saWQgIzAzQTlGNDtcbiAgYm9yZGVyLXJhZGl1czogNXB4O1xufVxuLmZvcm1fX2ZpZWxkIG1hdC1pY29uIHtcbiAgbWFyZ2luLXJpZ2h0OiA1cHg7XG59XG4uZm9ybV9fZmllbGQgaW5wdXQge1xuICBjdXJzb3I6IHBvaW50ZXI7XG59XG5cbi5mYXRoZXIge1xuICBiYWNrZ3JvdW5kLWNvbG9yOiAjMDNBOUY0O1xuICBiYWNrZ3JvdW5kOiB1cmwoaHR0cDovL2xvY2FsaG9zdDozMDAwL2ZpbGVzL25vbWFkd29ya2JnLWxxLmpwZykgbm8tcmVwZWF0IGNlbnRlciBjZW50ZXIgZml4ZWQ7XG4gIC13ZWJraXQtYmFja2dyb3VuZC1zaXplOiBjb3ZlcjtcbiAgLW1vei1iYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xuICAtby1iYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xuICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xuICBmaWx0ZXI6IHByb2dpZDpEWEltYWdlVHJhbnNmb3JtLk1pY3Jvc29mdC5BbHBoYUltYWdlTG9hZGVyKHNyYz1cIi5ub21hZHdvcmtiZy5qcGdcIiwgc2l6aW5nTWV0aG9kPVwic2NhbGVcIik7XG4gIC1tcy1maWx0ZXI6IFwicHJvZ2lkOkRYSW1hZ2VUcmFuc2Zvcm0uTWljcm9zb2Z0LkFscGhhSW1hZ2VMb2FkZXIoc3JjPSdub21hZHdvcmtiZy5qcGcnLCBzaXppbmdNZXRob2Q9J3NjYWxlJylcIjtcbn1cblxuKiB7XG4gIGJveC1zaXppbmc6IGJvcmRlci1ib3g7XG59XG5cbi5hbGlnbiB7XG4gIGFsaWduLWl0ZW1zOiBjZW50ZXI7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGZsZXgtZGlyZWN0aW9uOiByb3c7XG59XG5cbi5ncmlkIHtcbiAgbWFyZ2luOiAwIGF1dG87XG4gIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgbWF4LXdpZHRoOiAyNXJlbTtcbiAgd2lkdGg6IDEwMCU7XG59XG5cbi50aXRsZSB7XG4gIGZvbnQtc2l6ZTogMi43NXJlbTtcbiAgZm9udC13ZWlnaHQ6IDUwMDtcbiAgYm94LXNoYWRvdzogMCAtNXB4IDEwcHggcmdiYSgwLCAwLCAwLCAwLjc4KTtcbiAgdGV4dC10cmFuc2Zvcm06IHVwcGVyY2FzZTtcbiAgei1pbmRleDogMjtcbiAgY29sb3I6ICNmM2YzZjM7XG4gIGJhY2tncm91bmQ6IHJnYmEoMywgMTY4LCAyNDQsIDAuNzMzKTtcbiAgYm9yZGVyLXJhZGl1czogNXB4O1xuICBwYWRkaW5nOiA1cHggMHB4O1xuICBib3JkZXItYm90dG9tLWxlZnQtcmFkaXVzOiAwcHg7XG4gIGJvcmRlci1ib3R0b20tcmlnaHQtcmFkaXVzOiAwcHg7XG4gIHBvc2l0aW9uOiByZWxhdGl2ZTtcbiAgbWFyZ2luOiAyMHB4IDAgMHB4IDBweDtcbn1cblxuLmNvbnRhaW5lciB7XG4gIGZvbnQtc2l6ZTogMThweDtcbiAgZm9udC13ZWlnaHQ6IG5vcm1hbDtcbiAgbWFyZ2luOiAwcHg7XG59XG5cbi5yYWRpb3Mge1xuICBtYXJnaW46IDIwcHg7XG59XG5cbmgyIHtcbiAgY29sb3I6ICMwMDA7XG59XG5cbi5pbnB1dDpkaXNhYmxlZCB7XG4gIGNvbG9yOiAjMDNBOUY0ICFpbXBvcnRhbnQ7XG4gIGJvcmRlci1ib3R0b206IDBweCAhaW1wb3J0YW50O1xuICBmb250LXdlaWdodDogYm9sZCAhaW1wb3J0YW50O1xuICBmb250LXNpemU6IDE5cHggIWltcG9ydGFudDtcbn1cblxuLmZvcm1SZWdpc3RlciB7XG4gIGRpc3BsYXk6IGZsZXg7XG4gIGZsZXgtZGlyZWN0aW9uOiBjb2x1bW47XG4gIGp1c3RpZnktY29udGVudDogY2VudGVyO1xuICBhbGlnbi1pdGVtczogY2VudGVyO1xufVxuLmZvcm1SZWdpc3RlciA+IGRpdiB7XG4gIHdpZHRoOiAxMDAlO1xuICBtYXJnaW46IDAgMCAyNXB4IDA7XG59XG5cbi5hbmltYXRlIHtcbiAgd2lkdGg6IGNhbGMoNDAwcHggKiAyKTtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBzcGFjZS1iZXR3ZWVuO1xufVxuXG4uZXJyb3ItbXNnIHtcbiAgZGlzcGxheTogZmxleDtcbiAganVzdGlmeS1jb250ZW50OiBzcGFjZS1iZXR3ZWVuO1xuICBhbGlnbi1pdGVtczogY2VudGVyO1xuICBwYWRkaW5nOiA1cHg7XG59XG5cbi5yZWdpc3RlciB7XG4gIG1hcmdpbjogMCAwIDIwcHggMHB4O1xufVxuXG4ubGluay1lbnRyYXIge1xuICB0ZXh0LWFsaWduOiBjZW50ZXI7XG4gIHdpZHRoOiAxMDAlO1xuICBwYWRkaW5nOiAxMHB4O1xufVxuXG4ubGlua19fYm90dG9tIHtcbiAgcGFkZGluZzogMTBweDtcbiAgY3Vyc29yOiBwb2ludGVyO1xufVxuLmxpbmtfX2JvdHRvbTpob3ZlciB7XG4gIGZvbnQtd2VpZ2h0OiA1MDA7XG59XG5cbkBtZWRpYSAobWluLXdpZHRoOiAzNzRweCkge1xuICAubG9naW4ge1xuICAgIG1pbi13aWR0aDogMzQwcHg7XG4gICAgbWFyZ2luOiAwIDM1cHggMCAwO1xuICB9XG59XG5AbWVkaWEgKG1pbi13aWR0aDogMzc2cHgpIHtcbiAgLmxvZ2luIHtcbiAgICBtaW4td2lkdGg6IDM2MHB4O1xuICB9XG59XG5AbWVkaWEgKG1pbi13aWR0aDogNDIwcHgpIHtcbiAgLnJlZ2lzdGVyIHtcbiAgICBwYWRkaW5nOiAycmVtIDJyZW0gMHJlbSAycmVtO1xuICB9XG5cbiAgLmxvZ2luIHtcbiAgICBtaW4td2lkdGg6IDM0MHB4O1xuICB9XG59Il19 */"

/***/ }),

/***/ "./src/app/login/login.component.ts":
/*!******************************************!*\
  !*** ./src/app/login/login.component.ts ***!
  \******************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _services_user_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../services/user.service */ "./src/app/services/user.service.ts");
/* harmony import */ var _models_user__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../models/user */ "./src/app/models/user.ts");
/* harmony import */ var _services_login_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/login.service */ "./src/app/services/login.service.ts");
/* harmony import */ var ngx_alerts__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ngx-alerts */ "./node_modules/ngx-alerts/fesm2015/ngx-alerts.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _utils_must_match__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../utils/must-match */ "./src/app/utils/must-match.ts");
/* harmony import */ var _angular_animations__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/animations */ "./node_modules/@angular/animations/fesm2015/animations.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");










let LoginComponent = class LoginComponent {
    constructor(loginService, userService, alertService, router, formBuilder) {
        this.loginService = loginService;
        this.userService = userService;
        this.alertService = alertService;
        this.router = router;
        this.formBuilder = formBuilder;
        this.defaultImage = '../../assets/img/nomadworkbg-lq2.jpg';
        this.image = '../../assets/img/nomadworkbg.jpg';
        this.loading = false;
        this.show = true;
        this.step = true;
        this.formNewUser = false;
        this.email = '';
        this.confirmPassword = false;
        this.password = '';
        this.regexEmail = new RegExp(/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/, 'i');
        this.user = new _models_user__WEBPACK_IMPORTED_MODULE_3__["default"]();
    }
    ngOnInit() {
        // Acessando todos os campos do formulario e adicionando validação
        this.formRegister = this.formBuilder.group({
            name: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].minLength(4), _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].maxLength(100)]],
            email: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].email, _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].minLength(4), _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].maxLength(100)]],
            password: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].minLength(10), _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].maxLength(100)]],
            passwordRepeat: [null, [_angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].required]],
            dateborn: [null, _angular_forms__WEBPACK_IMPORTED_MODULE_6__["Validators"].required],
            gender: ['female'],
        }, {
            validator: Object(_utils_must_match__WEBPACK_IMPORTED_MODULE_7__["MustMatch"])('password', 'passwordRepeat')
        });
        const user = localStorage.getItem('user');
        if (user) {
            this.loginService.isLogged = true;
            this.userService.user = JSON.parse(user);
            this.router.navigate(['/']);
        }
    }
    // metodo para animação
    get stateStep() {
        return this.show ? 'show' : 'hide';
    }
    toggle() {
        this.show = !this.show;
    }
    validateEmail() {
        this.loading = true;
        if (this.regexEmail.test(this.email)) {
            this.loginService.verifyEmail(this.email)
                .subscribe((resultApi) => {
                if (resultApi.result) {
                    this.goToStepTwo();
                }
            }, (error) => {
                this.alertService.warning(error.error.message);
                this.loading = false;
            });
        }
        else {
            this.alertService.danger('E-mail não está no formato adequado.');
            this.loading = false;
        }
    }
    login() {
        this.loading = true;
        this.loginService.login(this.email, this.password)
            .subscribe(() => {
            this.loading = false;
        }, (error) => {
            if (error.error && error.error.message) {
                this.alertService.warning(error.error.message);
            }
            this.loading = false;
        });
    }
    verifyEmailSubmit() {
        return this.email.length === 0;
    }
    verifyPasswordSubmit() {
        return this.password.length === 0;
    }
    goToStepTwo() {
        this.emailField.nativeElement.blur();
        this.show = false;
        this.loading = false;
    }
    goStepOne() {
        this.show = true;
    }
    newUser() {
        this.step = false;
        this.formNewUser = true;
    }
    goLogin() {
        this.step = true;
        this.formNewUser = false;
    }
    verifyPassword() {
        return this.passwordOne !== this.passwordTwo;
    }
    registerSubmit() {
        const value = this.formRegister.value;
        value.password = window.btoa(value.password);
        value.gender = +value.gender;
        if (typeof value.dateborn === 'object') {
            const dates = value.dateborn.toISOString().split('T')[0].split('-');
            value.dateborn = `${dates[2]}/${dates[1]}/${dates[0]}`;
        }
        delete value.passwordRepeat;
        this.loginService.register(value)
            .subscribe((resultUser) => {
            this.formRegister.reset();
            this.show = false;
            this.userService.user = resultUser.result.user;
            localStorage.setItem('user', JSON.stringify(resultUser.result.user));
            localStorage.setItem('token', resultUser.result.token.accessToken);
            this.loginService.isLogged = true;
            this.router.navigate(['/']);
            this.alertService.success('Cadastro realizado com sucesso');
        }, (error) => {
            this.alertService.warning(error.error.message);
        });
    }
};
LoginComponent.ctorParameters = () => [
    { type: _services_login_service__WEBPACK_IMPORTED_MODULE_4__["LoginService"] },
    { type: _services_user_service__WEBPACK_IMPORTED_MODULE_2__["UserService"] },
    { type: ngx_alerts__WEBPACK_IMPORTED_MODULE_5__["AlertService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_9__["Router"] },
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormBuilder"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('loginEmail', { static: false })
], LoginComponent.prototype, "emailField", void 0);
LoginComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-login',
        template: __webpack_require__(/*! raw-loader!./login.component.html */ "./node_modules/raw-loader/index.js!./src/app/login/login.component.html"),
        animations: [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["trigger"])('dash', [
                Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["state"])('hide', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["style"])({
                    transform: 'translatex(-375px)',
                })),
                Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["state"])('show', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["style"])({
                    transform: 'translatex(0px)',
                })),
                Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["transition"])('hide <=> show', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_8__["animate"])('500ms cubic-bezier(0.165, 0.84, 0.44, 1)')),
            ])
        ],
        styles: [__webpack_require__(/*! ./login.component.scss */ "./src/app/login/login.component.scss")]
    })
], LoginComponent);



/***/ }),

/***/ "./src/app/models/user.ts":
/*!********************************!*\
  !*** ./src/app/models/user.ts ***!
  \********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function() { return User; });
class User {
    constructor() {
        this.establishmments = [];
    }
}


/***/ }),

/***/ "./src/app/services/auth-guard.service.ts":
/*!************************************************!*\
  !*** ./src/app/services/auth-guard.service.ts ***!
  \************************************************/
/*! exports provided: AuthGuardService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthGuardService", function() { return AuthGuardService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _login_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./login.service */ "./src/app/services/login.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");





let AuthGuardService = class AuthGuardService {
    constructor(loginServe, router) {
        this.loginServe = loginServe;
        this.router = router;
    }
    canActivate(route, state) {
        return this.loginServe.isLoggedIn.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["take"])(1), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["map"])((isLogged) => {
            if (isLogged) {
                return true;
            }
            else {
                this.router.navigate(['/login']);
                return false;
            }
        }));
    }
};
AuthGuardService.ctorParameters = () => [
    { type: _login_service__WEBPACK_IMPORTED_MODULE_2__["LoginService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"] }
];
AuthGuardService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], AuthGuardService);



/***/ }),

/***/ "./src/app/services/establishment.service.ts":
/*!***************************************************!*\
  !*** ./src/app/services/establishment.service.ts ***!
  \***************************************************/
/*! exports provided: EstablishmentService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EstablishmentService", function() { return EstablishmentService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let EstablishmentService = class EstablishmentService {
    constructor(http) {
        this.http = http;
    }
    createEstablishment(establishment) {
        return this.http.post('/api/establishmment', establishment);
    }
    getEstablishment(id) {
        return this.http.get(`/api/establishmment/${id}`);
    }
    getEstablishments(latitude, longitude) {
        return this.http.get(`/api/establishmment/${latitude},${longitude}`);
    }
    getDetailsEstablishment(id) {
        return this.http.get(`/api/establishmment/details/${id}`);
    }
};
EstablishmentService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
EstablishmentService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], EstablishmentService);



/***/ }),

/***/ "./src/app/services/login.service.ts":
/*!*******************************************!*\
  !*** ./src/app/services/login.service.ts ***!
  \*******************************************/
/*! exports provided: LoginService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginService", function() { return LoginService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _user_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./user.service */ "./src/app/services/user.service.ts");







let LoginService = class LoginService {
    constructor(http, router, userService) {
        this.http = http;
        this.router = router;
        this.userService = userService;
        this.loggedIn = new rxjs__WEBPACK_IMPORTED_MODULE_3__["BehaviorSubject"](false);
    }
    get isLoggedIn() {
        return this.loggedIn.asObservable();
    }
    markers() {
        return this.http.get('/api/markers');
    }
    login(email, passwordSimple) {
        const password = window.btoa(passwordSimple);
        return this.http.post('/api/user/login', { email, password })
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["map"])(resultApi => {
            this.userService.user = resultApi.result.user;
            localStorage.setItem('user', JSON.stringify(this.userService.user));
            localStorage.setItem('token', resultApi.result.token.accessToken);
            this.loggedIn.next(true);
            this.router.navigate(['/']);
            return true;
        }));
    }
    set isLogged(flag) {
        this.loggedIn.next(flag);
    }
    register(user) {
        return this.http.post('/api/user/create', user);
    }
    logout() {
        localStorage.removeItem('token');
        localStorage.removeItem('user');
        this.loggedIn.next(false);
        this.router.navigate(['/login']);
    }
    verifyEmail(email) {
        return this.http.get(`/api/user/${email}`);
    }
};
LoginService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_5__["HttpClient"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] },
    { type: _user_service__WEBPACK_IMPORTED_MODULE_6__["UserService"] }
];
LoginService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], LoginService);



/***/ }),

/***/ "./src/app/services/user.service.ts":
/*!******************************************!*\
  !*** ./src/app/services/user.service.ts ***!
  \******************************************/
/*! exports provided: UserService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserService", function() { return UserService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");



let UserService = class UserService {
    constructor() { }
    register(user) {
        return Object(rxjs__WEBPACK_IMPORTED_MODULE_2__["of"])(true);
    }
    get user() {
        return this.userIsLogged;
    }
    set user(user) {
        this.userIsLogged = user;
    }
};
UserService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], UserService);



/***/ }),

/***/ "./src/app/shared.module.ts":
/*!**********************************!*\
  !*** ./src/app/shared.module.ts ***!
  \**********************************/
/*! exports provided: SharedModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SharedModule", function() { return SharedModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_cdk_table__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/cdk/table */ "./node_modules/@angular/cdk/esm2015/table.js");
/* harmony import */ var _angular_cdk_tree__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/cdk/tree */ "./node_modules/@angular/cdk/esm2015/tree.js");
/* harmony import */ var _angular_material_autocomplete__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/material/autocomplete */ "./node_modules/@angular/material/esm2015/autocomplete.js");
/* harmony import */ var _angular_material_badge__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/material/badge */ "./node_modules/@angular/material/esm2015/badge.js");
/* harmony import */ var _angular_material_bottom_sheet__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/material/bottom-sheet */ "./node_modules/@angular/material/esm2015/bottom-sheet.js");
/* harmony import */ var _angular_material_button__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/material/button */ "./node_modules/@angular/material/esm2015/button.js");
/* harmony import */ var _angular_material_button_toggle__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/material/button-toggle */ "./node_modules/@angular/material/esm2015/button-toggle.js");
/* harmony import */ var _angular_material_card__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/material/card */ "./node_modules/@angular/material/esm2015/card.js");
/* harmony import */ var _angular_material_checkbox__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @angular/material/checkbox */ "./node_modules/@angular/material/esm2015/checkbox.js");
/* harmony import */ var _angular_material_chips__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/material/chips */ "./node_modules/@angular/material/esm2015/chips.js");
/* harmony import */ var _angular_material_core__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @angular/material/core */ "./node_modules/@angular/material/esm2015/core.js");
/* harmony import */ var _angular_material_datepicker__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! @angular/material/datepicker */ "./node_modules/@angular/material/esm2015/datepicker.js");
/* harmony import */ var _angular_material_dialog__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/material/dialog */ "./node_modules/@angular/material/esm2015/dialog.js");
/* harmony import */ var _angular_material_divider__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @angular/material/divider */ "./node_modules/@angular/material/esm2015/divider.js");
/* harmony import */ var _angular_material_expansion__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/material/expansion */ "./node_modules/@angular/material/esm2015/expansion.js");
/* harmony import */ var _angular_material_grid_list__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @angular/material/grid-list */ "./node_modules/@angular/material/esm2015/grid-list.js");
/* harmony import */ var _angular_material_icon__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @angular/material/icon */ "./node_modules/@angular/material/esm2015/icon.js");
/* harmony import */ var _angular_material_input__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @angular/material/input */ "./node_modules/@angular/material/esm2015/input.js");
/* harmony import */ var _angular_material_list__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! @angular/material/list */ "./node_modules/@angular/material/esm2015/list.js");
/* harmony import */ var _angular_material_menu__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! @angular/material/menu */ "./node_modules/@angular/material/esm2015/menu.js");
/* harmony import */ var _angular_material_paginator__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! @angular/material/paginator */ "./node_modules/@angular/material/esm2015/paginator.js");
/* harmony import */ var _angular_material_progress_bar__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! @angular/material/progress-bar */ "./node_modules/@angular/material/esm2015/progress-bar.js");
/* harmony import */ var _angular_material_progress_spinner__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! @angular/material/progress-spinner */ "./node_modules/@angular/material/esm2015/progress-spinner.js");
/* harmony import */ var _angular_material_radio__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! @angular/material/radio */ "./node_modules/@angular/material/esm2015/radio.js");
/* harmony import */ var _angular_material_select__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! @angular/material/select */ "./node_modules/@angular/material/esm2015/select.js");
/* harmony import */ var _angular_material_sidenav__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! @angular/material/sidenav */ "./node_modules/@angular/material/esm2015/sidenav.js");
/* harmony import */ var _angular_material_slide_toggle__WEBPACK_IMPORTED_MODULE_28__ = __webpack_require__(/*! @angular/material/slide-toggle */ "./node_modules/@angular/material/esm2015/slide-toggle.js");
/* harmony import */ var _angular_material_slider__WEBPACK_IMPORTED_MODULE_29__ = __webpack_require__(/*! @angular/material/slider */ "./node_modules/@angular/material/esm2015/slider.js");
/* harmony import */ var _angular_material_snack_bar__WEBPACK_IMPORTED_MODULE_30__ = __webpack_require__(/*! @angular/material/snack-bar */ "./node_modules/@angular/material/esm2015/snack-bar.js");
/* harmony import */ var _angular_material_sort__WEBPACK_IMPORTED_MODULE_31__ = __webpack_require__(/*! @angular/material/sort */ "./node_modules/@angular/material/esm2015/sort.js");
/* harmony import */ var _angular_material_stepper__WEBPACK_IMPORTED_MODULE_32__ = __webpack_require__(/*! @angular/material/stepper */ "./node_modules/@angular/material/esm2015/stepper.js");
/* harmony import */ var _angular_material_table__WEBPACK_IMPORTED_MODULE_33__ = __webpack_require__(/*! @angular/material/table */ "./node_modules/@angular/material/esm2015/table.js");
/* harmony import */ var _angular_material_tabs__WEBPACK_IMPORTED_MODULE_34__ = __webpack_require__(/*! @angular/material/tabs */ "./node_modules/@angular/material/esm2015/tabs.js");
/* harmony import */ var _angular_material_toolbar__WEBPACK_IMPORTED_MODULE_35__ = __webpack_require__(/*! @angular/material/toolbar */ "./node_modules/@angular/material/esm2015/toolbar.js");
/* harmony import */ var _angular_material_tooltip__WEBPACK_IMPORTED_MODULE_36__ = __webpack_require__(/*! @angular/material/tooltip */ "./node_modules/@angular/material/esm2015/tooltip.js");
/* harmony import */ var _angular_material_tree__WEBPACK_IMPORTED_MODULE_37__ = __webpack_require__(/*! @angular/material/tree */ "./node_modules/@angular/material/esm2015/tree.js");
/* harmony import */ var ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_38__ = __webpack_require__(/*! ngx-perfect-scrollbar */ "./node_modules/ngx-perfect-scrollbar/dist/ngx-perfect-scrollbar.es5.js");
/* harmony import */ var _utils_error_msg_error_msg_component__WEBPACK_IMPORTED_MODULE_39__ = __webpack_require__(/*! ./utils/error-msg/error-msg.component */ "./src/app/utils/error-msg/error-msg.component.ts");









































const DEFAULT_PERFECT_SCROLLBAR_CONFIG = {
    suppressScrollX: true
};
const modules = [_angular_cdk_table__WEBPACK_IMPORTED_MODULE_2__["CdkTableModule"],
    _angular_cdk_tree__WEBPACK_IMPORTED_MODULE_3__["CdkTreeModule"],
    _angular_material_autocomplete__WEBPACK_IMPORTED_MODULE_4__["MatAutocompleteModule"],
    _angular_material_badge__WEBPACK_IMPORTED_MODULE_5__["MatBadgeModule"],
    _angular_material_bottom_sheet__WEBPACK_IMPORTED_MODULE_6__["MatBottomSheetModule"],
    _angular_material_button__WEBPACK_IMPORTED_MODULE_7__["MatButtonModule"],
    _angular_material_button_toggle__WEBPACK_IMPORTED_MODULE_8__["MatButtonToggleModule"],
    _angular_material_card__WEBPACK_IMPORTED_MODULE_9__["MatCardModule"],
    _angular_material_checkbox__WEBPACK_IMPORTED_MODULE_10__["MatCheckboxModule"],
    _angular_material_chips__WEBPACK_IMPORTED_MODULE_11__["MatChipsModule"],
    _angular_material_stepper__WEBPACK_IMPORTED_MODULE_32__["MatStepperModule"],
    _angular_material_datepicker__WEBPACK_IMPORTED_MODULE_13__["MatDatepickerModule"],
    _angular_material_dialog__WEBPACK_IMPORTED_MODULE_14__["MatDialogModule"],
    _angular_material_divider__WEBPACK_IMPORTED_MODULE_15__["MatDividerModule"],
    _angular_material_expansion__WEBPACK_IMPORTED_MODULE_16__["MatExpansionModule"],
    _angular_material_grid_list__WEBPACK_IMPORTED_MODULE_17__["MatGridListModule"],
    _angular_material_icon__WEBPACK_IMPORTED_MODULE_18__["MatIconModule"],
    _angular_material_input__WEBPACK_IMPORTED_MODULE_19__["MatInputModule"],
    _angular_material_list__WEBPACK_IMPORTED_MODULE_20__["MatListModule"],
    _angular_material_menu__WEBPACK_IMPORTED_MODULE_21__["MatMenuModule"],
    _angular_material_core__WEBPACK_IMPORTED_MODULE_12__["MatNativeDateModule"],
    _angular_material_paginator__WEBPACK_IMPORTED_MODULE_22__["MatPaginatorModule"],
    _angular_material_progress_bar__WEBPACK_IMPORTED_MODULE_23__["MatProgressBarModule"],
    _angular_material_progress_spinner__WEBPACK_IMPORTED_MODULE_24__["MatProgressSpinnerModule"],
    _angular_material_radio__WEBPACK_IMPORTED_MODULE_25__["MatRadioModule"],
    _angular_material_core__WEBPACK_IMPORTED_MODULE_12__["MatRippleModule"],
    _angular_material_select__WEBPACK_IMPORTED_MODULE_26__["MatSelectModule"],
    _angular_material_sidenav__WEBPACK_IMPORTED_MODULE_27__["MatSidenavModule"],
    _angular_material_slider__WEBPACK_IMPORTED_MODULE_29__["MatSliderModule"],
    _angular_material_slide_toggle__WEBPACK_IMPORTED_MODULE_28__["MatSlideToggleModule"],
    _angular_material_snack_bar__WEBPACK_IMPORTED_MODULE_30__["MatSnackBarModule"],
    _angular_material_sort__WEBPACK_IMPORTED_MODULE_31__["MatSortModule"],
    _angular_material_table__WEBPACK_IMPORTED_MODULE_33__["MatTableModule"],
    _angular_material_tabs__WEBPACK_IMPORTED_MODULE_34__["MatTabsModule"],
    _angular_material_toolbar__WEBPACK_IMPORTED_MODULE_35__["MatToolbarModule"],
    _angular_material_tooltip__WEBPACK_IMPORTED_MODULE_36__["MatTooltipModule"],
    _angular_material_tree__WEBPACK_IMPORTED_MODULE_37__["MatTreeModule"],
    ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_38__["PerfectScrollbarModule"]];
let SharedModule = class SharedModule {
};
SharedModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        declarations: [_utils_error_msg_error_msg_component__WEBPACK_IMPORTED_MODULE_39__["ErrorMsgComponent"]],
        imports: modules,
        exports: [modules, _utils_error_msg_error_msg_component__WEBPACK_IMPORTED_MODULE_39__["ErrorMsgComponent"]],
        providers: [{
                provide: ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_38__["PERFECT_SCROLLBAR_CONFIG"],
                useValue: DEFAULT_PERFECT_SCROLLBAR_CONFIG
            }]
    })
], SharedModule);



/***/ }),

/***/ "./src/app/shared/dialog-establishments/dialog-establishments.component.scss":
/*!***********************************************************************************!*\
  !*** ./src/app/shared/dialog-establishments/dialog-establishments.component.scss ***!
  \***********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".mat-dialog-container {\n  overflow: hidden !important;\n  height: auto;\n}\n\n.title-establishment {\n  font-size: 2em;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvc2hhcmVkL2RpYWxvZy1lc3RhYmxpc2htZW50cy9DOlxcVXNlcnNcXGplcnNvXFxEb2N1bWVudHNcXFByb2pldG9zXFxmcm9udGVuZC1ub21hZHdvcmsvc3JjXFxhcHBcXHNoYXJlZFxcZGlhbG9nLWVzdGFibGlzaG1lbnRzXFxkaWFsb2ctZXN0YWJsaXNobWVudHMuY29tcG9uZW50LnNjc3MiLCJzcmMvYXBwL3NoYXJlZC9kaWFsb2ctZXN0YWJsaXNobWVudHMvZGlhbG9nLWVzdGFibGlzaG1lbnRzLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0ksMkJBQUE7RUFDQSxZQUFBO0FDQ0o7O0FERUU7RUFDSSxjQUFBO0FDQ04iLCJmaWxlIjoic3JjL2FwcC9zaGFyZWQvZGlhbG9nLWVzdGFibGlzaG1lbnRzL2RpYWxvZy1lc3RhYmxpc2htZW50cy5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIi5tYXQtZGlhbG9nLWNvbnRhaW5lciB7XHJcbiAgICBvdmVyZmxvdzogaGlkZGVuICFpbXBvcnRhbnQ7XHJcbiAgICBoZWlnaHQ6IGF1dG87XHJcbiAgfVxyXG5cclxuICAudGl0bGUtZXN0YWJsaXNobWVudHtcclxuICAgICAgZm9udC1zaXplOiAyLjBlbTtcclxuICB9IiwiLm1hdC1kaWFsb2ctY29udGFpbmVyIHtcbiAgb3ZlcmZsb3c6IGhpZGRlbiAhaW1wb3J0YW50O1xuICBoZWlnaHQ6IGF1dG87XG59XG5cbi50aXRsZS1lc3RhYmxpc2htZW50IHtcbiAgZm9udC1zaXplOiAyZW07XG59Il19 */"

/***/ }),

/***/ "./src/app/shared/dialog-establishments/dialog-establishments.component.ts":
/*!*********************************************************************************!*\
  !*** ./src/app/shared/dialog-establishments/dialog-establishments.component.ts ***!
  \*********************************************************************************/
/*! exports provided: DialogEstablishmentsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DialogEstablishmentsComponent", function() { return DialogEstablishmentsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_material_dialog__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/material/dialog */ "./node_modules/@angular/material/esm2015/dialog.js");
/* harmony import */ var src_app_services_establishment_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/services/establishment.service */ "./src/app/services/establishment.service.ts");




let DialogEstablishmentsComponent = class DialogEstablishmentsComponent {
    constructor(data, establishmentService, dialogRef) {
        this.data = data;
        this.establishmentService = establishmentService;
        this.dialogRef = dialogRef;
        this.establishments = [];
        this.stepOne = true;
        this.stepTwo = false;
        this.showName = '';
        this.view = [1000, 400];
        // options graphs
        this.showXAxis = true;
        this.showYAxis = true;
        this.gradient = false;
        this.showLegend = true;
        this.showXAxisLabel = true;
        this.xAxisLabel = 'Gênero';
        this.xAxisLabelTwo = 'Anos';
        this.showYAxisLabel = true;
        this.yAxisLabel = 'Quantidade';
        this.yAxisLabelTwo = 'Quantidade';
        this.colorScheme = {
            domain: ['#ff66cc', '#0099ff', '#ffff00']
        };
    }
    ngOnInit() {
        this.establishments = this.data;
    }
    details(id, name) {
        this.showName = name;
        this.establishmentService.getDetailsEstablishment(id)
            .subscribe(resultApi => {
            const single = resultApi.result.sex;
            const singleTwo = resultApi.result.age;
            Object.assign(this, { single });
            Object.assign(this, { singleTwo });
        }, error => console.log(error));
        this.changeStep();
    }
    changeStep() {
        this.stepOne = !this.stepOne;
        this.stepTwo = !this.stepTwo;
    }
};
DialogEstablishmentsComponent.ctorParameters = () => [
    { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"], args: [_angular_material_dialog__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"],] }] },
    { type: src_app_services_establishment_service__WEBPACK_IMPORTED_MODULE_3__["EstablishmentService"] },
    { type: _angular_material_dialog__WEBPACK_IMPORTED_MODULE_2__["MatDialogRef"] }
];
DialogEstablishmentsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-dialog-establishments',
        template: __webpack_require__(/*! raw-loader!./dialog-establishments.component.html */ "./node_modules/raw-loader/index.js!./src/app/shared/dialog-establishments/dialog-establishments.component.html"),
        styles: [__webpack_require__(/*! ./dialog-establishments.component.scss */ "./src/app/shared/dialog-establishments/dialog-establishments.component.scss")]
    }),
    tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](0, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_angular_material_dialog__WEBPACK_IMPORTED_MODULE_2__["MAT_DIALOG_DATA"]))
], DialogEstablishmentsComponent);



/***/ }),

/***/ "./src/app/utils/error-msg/error-msg.component.scss":
/*!**********************************************************!*\
  !*** ./src/app/utils/error-msg/error-msg.component.scss ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "span {\n  font-style: italic;\n  font-weight: bold;\n  margin-top: 0px;\n  padding-top: 0px;\n  font-size: 12px;\n}\n\ndiv {\n  color: red;\n  display: flex;\n  align-items: center;\n  justify-content: space-between;\n}\n\ndiv .material-icons {\n  font-size: 20px !important;\n}\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvdXRpbHMvZXJyb3ItbXNnL0M6XFxVc2Vyc1xcamVyc29cXERvY3VtZW50c1xcUHJvamV0b3NcXGZyb250ZW5kLW5vbWFkd29yay9zcmNcXGFwcFxcdXRpbHNcXGVycm9yLW1zZ1xcZXJyb3ItbXNnLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC91dGlscy9lcnJvci1tc2cvZXJyb3ItbXNnLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0VBQ0Usa0JBQUE7RUFDQSxpQkFBQTtFQUNBLGVBQUE7RUFDQSxnQkFBQTtFQUNBLGVBQUE7QUNDRjs7QURHQTtFQUNFLFVBQUE7RUFDQSxhQUFBO0VBQ0EsbUJBQUE7RUFDQSw4QkFBQTtBQ0FGOztBRENFO0VBQ0UsMEJBQUE7QUNDSiIsImZpbGUiOiJzcmMvYXBwL3V0aWxzL2Vycm9yLW1zZy9lcnJvci1tc2cuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyJzcGFue1xyXG4gIGZvbnQtc3R5bGU6IGl0YWxpYztcclxuICBmb250LXdlaWdodDogYm9sZDtcclxuICBtYXJnaW4tdG9wOiAwcHg7XHJcbiAgcGFkZGluZy10b3A6IDBweDtcclxuICBmb250LXNpemU6IDEycHg7XHJcblxyXG59XHJcblxyXG5kaXZ7XHJcbiAgY29sb3I6cmVkO1xyXG4gIGRpc3BsYXk6IGZsZXg7XHJcbiAgYWxpZ24taXRlbXM6IGNlbnRlcjtcclxuICBqdXN0aWZ5LWNvbnRlbnQ6IHNwYWNlLWJldHdlZW47XHJcbiAgLm1hdGVyaWFsLWljb25ze1xyXG4gICAgZm9udC1zaXplOiAyMHB4IWltcG9ydGFudDtcclxuICB9XHJcbn1cclxuIiwic3BhbiB7XG4gIGZvbnQtc3R5bGU6IGl0YWxpYztcbiAgZm9udC13ZWlnaHQ6IGJvbGQ7XG4gIG1hcmdpbi10b3A6IDBweDtcbiAgcGFkZGluZy10b3A6IDBweDtcbiAgZm9udC1zaXplOiAxMnB4O1xufVxuXG5kaXYge1xuICBjb2xvcjogcmVkO1xuICBkaXNwbGF5OiBmbGV4O1xuICBhbGlnbi1pdGVtczogY2VudGVyO1xuICBqdXN0aWZ5LWNvbnRlbnQ6IHNwYWNlLWJldHdlZW47XG59XG5kaXYgLm1hdGVyaWFsLWljb25zIHtcbiAgZm9udC1zaXplOiAyMHB4ICFpbXBvcnRhbnQ7XG59Il19 */"

/***/ }),

/***/ "./src/app/utils/error-msg/error-msg.component.ts":
/*!********************************************************!*\
  !*** ./src/app/utils/error-msg/error-msg.component.ts ***!
  \********************************************************/
/*! exports provided: ErrorMsgComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ErrorMsgComponent", function() { return ErrorMsgComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _form_validations__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../form-validations */ "./src/app/utils/form-validations.ts");



let ErrorMsgComponent = class ErrorMsgComponent {
    constructor() { }
    ngOnInit() {
    }
    get errorMessage() {
        for (const propertyName in this.control.errors) {
            if (this.control.errors.hasOwnProperty(propertyName) &&
                this.control.dirty || this.control.touched) {
                return _form_validations__WEBPACK_IMPORTED_MODULE_2__["FormValidations"].getErrorMsg(this.label, propertyName, this.control.errors[propertyName]);
            }
        }
        return null;
    }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], ErrorMsgComponent.prototype, "label", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], ErrorMsgComponent.prototype, "control", void 0);
ErrorMsgComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-error-msg',
        template: __webpack_require__(/*! raw-loader!./error-msg.component.html */ "./node_modules/raw-loader/index.js!./src/app/utils/error-msg/error-msg.component.html"),
        styles: [__webpack_require__(/*! ./error-msg.component.scss */ "./src/app/utils/error-msg/error-msg.component.scss")]
    })
], ErrorMsgComponent);



/***/ }),

/***/ "./src/app/utils/form-validations.ts":
/*!*******************************************!*\
  !*** ./src/app/utils/form-validations.ts ***!
  \*******************************************/
/*! exports provided: FormValidations */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FormValidations", function() { return FormValidations; });
class FormValidations {
    static getErrorMsg(nomeCampo, nomeValidacao, valorValidacao) {
        const config = {
            required: `${nomeCampo} é obrigatório.`,
            minlength: `${nomeCampo} com no mínimo ${valorValidacao.requiredLength} caracteres`,
            maxlength: `${nomeCampo} com no máximo ${valorValidacao.requiredLength} caracteres`,
            email: `Digite um E-mail válido`,
            mustMatch: `As senhas não coincidem`
        };
        return config[nomeValidacao];
    }
}


/***/ }),

/***/ "./src/app/utils/must-match.ts":
/*!*************************************!*\
  !*** ./src/app/utils/must-match.ts ***!
  \*************************************/
/*! exports provided: MustMatch */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MustMatch", function() { return MustMatch; });
// custom validator to check that two fields match
function MustMatch(controlName, matchingControlName) {
    return (formGroup) => {
        const control = formGroup.controls[controlName];
        const matchingControl = formGroup.controls[matchingControlName];
        if (matchingControl.errors && !matchingControl.errors.mustMatch) {
            // return if another validator has already found an error on the matchingControl
            return;
        }
        // set error on matchingControl if validation fails
        if (control.value !== matchingControl.value) {
            matchingControl.setErrors({ mustMatch: true });
        }
        else {
            matchingControl.setErrors(null);
        }
    };
}


/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
const environment = {
    production: false,
    baseUrl: ''
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/icons.ts":
/*!**********************!*\
  !*** ./src/icons.ts ***!
  \**********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _fortawesome_fontawesome_svg_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @fortawesome/fontawesome-svg-core */ "./node_modules/@fortawesome/fontawesome-svg-core/index.es.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faFacebookF__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faFacebookF */ "./node_modules/@fortawesome/free-brands-svg-icons/faFacebookF.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faFacebookF__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faFacebookF__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faTwitter__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faTwitter */ "./node_modules/@fortawesome/free-brands-svg-icons/faTwitter.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faTwitter__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faTwitter__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faRedditAlien__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faRedditAlien */ "./node_modules/@fortawesome/free-brands-svg-icons/faRedditAlien.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faRedditAlien__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faRedditAlien__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faLinkedinIn__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faLinkedinIn */ "./node_modules/@fortawesome/free-brands-svg-icons/faLinkedinIn.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faLinkedinIn__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faLinkedinIn__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faGooglePlusG__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faGooglePlusG */ "./node_modules/@fortawesome/free-brands-svg-icons/faGooglePlusG.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faGooglePlusG__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faGooglePlusG__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faTumblr__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faTumblr */ "./node_modules/@fortawesome/free-brands-svg-icons/faTumblr.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faTumblr__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faTumblr__WEBPACK_IMPORTED_MODULE_6__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faPinterestP__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faPinterestP */ "./node_modules/@fortawesome/free-brands-svg-icons/faPinterestP.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faPinterestP__WEBPACK_IMPORTED_MODULE_7___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faPinterestP__WEBPACK_IMPORTED_MODULE_7__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faWhatsapp__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faWhatsapp */ "./node_modules/@fortawesome/free-brands-svg-icons/faWhatsapp.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faWhatsapp__WEBPACK_IMPORTED_MODULE_8___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faWhatsapp__WEBPACK_IMPORTED_MODULE_8__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faVk__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faVk */ "./node_modules/@fortawesome/free-brands-svg-icons/faVk.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faVk__WEBPACK_IMPORTED_MODULE_9___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faVk__WEBPACK_IMPORTED_MODULE_9__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faFacebookMessenger__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faFacebookMessenger */ "./node_modules/@fortawesome/free-brands-svg-icons/faFacebookMessenger.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faFacebookMessenger__WEBPACK_IMPORTED_MODULE_10___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faFacebookMessenger__WEBPACK_IMPORTED_MODULE_10__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faTelegramPlane__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faTelegramPlane */ "./node_modules/@fortawesome/free-brands-svg-icons/faTelegramPlane.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faTelegramPlane__WEBPACK_IMPORTED_MODULE_11___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faTelegramPlane__WEBPACK_IMPORTED_MODULE_11__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faMix__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faMix */ "./node_modules/@fortawesome/free-brands-svg-icons/faMix.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faMix__WEBPACK_IMPORTED_MODULE_12___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faMix__WEBPACK_IMPORTED_MODULE_12__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faXing__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faXing */ "./node_modules/@fortawesome/free-brands-svg-icons/faXing.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faXing__WEBPACK_IMPORTED_MODULE_13___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faXing__WEBPACK_IMPORTED_MODULE_13__);
/* harmony import */ var _fortawesome_free_brands_svg_icons_faLine__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @fortawesome/free-brands-svg-icons/faLine */ "./node_modules/@fortawesome/free-brands-svg-icons/faLine.js");
/* harmony import */ var _fortawesome_free_brands_svg_icons_faLine__WEBPACK_IMPORTED_MODULE_14___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_brands_svg_icons_faLine__WEBPACK_IMPORTED_MODULE_14__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faCommentAlt__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faCommentAlt */ "./node_modules/@fortawesome/free-solid-svg-icons/faCommentAlt.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faCommentAlt__WEBPACK_IMPORTED_MODULE_15___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faCommentAlt__WEBPACK_IMPORTED_MODULE_15__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faMinus__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faMinus */ "./node_modules/@fortawesome/free-solid-svg-icons/faMinus.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faMinus__WEBPACK_IMPORTED_MODULE_16___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faMinus__WEBPACK_IMPORTED_MODULE_16__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faEllipsisH__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faEllipsisH */ "./node_modules/@fortawesome/free-solid-svg-icons/faEllipsisH.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faEllipsisH__WEBPACK_IMPORTED_MODULE_17___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faEllipsisH__WEBPACK_IMPORTED_MODULE_17__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faLink__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faLink */ "./node_modules/@fortawesome/free-solid-svg-icons/faLink.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faLink__WEBPACK_IMPORTED_MODULE_18___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faLink__WEBPACK_IMPORTED_MODULE_18__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faExclamation__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faExclamation */ "./node_modules/@fortawesome/free-solid-svg-icons/faExclamation.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faExclamation__WEBPACK_IMPORTED_MODULE_19___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faExclamation__WEBPACK_IMPORTED_MODULE_19__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faPrint__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faPrint */ "./node_modules/@fortawesome/free-solid-svg-icons/faPrint.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faPrint__WEBPACK_IMPORTED_MODULE_20___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faPrint__WEBPACK_IMPORTED_MODULE_20__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faCheck__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faCheck */ "./node_modules/@fortawesome/free-solid-svg-icons/faCheck.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faCheck__WEBPACK_IMPORTED_MODULE_21___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faCheck__WEBPACK_IMPORTED_MODULE_21__);
/* harmony import */ var _fortawesome_free_solid_svg_icons_faEnvelope__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons/faEnvelope */ "./node_modules/@fortawesome/free-solid-svg-icons/faEnvelope.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons_faEnvelope__WEBPACK_IMPORTED_MODULE_22___default = /*#__PURE__*/__webpack_require__.n(_fortawesome_free_solid_svg_icons_faEnvelope__WEBPACK_IMPORTED_MODULE_22__);























const icons = [
    _fortawesome_free_brands_svg_icons_faFacebookF__WEBPACK_IMPORTED_MODULE_1__["faFacebookF"], _fortawesome_free_brands_svg_icons_faTwitter__WEBPACK_IMPORTED_MODULE_2__["faTwitter"], _fortawesome_free_brands_svg_icons_faLinkedinIn__WEBPACK_IMPORTED_MODULE_4__["faLinkedinIn"], _fortawesome_free_brands_svg_icons_faGooglePlusG__WEBPACK_IMPORTED_MODULE_5__["faGooglePlusG"], _fortawesome_free_brands_svg_icons_faPinterestP__WEBPACK_IMPORTED_MODULE_7__["faPinterestP"], _fortawesome_free_brands_svg_icons_faRedditAlien__WEBPACK_IMPORTED_MODULE_3__["faRedditAlien"], _fortawesome_free_brands_svg_icons_faTumblr__WEBPACK_IMPORTED_MODULE_6__["faTumblr"],
    _fortawesome_free_brands_svg_icons_faWhatsapp__WEBPACK_IMPORTED_MODULE_8__["faWhatsapp"], _fortawesome_free_brands_svg_icons_faVk__WEBPACK_IMPORTED_MODULE_9__["faVk"], _fortawesome_free_brands_svg_icons_faFacebookMessenger__WEBPACK_IMPORTED_MODULE_10__["faFacebookMessenger"], _fortawesome_free_brands_svg_icons_faTelegramPlane__WEBPACK_IMPORTED_MODULE_11__["faTelegramPlane"], _fortawesome_free_brands_svg_icons_faMix__WEBPACK_IMPORTED_MODULE_12__["faMix"], _fortawesome_free_brands_svg_icons_faXing__WEBPACK_IMPORTED_MODULE_13__["faXing"], _fortawesome_free_solid_svg_icons_faCommentAlt__WEBPACK_IMPORTED_MODULE_15__["faCommentAlt"], _fortawesome_free_brands_svg_icons_faLine__WEBPACK_IMPORTED_MODULE_14__["faLine"],
    _fortawesome_free_solid_svg_icons_faEnvelope__WEBPACK_IMPORTED_MODULE_22__["faEnvelope"], _fortawesome_free_solid_svg_icons_faCheck__WEBPACK_IMPORTED_MODULE_21__["faCheck"], _fortawesome_free_solid_svg_icons_faPrint__WEBPACK_IMPORTED_MODULE_20__["faPrint"], _fortawesome_free_solid_svg_icons_faExclamation__WEBPACK_IMPORTED_MODULE_19__["faExclamation"], _fortawesome_free_solid_svg_icons_faLink__WEBPACK_IMPORTED_MODULE_18__["faLink"], _fortawesome_free_solid_svg_icons_faEllipsisH__WEBPACK_IMPORTED_MODULE_17__["faEllipsisH"], _fortawesome_free_solid_svg_icons_faMinus__WEBPACK_IMPORTED_MODULE_16__["faMinus"],
];
_fortawesome_fontawesome_svg_core__WEBPACK_IMPORTED_MODULE_0__["library"].add(...icons);


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
/* harmony import */ var _icons__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./icons */ "./src/icons.ts");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");
/* harmony import */ var hammerjs__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! hammerjs */ "./node_modules/hammerjs/hammer.js");
/* harmony import */ var hammerjs__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(hammerjs__WEBPACK_IMPORTED_MODULE_5__);






if (_environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_3__["AppModule"])
    .catch(err => console.error(err));


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\jerso\Documents\Projetos\frontend-nomadwork\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main-es2015.js.map