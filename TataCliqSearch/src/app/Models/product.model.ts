export interface Product {
    productId: number;
    productName: string;
    productDescription: string;
    actualProductPrice: number,
    discountPercentage: number,
    finalProductPrice: number,
    stockQuantity: number,
    categoryID: number,
    categoryName: string,
    brandID: number,
    brandName: string,
    isDeleted: boolean
}

