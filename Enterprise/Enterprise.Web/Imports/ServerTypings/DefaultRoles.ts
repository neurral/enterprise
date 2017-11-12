namespace Enterprise {
    export enum DefaultRoles {
        UNVERIFIED = 0,
        ADMINISTRATOR = 1,
        BOT = 2,
        ACCOUNT = 3,
        SUBACCOUNT = 4
    }
    Serenity.Decorators.registerEnum(DefaultRoles, 'Enterprise.Constants+DefaultRoles');
}

