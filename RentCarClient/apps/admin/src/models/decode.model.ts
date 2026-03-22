export interface DecodeModel {
  id: string;
  fullName: string;
  fullNameWithEmail: string;
  email: string;
  role: string;
  branch: string;
  permissions: string[];
}
export const initialDecode:DecodeModel={
  id: '',
  fullName: '',
  fullNameWithEmail: '',
  email: '',
  role: '',
  branch:'',
  permissions: []
}