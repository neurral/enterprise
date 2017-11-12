namespace Enterprise.Organization {
    export interface CalendarHolidayRow {
        CalendarHolidayId?: number;
        Date?: string;
        TimeStart?: string;
        Description?: string;
        NonWorkday?: boolean;
        InsertDate?: string;
        InsertUserId?: number;
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

    export namespace CalendarHolidayRow {
        export const idProperty = 'CalendarHolidayId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Organization.CalendarHoliday';
        export const lookupKey = 'Organization.CalendarHoliday';

        export function getLookup(): Q.Lookup<CalendarHolidayRow> {
            return Q.getLookup<CalendarHolidayRow>('Organization.CalendarHoliday');
        }

        export namespace Fields {
            export declare const CalendarHolidayId: string;
            export declare const Date: string;
            export declare const TimeStart: string;
            export declare const Description: string;
            export declare const NonWorkday: string;
            export declare const InsertDate: string;
            export declare const InsertUserId: string;
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
            'CalendarHolidayId', 
            'Date', 
            'TimeStart', 
            'Description', 
            'NonWorkday', 
            'InsertDate', 
            'InsertUserId', 
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

