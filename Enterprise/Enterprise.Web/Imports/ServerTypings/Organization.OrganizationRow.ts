namespace Enterprise.Organization {
    export interface OrganizationRow {
        OrganizationId?: number;
        Name?: string;
        OwnerId?: number;
        OwnerUsername?: string;
        OwnerEmail?: string;
        OwnerSource?: string;
        OwnerPasswordHash?: string;
        OwnerPasswordSalt?: string;
        OwnerLastDirectoryUpdate?: string;
        OwnerUserImage?: string;
        OwnerInsertDate?: string;
        OwnerInsertUserId?: number;
        OwnerUpdateDate?: string;
        OwnerUpdateUserId?: number;
        OwnerIsActive?: number;
    }

    export namespace OrganizationRow {
        export const idProperty = 'OrganizationId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Organization.Organization';
        export const lookupKey = 'Organization.Organization';

        export function getLookup(): Q.Lookup<OrganizationRow> {
            return Q.getLookup<OrganizationRow>('Organization.Organization');
        }

        export namespace Fields {
            export declare const OrganizationId: string;
            export declare const Name: string;
            export declare const OwnerId: string;
            export declare const OwnerUsername: string;
            export declare const OwnerEmail: string;
            export declare const OwnerSource: string;
            export declare const OwnerPasswordHash: string;
            export declare const OwnerPasswordSalt: string;
            export declare const OwnerLastDirectoryUpdate: string;
            export declare const OwnerUserImage: string;
            export declare const OwnerInsertDate: string;
            export declare const OwnerInsertUserId: string;
            export declare const OwnerUpdateDate: string;
            export declare const OwnerUpdateUserId: string;
            export declare const OwnerIsActive: string;
        }

        [
            'OrganizationId', 
            'Name', 
            'OwnerId', 
            'OwnerUsername', 
            'OwnerEmail', 
            'OwnerSource', 
            'OwnerPasswordHash', 
            'OwnerPasswordSalt', 
            'OwnerLastDirectoryUpdate', 
            'OwnerUserImage', 
            'OwnerInsertDate', 
            'OwnerInsertUserId', 
            'OwnerUpdateDate', 
            'OwnerUpdateUserId', 
            'OwnerIsActive'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

