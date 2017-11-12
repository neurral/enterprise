
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

        export namespace Fields {
            export declare const OrganizationId;
            export declare const Name;
            export declare const OwnerId;
            export declare const OwnerUsername;
            export declare const OwnerEmail;
            export declare const OwnerSource;
            export declare const OwnerPasswordHash;
            export declare const OwnerPasswordSalt;
            export declare const OwnerLastDirectoryUpdate;
            export declare const OwnerUserImage;
            export declare const OwnerInsertDate;
            export declare const OwnerInsertUserId;
            export declare const OwnerUpdateDate;
            export declare const OwnerUpdateUserId;
            export declare const OwnerIsActive;
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