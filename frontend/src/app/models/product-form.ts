import { FormControl } from "@angular/forms";

export interface ProductForm {
    code: FormControl<string>;
    name: FormControl<string>;
    description: FormControl<string>;
    image: FormControl<string>;
    price: FormControl<number>;
    category: FormControl<string>;
    quantity: FormControl<number>;
    inventoryStatus: FormControl<string>;
    rating: FormControl<number>;
}