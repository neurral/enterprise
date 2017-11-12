namespace Enterprise.Organization {
    export interface TimeRecordApprovalRow {
        ApprovalId?: number;
        TimeRecordId?: number;
        RequestorId?: number;
        ApproverId?: number;
        ApprovalStatus?: ApprovalStatuses;
        RequestorLocked?: boolean;
        ApproverLocked?: boolean;
        DateReviewed?: string;
        UpdateDate?: string;
        UpdateUserId?: number;
        InsertDate?: string;
        InsertUserId?: number;
        TimeRecordPersonnelId?: number;
        TimeRecordWorkDate?: string;
        TimeRecordTimeStart?: string;
        TimeRecordTimeEnd?: string;
        TimeRecordRemarks?: string;
        TimeRecordStatus?: string;
        TimeRecordInsertDate?: string;
        TimeRecordInsertUserId?: number;
        RequestorFullName?: string;
        RequestorIdentificationNo?: string;
        RequestorFirstName?: string;
        RequestorMiddleName?: string;
        RequestorLastName?: string;
        RequestorEmail?: string;
        RequestorContactNumber?: string;
        RequestorPersonnelStatus?: number;
        RequestorGender?: string;
        RequestorDateStarted?: string;
        RequestorDateExited?: string;
        RequestorDateOfBirth?: string;
        RequestorUserId?: number;
        ApproverUserId?: number;
        ApproverFullName?: string;
        UpdateUserUsername?: string;
        UpdateUserEmail?: string;
        UpdateUserSource?: string;
        UpdateUserPasswordHash?: string;
        UpdateUserPasswordSalt?: string;
        UpdateUserLastDirectoryUpdate?: string;
        UpdateUserUserImage?: string;
        UpdateUserInsertDate?: string;
        UpdateUserInsertUserId?: number;
        UpdateUserUpdateDate?: string;
        UpdateUserUpdateUserId?: number;
        UpdateUserIsActive?: number;
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

    export namespace TimeRecordApprovalRow {
        export const idProperty = 'ApprovalId';
        export const nameProperty = 'RequestorFullName';
        export const localTextPrefix = 'Organization.TimeRecordApproval';
        export const lookupKey = 'Organization.TimeRecordApproval';

        export function getLookup(): Q.Lookup<TimeRecordApprovalRow> {
            return Q.getLookup<TimeRecordApprovalRow>('Organization.TimeRecordApproval');
        }

        export namespace Fields {
            export declare const ApprovalId: string;
            export declare const TimeRecordId: string;
            export declare const RequestorId: string;
            export declare const ApproverId: string;
            export declare const ApprovalStatus: string;
            export declare const RequestorLocked: string;
            export declare const ApproverLocked: string;
            export declare const DateReviewed: string;
            export declare const UpdateDate: string;
            export declare const UpdateUserId: string;
            export declare const InsertDate: string;
            export declare const InsertUserId: string;
            export declare const TimeRecordPersonnelId: string;
            export declare const TimeRecordWorkDate: string;
            export declare const TimeRecordTimeStart: string;
            export declare const TimeRecordTimeEnd: string;
            export declare const TimeRecordRemarks: string;
            export declare const TimeRecordStatus: string;
            export declare const TimeRecordInsertDate: string;
            export declare const TimeRecordInsertUserId: string;
            export declare const RequestorFullName: string;
            export declare const RequestorIdentificationNo: string;
            export declare const RequestorFirstName: string;
            export declare const RequestorMiddleName: string;
            export declare const RequestorLastName: string;
            export declare const RequestorEmail: string;
            export declare const RequestorContactNumber: string;
            export declare const RequestorPersonnelStatus: string;
            export declare const RequestorGender: string;
            export declare const RequestorDateStarted: string;
            export declare const RequestorDateExited: string;
            export declare const RequestorDateOfBirth: string;
            export declare const RequestorUserId: string;
            export declare const ApproverUserId: string;
            export declare const ApproverFullName: string;
            export declare const UpdateUserUsername: string;
            export declare const UpdateUserEmail: string;
            export declare const UpdateUserSource: string;
            export declare const UpdateUserPasswordHash: string;
            export declare const UpdateUserPasswordSalt: string;
            export declare const UpdateUserLastDirectoryUpdate: string;
            export declare const UpdateUserUserImage: string;
            export declare const UpdateUserInsertDate: string;
            export declare const UpdateUserInsertUserId: string;
            export declare const UpdateUserUpdateDate: string;
            export declare const UpdateUserUpdateUserId: string;
            export declare const UpdateUserIsActive: string;
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
            'ApprovalId', 
            'TimeRecordId', 
            'RequestorId', 
            'ApproverId', 
            'ApprovalStatus', 
            'RequestorLocked', 
            'ApproverLocked', 
            'DateReviewed', 
            'UpdateDate', 
            'UpdateUserId', 
            'InsertDate', 
            'InsertUserId', 
            'TimeRecordPersonnelId', 
            'TimeRecordWorkDate', 
            'TimeRecordTimeStart', 
            'TimeRecordTimeEnd', 
            'TimeRecordRemarks', 
            'TimeRecordStatus', 
            'TimeRecordInsertDate', 
            'TimeRecordInsertUserId', 
            'RequestorFullName', 
            'RequestorIdentificationNo', 
            'RequestorFirstName', 
            'RequestorMiddleName', 
            'RequestorLastName', 
            'RequestorEmail', 
            'RequestorContactNumber', 
            'RequestorPersonnelStatus', 
            'RequestorGender', 
            'RequestorDateStarted', 
            'RequestorDateExited', 
            'RequestorDateOfBirth', 
            'RequestorUserId', 
            'ApproverUserId', 
            'ApproverFullName', 
            'UpdateUserUsername', 
            'UpdateUserEmail', 
            'UpdateUserSource', 
            'UpdateUserPasswordHash', 
            'UpdateUserPasswordSalt', 
            'UpdateUserLastDirectoryUpdate', 
            'UpdateUserUserImage', 
            'UpdateUserInsertDate', 
            'UpdateUserInsertUserId', 
            'UpdateUserUpdateDate', 
            'UpdateUserUpdateUserId', 
            'UpdateUserIsActive', 
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

