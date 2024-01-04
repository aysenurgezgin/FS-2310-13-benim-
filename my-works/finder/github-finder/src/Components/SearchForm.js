import React from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap';

const SearchForm = () => {
    const handleSubmit= (e)=>{
        e.preventDefault();
        
    }
  return (
    <>
        <Container className='py-3'>
            <Form onSubmit={handleSubmit}>
                <InputGroup>
                <Form.Control placeholder='Aramak istediğiniz kullanıcı adını yazınız'>
                </Form.Control>
                <Button variant='success' type='submit'>Arama</Button>
                </InputGroup>
            </Form>
        </Container>
    </>
  )
}

export default SearchForm;