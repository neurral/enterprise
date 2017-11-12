namespace Enterprise {
    export enum ApprovalStatuses {
        LOCKED = 0,
        SUBMITTED = 1,
        CANCELLED = 2,
        APPROVED = 3,
        REJECTED = 4
    }
    Serenity.Decorators.registerEnum(ApprovalStatuses, 'Enterprise.Constants+ApprovalStatuses');
}

