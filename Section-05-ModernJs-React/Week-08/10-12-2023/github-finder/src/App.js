import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import HomePage from './Pages/HomePage/HomePage.js';
import SearchPage from './Pages/SearchPage/SearchPage.js';
import Footer from './Pages/Footer/Footer.js';
import { AppContext } from './Contexts/AppContext.js';
import { useEffect, useState } from 'react';
import Axios from 'axios';

function App() {
  const [users, setUsers] = useState([]);
  const [user, setUser] = useState({});
  const [userRepos, setUserRepos] = useState([]);
  const [isClearButtonShow, setIsClearButtonShow] = useState(false);





  const token = "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";
  const config = {
    headers: { Authorization: `Bearer ${token}` }
  }


  const searchUsers = (keyword) => {
    Axios
      .get(`https://api.github.com/search/users?q=${keyword}`, config)
      .then((response) => {
        setUsers(response.data.items);
        response.data.items.length==0 ? setIsClearButtonShow(false): setIsClearButtonShow(true);
      })
  }

  const getUser = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}`, config)
      .then(response => { setUser(response.data) });
  }

  const getRepos = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}/repos`, config)
      .then(response => { setUserRepos(response.data) });
  }



  // useEffect(() => {
  //   searchUsers();
  // }, []);

  return (
    <>
      <AppContext.Provider value={{ users, getUser,setUser, user, userRepos, getRepos, searchUsers, setUsers, isClearButtonShow, setIsClearButtonShow }}>
        <BrowserRouter>
          <Header />
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/search" element={<SearchPage />} />
        

          </Routes>
          <Footer />
        </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;


//geri gelince sıfırlansın setKeyword kısmında Serach form kısmanıda