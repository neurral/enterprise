namespace Enterprise.Organization {
    export interface PersonnelStatusRow {
        PersonnelStatusId?: number;
        Sequence?: number;
        PersonnelStatusName?: string;
    }

    export namespace PersonnelStatusRow {
        export const idProperty = 'PersonnelStatusId';
        export const nameProperty = 'PersonnelStatusName';
        export const localTextPrefix = 'Organization.PersonnelStatus';
        export const lookupKey = 'Organization.PersonnelStatus';

        export function getLookup(): Q.Lookup<PersonnelStatusRow> {
            return Q.getLookup<PersonnelStatusRow>('Organization.PersonnelStatus');
        }

        export namespace Fields {
            export declare const PersonnelStatusId: string;
            export declare const Sequence: string;
            export declare const PersonnelStatusName: string;
        }

        [
            'PersonnelStatusId', 
            'Sequence', 
            'PersonnelStatusName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

