import React from 'react'
import { Alert, Container } from 'react-bootstrap';

const Footer = () => {
    return (
        <>

            <Alert variant='info'>
                <Container>
                    Bu uygulama  JS ile React'ı kullanmayı daha iyi anlayabilmek amacıyla geliştirilmiştir.
                </Container>
            </Alert>


        </>
    )
}

export default Footer;