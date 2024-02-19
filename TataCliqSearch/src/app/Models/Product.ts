export interface Product{
    addedToCart: boolean;
    addedToWishlist: boolean;
    productId : number,
    productName : string,
    productDescription :string,
    actualProductPrice : number,
    discountPercentage : number,
    finalProductPrice : number,
    stockQuantity : number,
    categoryId :number,
    categoryName : string,
    brandId : number,
    brandName : string,
    isDeleted : boolean,
    // createdOn: Date,
    
}