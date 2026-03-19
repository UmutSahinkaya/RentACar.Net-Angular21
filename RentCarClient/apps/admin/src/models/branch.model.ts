import { EntityModel } from './entity.model';

export interface BranchModel extends EntityModel {
  name: string;
  address: AddressModel;
  contact: ContactModel;
}

export interface AddressModel {
  city: string;
  district: string;
  fullAdress: string;
}
export interface ContactModel {
  phoneNumber1: string;
  phoneNumber2: string;
  email: string;
}

export const initialBranch: BranchModel = {
  id: '',
  name: '',
  address: {
    city: '',
    district: '',
    fullAdress: '',
  },
  contact: {
    email: '',
    phoneNumber1: '',
    phoneNumber2: '',
  },
  isActive: true,
  createdAt: '',
  createdBy: '',
  createdFullName: '',
};
