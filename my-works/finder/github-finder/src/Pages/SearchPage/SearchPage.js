import React from 'react'
import SearchForm from '../../Components/SearchForm';
import Users from '../../Components/Users';

const SearchPage = () => {
  return (
    <>
    <SearchForm />
    {/* Buraya Serach işlemi için bir component birde sonuçları göstermek için bir componente tasarlayacağız */}
    <Users />
    </>
  )
}

export default SearchPage;