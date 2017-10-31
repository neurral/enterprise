namespace Enterprise.Organization {
    export interface MeetingLocationRow {
        LocationId?: number;
        Name?: string;
        Address?: string;
        Latitude?: number;
        Longitude?: number;
    }

    export namespace MeetingLocationRow {
        export const idProperty = 'LocationId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Meeting.MeetingLocation';
        export const lookupKey = 'Organization.MeetingLocation';

        export function getLookup(): Q.Lookup<MeetingLocationRow> {
            return Q.getLookup<MeetingLocationRow>('Organization.MeetingLocation');
        }

        export namespace Fields {
            export declare const LocationId: string;
            export declare const Name: string;
            export declare const Address: string;
            export declare const Latitude: string;
            export declare const Longitude: string;
        }

        [
            'LocationId', 
            'Name', 
            'Address', 
            'Latitude', 
            'Longitude'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

