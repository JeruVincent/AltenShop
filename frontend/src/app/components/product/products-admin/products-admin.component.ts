import { Component, OnInit } from '@angular/core';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { Table } from 'primeng/table';
import { Product } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';
import { ProductModalComponent } from '../../shared/product-modal/product-modal.component';
import { MenuItem, PrimeIcons } from 'primeng/api';
import { Observable, forkJoin } from 'rxjs';

@Component({
  selector: 'app-products-admin',
  templateUrl: './products-admin.component.html',
  styleUrls: ['./products-admin.component.scss']
})
export class ProductsAdminComponent implements OnInit {

  products: Product[] = [];
  selectedProducts: Product[] = [];
  loading: boolean = true;

  items: MenuItem[] = [];


  ref!: DynamicDialogRef;

  constructor(private productService: ProductService, private dialogService: DialogService){}

  ngOnInit(): void {
    this.productService.getProducts().subscribe((products) => {
      this.products = products;
      this.loading = false;
    });
  }

  clearTable(table: Table){
    table.clear();
  }

  addNewProduct(){
    this.ref = this.dialogService.open(ProductModalComponent, {
      header: 'Please define the new product to add',
      width: '50vw',
      modal:true,
    }); 
    
    this.ref.onClose.subscribe((newProduct: Product) => {
      if(newProduct){
        this.productService.addProduct(newProduct).subscribe((response) => {
          
        });
      }
    });
  }
  
  editProduct(product: Product){
    this.ref = this.dialogService.open(ProductModalComponent, {
      header: "Please update the product's data",
      width: '50vw',
      modal:true,
      data: {
        product: product
      }
    });

    this.ref.onClose.subscribe((editProduct: Product) => {
      if(editProduct){
        this.productService.editProduct(editProduct).subscribe((response) => {
        });
      }
    });
    
  }
  
  deleteProducts(productId: number = 0){
    if(productId !== 0){
      this.productService.deleteProduct(productId).subscribe((response) => {
        this.products.splice(this.products.findIndex(t => t.id === productId), 1);
        this.products = [...this.products];
      });
    } else {
      let calls: Observable<boolean>[] = [];
      this.selectedProducts.forEach(product => {
        calls.push(this.productService.deleteProduct(product.id));
      });
      forkJoin(calls).subscribe((responses) => {
        this.selectedProducts.forEach(product => {
          this.products.splice(this.products.findIndex(t => t.id === product.id), 1);
        });
        this.products = [...this.products];
      });
    }
  }
}
