namespace Enterprise.Organization {
    export interface TimeRecordTypeRow {
        TimeRecordTypeId?: number;
        Code?: string;
        TimeRecordTypeName?: string;
    }

    export namespace TimeRecordTypeRow {
        export const idProperty = 'TimeRecordTypeId';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Organization.TimeRecordType';
        export const lookupKey = 'Organization.TimeRecordType';

        export function getLookup(): Q.Lookup<TimeRecordTypeRow> {
            return Q.getLookup<TimeRecordTypeRow>('Organization.TimeRecordType');
        }

        export namespace Fields {
            export declare const TimeRecordTypeId: string;
            export declare const Code: string;
            export declare const TimeRecordTypeName: string;
        }

        [
            'TimeRecordTypeId', 
            'Code', 
            'TimeRecordTypeName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

