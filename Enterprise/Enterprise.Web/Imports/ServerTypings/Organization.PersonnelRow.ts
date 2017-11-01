namespace Enterprise.Organization {
    export interface PersonnelRow {
        PersonnelId?: number;
        IdentificationNo?: string;
        FirstName?: string;
        MiddleName?: string;
        LastName?: string;
        Email?: string;
        PersonnelStatus?: number;
        Gender?: string;
        DateStarted?: string;
        DateExited?: string;
        DateOfBirth?: string;
        UserId?: number;
        PersonnelStatusSequence?: number;
        PersonnelStatusPersonnelStatusName?: string;
        UserUsername?: string;
        UserEmail?: string;
        UserSource?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserLastDirectoryUpdate?: string;
        UserUserImage?: string;
        UserInsertDate?: string;
        UserInsertUserId?: number;
        UserUpdateDate?: string;
        UserUpdateUserId?: number;
        UserIsActive?: number;
    }

    export namespace PersonnelRow {
        export const idProperty = 'PersonnelId';
        export const nameProperty = 'IdentificationNo';
        export const localTextPrefix = 'Organization.Personnel';
        export const lookupKey = 'Organization.Personnel';

        export function getLookup(): Q.Lookup<PersonnelRow> {
            return Q.getLookup<PersonnelRow>('Organization.Personnel');
        }

        export namespace Fields {
            export declare const PersonnelId: string;
            export declare const IdentificationNo: string;
            export declare const FirstName: string;
            export declare const MiddleName: string;
            export declare const LastName: string;
            export declare const Email: string;
            export declare const PersonnelStatus: string;
            export declare const Gender: string;
            export declare const DateStarted: string;
            export declare const DateExited: string;
            export declare const DateOfBirth: string;
            export declare const UserId: string;
            export declare const PersonnelStatusSequence: string;
            export declare const PersonnelStatusPersonnelStatusName: string;
            export declare const UserUsername: string;
            export declare const UserEmail: string;
            export declare const UserSource: string;
            export declare const UserPasswordHash: string;
            export declare const UserPasswordSalt: string;
            export declare const UserLastDirectoryUpdate: string;
            export declare const UserUserImage: string;
            export declare const UserInsertDate: string;
            export declare const UserInsertUserId: string;
            export declare const UserUpdateDate: string;
            export declare const UserUpdateUserId: string;
            export declare const UserIsActive: string;
        }

        [
            'PersonnelId', 
            'IdentificationNo', 
            'FirstName', 
            'MiddleName', 
            'LastName', 
            'Email', 
            'PersonnelStatus', 
            'Gender', 
            'DateStarted', 
            'DateExited', 
            'DateOfBirth', 
            'UserId', 
            'PersonnelStatusSequence', 
            'PersonnelStatusPersonnelStatusName', 
            'UserUsername', 
            'UserEmail', 
            'UserSource', 
            'UserPasswordHash', 
            'UserPasswordSalt', 
            'UserLastDirectoryUpdate', 
            'UserUserImage', 
            'UserInsertDate', 
            'UserInsertUserId', 
            'UserUpdateDate', 
            'UserUpdateUserId', 
            'UserIsActive'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

