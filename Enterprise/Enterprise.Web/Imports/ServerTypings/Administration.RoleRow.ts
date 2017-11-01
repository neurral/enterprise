namespace Enterprise.Administration {
    export interface RoleRow {
        RoleId?: number;
        RoleName?: string;
    }

    export namespace RoleRow {
        export const idProperty = 'RoleId';
        export const nameProperty = 'RoleName';
        export const localTextPrefix = 'Administration.Role';
        export const lookupKey = 'Administration.Roles';

        export function getLookup(): Q.Lookup<RoleRow> {
            return Q.getLookup<RoleRow>('Administration.Roles');
        }

        export namespace Fields {
            export declare const RoleId: string;
            export declare const RoleName: string;
        }

        [
            'RoleId', 
            'RoleName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

