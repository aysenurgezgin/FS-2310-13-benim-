import React from 'react'

function Product({product}) {
    console.log(product);
  return (
    <>
        <h1>{product.name}</h1>
        <p>Ürün açıklaması burada</p>
        <p>Fiyat</p>
    </>
  )
}

export default Product