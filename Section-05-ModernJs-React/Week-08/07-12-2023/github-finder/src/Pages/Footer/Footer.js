import React from 'react'
import { Alert, Container } from 'react-bootstrap';

const Footer = () => {
    return (
        <>

            <Alert variant='info' >
                <Container >
                    Bu uygulama  FS-2310 sınıfı tarafından oluşturulmuştur
                </Container>
            </Alert>

        </>
    )
}

export default Footer;