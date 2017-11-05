namespace Enterprise.Organization {
    export interface TimeRecordRow {
        TimeRecordId?: number;
        PersonnelId?: number;
        WorkDate?: string;
        TimeStart?: string;
        TimeEnd?: string;
        Remarks?: string;
        Status?: string;
        InsertDate?: string;
        InsertUserId?: number;
        PersonnelIdentificationNo?: string;
        PersonnelFirstName?: string;
        PersonnelMiddleName?: string;
        PersonnelLastName?: string;
        PersonnelEmail?: string;
        PersonnelContactNumber?: string;
        PersonnelPersonnelStatus?: number;
        PersonnelGender?: string;
        PersonnelDateStarted?: string;
        PersonnelDateExited?: string;
        PersonnelDateOfBirth?: string;
        PersonnelUserId?: number;
        InsertUserUsername?: string;
        InsertUserEmail?: string;
        InsertUserSource?: string;
        InsertUserPasswordHash?: string;
        InsertUserPasswordSalt?: string;
        InsertUserLastDirectoryUpdate?: string;
        InsertUserUserImage?: string;
        InsertUserInsertDate?: string;
        InsertUserInsertUserId?: number;
        InsertUserUpdateDate?: string;
        InsertUserUpdateUserId?: number;
        InsertUserIsActive?: number;
    }

    export namespace TimeRecordRow {
        export const idProperty = 'TimeRecordId';
        export const nameProperty = 'Remarks';
        export const localTextPrefix = 'Organization.TimeRecord';

        export namespace Fields {
            export declare const TimeRecordId: string;
            export declare const PersonnelId: string;
            export declare const WorkDate: string;
            export declare const TimeStart: string;
            export declare const TimeEnd: string;
            export declare const Remarks: string;
            export declare const Status: string;
            export declare const InsertDate: string;
            export declare const InsertUserId: string;
            export declare const PersonnelIdentificationNo: string;
            export declare const PersonnelFirstName: string;
            export declare const PersonnelMiddleName: string;
            export declare const PersonnelLastName: string;
            export declare const PersonnelEmail: string;
            export declare const PersonnelContactNumber: string;
            export declare const PersonnelPersonnelStatus: string;
            export declare const PersonnelGender: string;
            export declare const PersonnelDateStarted: string;
            export declare const PersonnelDateExited: string;
            export declare const PersonnelDateOfBirth: string;
            export declare const PersonnelUserId: string;
            export declare const InsertUserUsername: string;
            export declare const InsertUserEmail: string;
            export declare const InsertUserSource: string;
            export declare const InsertUserPasswordHash: string;
            export declare const InsertUserPasswordSalt: string;
            export declare const InsertUserLastDirectoryUpdate: string;
            export declare const InsertUserUserImage: string;
            export declare const InsertUserInsertDate: string;
            export declare const InsertUserInsertUserId: string;
            export declare const InsertUserUpdateDate: string;
            export declare const InsertUserUpdateUserId: string;
            export declare const InsertUserIsActive: string;
        }

        [
            'TimeRecordId', 
            'PersonnelId', 
            'WorkDate', 
            'TimeStart', 
            'TimeEnd', 
            'Remarks', 
            'Status', 
            'InsertDate', 
            'InsertUserId', 
            'PersonnelIdentificationNo', 
            'PersonnelFirstName', 
            'PersonnelMiddleName', 
            'PersonnelLastName', 
            'PersonnelEmail', 
            'PersonnelContactNumber', 
            'PersonnelPersonnelStatus', 
            'PersonnelGender', 
            'PersonnelDateStarted', 
            'PersonnelDateExited', 
            'PersonnelDateOfBirth', 
            'PersonnelUserId', 
            'InsertUserUsername', 
            'InsertUserEmail', 
            'InsertUserSource', 
            'InsertUserPasswordHash', 
            'InsertUserPasswordSalt', 
            'InsertUserLastDirectoryUpdate', 
            'InsertUserUserImage', 
            'InsertUserInsertDate', 
            'InsertUserInsertUserId', 
            'InsertUserUpdateDate', 
            'InsertUserUpdateUserId', 
            'InsertUserIsActive'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

