export interface orderdetails{
    name: string,
    address: string,
    modeOfPayment: string, 
    shopAddressId : number,

    products:productdetails[]
}

export interface productdetails{
    cartId : number,
    orderQuantity: number
}