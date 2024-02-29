import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { FileUpload } from 'primeng/fileupload';
import { Product } from 'src/app/models/product';
import { ProductForm } from 'src/app/models/product-form';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product-modal',
  templateUrl: './product-modal.component.html',
  styleUrls: ['./product-modal.component.scss']
})
export class ProductModalComponent {

  form!: FormGroup<ProductForm>;
  uploadedFile: any;
  editingMode: boolean = false;

  constructor(private ref: DynamicDialogRef, public config: DynamicDialogConfig, private messageService: MessageService, private productService: ProductService){
    if(!config?.data?.product){
      this.form = new FormGroup<ProductForm>({
        code: new FormControl('', {nonNullable: true, validators: [Validators.required, Validators.maxLength(4)]}),
        name: new FormControl('', {nonNullable: true, validators: [Validators.required, Validators.minLength(3), Validators.maxLength(32)]}),
        description: new FormControl('', {nonNullable: true, validators: [Validators.required, Validators.maxLength(256), Validators.minLength(32)]}),
        image: new FormControl('', {nonNullable: true}),
        price: new FormControl(0, {nonNullable: true, validators: [Validators.required, Validators.max(100000)]}),
        category: new FormControl('', {nonNullable: true, validators: [Validators.required]}),
        quantity: new FormControl(0, {nonNullable: true, validators: [Validators.required]}),
        inventoryStatus: new FormControl('', {nonNullable: true, validators: [Validators.required]}),
        rating: new FormControl(0, {nonNullable: true, validators: [Validators.max(5), Validators.min(0)]})
      });
    } else {
      let editingProduct: Product = config.data.product;
      this.form = new FormGroup<ProductForm>({
        code: new FormControl(editingProduct.code, {nonNullable: true, validators: [Validators.required, Validators.maxLength(4)]}),
        name: new FormControl(editingProduct.name, {nonNullable: true, validators: [Validators.required, Validators.minLength(3), Validators.maxLength(32)]}),
        description: new FormControl(editingProduct.description, {nonNullable: true, validators: [Validators.required, Validators.maxLength(256), Validators.minLength(32)]}),
        image: new FormControl(editingProduct.image!, {nonNullable: true}),
        price: new FormControl(editingProduct.price, {nonNullable: true, validators: [Validators.required, Validators.max(100000)]}),
        category: new FormControl(editingProduct.category, {nonNullable: true, validators: [Validators.required]}),
        quantity: new FormControl(editingProduct.quantity, {nonNullable: true, validators: [Validators.required]}),
        inventoryStatus: new FormControl(editingProduct.inventoryStatus, {nonNullable: true, validators: [Validators.required]}),
        rating: new FormControl(editingProduct.rating!, {nonNullable: true})
      });
    }
  }

  onUpload(event:FileUpload) {
    this.uploadedFile = event.files;
    this.messageService.add({severity: 'info', summary: 'File Uploaded', detail: ''});
  }

  onSubmit(): void {
    let newProduct: Product = {
      id: this.config.data?.product ? this.config.data.product.id : 0,
      code: this.form.value.code!,
      category: this.form.value.category!,
      description: this.form.value.description!,
      inventoryStatus: this.form.value.inventoryStatus!,
      name: this.form.value.name!,
      price: this.form.value.price!,
      quantity: this.form.value.quantity!,
      image: this.form.value.image,
      rating: this.form.value.rating
    }   
    this.ref.close(newProduct);
  }
}
