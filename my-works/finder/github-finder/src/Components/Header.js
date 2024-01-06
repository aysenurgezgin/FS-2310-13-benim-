import React from 'react'
import { Container, Nav, Navbar, NavbarBrand } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';

const Header = () => {
  return (
    <>
      <Navbar bg='primary' variant='dark'>
        <Container>
          <NavbarBrand>
            <NavLink className="nav-link" to="/">
             Github Kullanıcısı Bulma Uygulaması
            </NavLink>
          </NavbarBrand>
          <Nav className="ms-auto">
            <NavLink className="nav-link" to="/">Ana Sayfa</NavLink>
            <NavLink className="nav-link" to="/search">Arama</NavLink>
          </Nav>
        </Container>
      </Navbar>
    </>
  )
}

export default Header;

//navbarbrand kısmı benim markamın/sitemin adını gösteren link
//diğer nav diğer menü seçeneklerimin kapsayıcısı olan nav 