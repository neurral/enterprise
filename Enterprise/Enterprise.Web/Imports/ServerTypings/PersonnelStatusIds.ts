namespace Enterprise {
    export enum PersonnelStatusIds {
        UNVERIFIED = 1,
        INACTIVE = 2,
        ACTIVATED = 3,
        SUSPENDED = 4,
        TERMINATED = 5
    }
    Serenity.Decorators.registerEnum(PersonnelStatusIds, 'Enterprise.Constants+PersonnelStatusIds');
}

