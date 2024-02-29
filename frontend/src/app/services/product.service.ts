import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Product } from '../models/product';
import { ApiResponse } from '../models/api-response';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  backendURL: string = "https://localhost:7128/api/";

  constructor(private http: HttpClient) { }

  getProducts(): Observable<Product[]>{
    return this.http.get<Product[]>(this.backendURL + "product");
  }

  getProductByID(id: number): Observable<Product>{
    return this.http.get<Product>(this.backendURL + `product/${id}`);
  }

  addProduct(product: Product): Observable<Product>{
    return this.http.post<Product>(this.backendURL + "product", product);
  }

  editProduct(product: Product): Observable<Product>{
    return this.http.patch<Product>(this.backendURL + `product/${product.id}`, product);
  }

  deleteProduct(id: number): Observable<boolean>{
    return this.http.delete<boolean>(this.backendURL + `product/${id}`);
  }
}
