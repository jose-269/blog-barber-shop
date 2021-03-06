body {
  margin: 0;
  background-color: #fff;
}

a, p {
  font-family: "Roboto", sans-serif;
}

h1, h4 {
  font-family: "Playfair Display", serif;
}

.header {
  background-image: url(../img/post-image.jpg);
  background-repeat: no-repeat;
  background-size: cover;
  height: 100vh;
  color: #fff;
}

.flex-container {
  display: flex;
  text-align: center;
  align-items: center;
  justify-content: center;
}

.header-title {
  font-weight: 900;
  font-size: 70px;
  width: 51.6%;
  margin: 0;
}

@media only screen and (max-width: 767px) {
  .header-title {
    font-size: 40px;
    width: 76%;
  }
}
.footer-section {
  background-color: #121619;
}

.footer-logo img {
  width: 122px;
  margin: 0;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}

.footer-logo {
  height: 206px;
  position: relative;
}

.naomi-section {
  margin: 58px 0 92px 0;
  padding: 0 100px;
  text-align: center;
}

@media only screen and (max-width: 992px) {
  .naomi-section {
    margin: 61px 0 62px 0;
  }
}
.naomi-title {
  font-weight: 900;
  font-size: 30px;
  margin-bottom: 5px;
}

.naomi-img {
  width: 140px;
  clip-path: circle(50%);
}

@media only screen and (max-width: 767px) {
  .naomi-img {
    width: 131px;
  }
}
.naomi-data p, a {
  font-weight: 300;
  font-size: 18px;
  margin: 0;
  color: #D76C69;
}
.naomi-data p:hover, a:hover {
  color: #222323;
  text-decoration: none;
}

.naomi-desc {
  font-weight: 400;
  font-size: 12px;
  line-height: 35px;
  padding-top: 1rem;
}

@media only screen and (max-width: 1200px) and (min-width: 992px) {
  .naomi-desc {
    font-size: 8px;
  }
}
.naomi_desc__container {
  margin: auto 0;
}

.naomi-data__container {
  padding-left: 50px;
  margin: auto 0;
}

@media only screen and (max-width: 767px) {
  .naomi-data__container {
    padding-left: 0px;
    padding-top: 17px;
  }
}
.main-date {
  font-family: "Playfair Display", serif;
  font-weight: 400;
  font-size: 18px;
  color: #222323;
  margin: 0;
  padding: 4.625rem 0 4.125rem 6.25rem;
}

.main-column {
  font-weight: 300;
  font-size: 16px;
  color: #222323;
  padding: 0 6.25rem 2.8125rem 6.25rem;
  margin: 0;
  line-height: 2.8125rem;
}

@media only screen and (max-width: 576px) {
  .main-column {
    padding: 0 50px 45px 50px;
  }
}
.button-section {
  padding: 0 100px;
}

@media only screen and (max-width: 576px) {
  .button-section {
    padding: 0 50px;
  }
}
@media only screen and (max-width: 767px) {
  .button-section {
    text-align: center;
  }
}
.button {
  height: 51px;
  background-color: #6C6E70;
  color: #fff;
  border: 1px solid #707070;
  border-radius: 30px;
}

.button__share {
  width: 115px;
  margin-right: 12px;
}
.button__share:hover {
  background-color: #D1D1D1;
}

.button__comment {
  width: 182px;
}
.button__comment:hover {
  background-color: #D1D1D1;
}

@media only screen and (max-width: 576px) {
  .button__share {
    width: 95px;
    font-size: 0.9rem;
  }

  .button__comment {
    width: 150px;
    font-size: 0.9rem;
  }
}
@media only screen and (max-width: 461px) {
  .button__share {
    width: 80px;
    font-size: 0.9;
  }

  .button__comment {
    width: 120px;
    font-size: 0.7rem;
  }
}
.pagination .page-link {
  color: #121619;
}

.pagination-section {
  background-color: #E6E7E7;
}

.pagination__item:first-child .page-link {
  border-top-left-radius: 50px;
  border-bottom-left-radius: 50px;
  color: #777777;
}

.pagination__item:last-child .page-link {
  border-top-right-radius: 50px;
  border-bottom-right-radius: 50px;
}

.pagination {
  margin: 0;
  padding: 47px 0;
  justify-content: center;
  /*&__item .page-link:hover{
      background-color: $nickel;
      color: $white;
  }*/
}
.pagination__item:nth-child(3) .page-link {
  background-color: #6C6E70;
  color: #fff;
}

.nav-barra {
  background-color: #121619;
  padding: 1.11875rem;
}
.nav-barra__link:hover {
  color: #D76C69;
  text-decoration: none;
}

.nav-barra__link {
  color: #fff;
  padding: 0.5rem 0.5rem;
}

.logo-barber {
  width: 4.9rem;
}

/*# sourceMappingURL=main.cs.map */
