namespace Enterprise.Organization {
    export interface TimeRecordRow {
        TimeRecordId?: number;
        PersonnelId?: number;
        WorkDate?: string;
        TimeRecordTypeId?: number;
        TimeStart?: string;
        TimeEnd?: string;
        TimeStartInt?: number;
        TimeEndInt?: number;
        Remarks?: string;
        Status?: ApprovalStatuses;
        InsertDate?: string;
        InsertUserId?: number;
        PersonnelIdentificationNo?: string;
        PersonnelFullName?: string;
        PersonnelFirstName?: string;
        PersonnelLastName?: string;
        PersonnelEmail?: string;
        PersonnelContactNumber?: string;
        PersonnelPersonnelStatus?: number;
        PersonnelUserId?: number;
    }

    export namespace TimeRecordRow {
        export const idProperty = 'TimeRecordId';
        export const nameProperty = 'Remarks';
        export const localTextPrefix = 'Organization.TimeRecord';

        export namespace Fields {
            export declare const TimeRecordId: string;
            export declare const PersonnelId: string;
            export declare const WorkDate: string;
            export declare const TimeRecordTypeId: string;
            export declare const TimeStart: string;
            export declare const TimeEnd: string;
            export declare const TimeStartInt: string;
            export declare const TimeEndInt: string;
            export declare const Remarks: string;
            export declare const Status: string;
            export declare const InsertDate: string;
            export declare const InsertUserId: string;
            export declare const PersonnelIdentificationNo: string;
            export declare const PersonnelFullName: string;
            export declare const PersonnelFirstName: string;
            export declare const PersonnelLastName: string;
            export declare const PersonnelEmail: string;
            export declare const PersonnelContactNumber: string;
            export declare const PersonnelPersonnelStatus: string;
            export declare const PersonnelUserId: string;
        }

        [
            'TimeRecordId', 
            'PersonnelId', 
            'WorkDate', 
            'TimeRecordTypeId', 
            'TimeStart', 
            'TimeEnd', 
            'TimeStartInt', 
            'TimeEndInt', 
            'Remarks', 
            'Status', 
            'InsertDate', 
            'InsertUserId', 
            'PersonnelIdentificationNo', 
            'PersonnelFullName', 
            'PersonnelFirstName', 
            'PersonnelLastName', 
            'PersonnelEmail', 
            'PersonnelContactNumber', 
            'PersonnelPersonnelStatus', 
            'PersonnelUserId'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

