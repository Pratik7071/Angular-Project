export interface Cart {
    cartId : number,
    productId : number,
    productName : string,
    finalProductPrice : number,
    categoryName: string,
    brandName: string,
    isDeleted : boolean,
    createdOn: Date,
    modifiedOn : Date,
    orderQuantity: number
}