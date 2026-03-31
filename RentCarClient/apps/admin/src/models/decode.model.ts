export interface DecodeModel {
  id: string;
  fullName: string;
  fullNameWithEmail: string;
  email: string;
  role: string;
  branch: string;
  branchId: string;
  permissions: string[];
}
export const initialDecode:DecodeModel={
  id: '',
  fullName: '',
  fullNameWithEmail: '',
  email: '',
  role: '',
  branch:'',
  branchId: '',
  permissions: []
}