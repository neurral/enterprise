interface JQuery {
    bootstrapToggle(options?: BootstrapToggleOptions | string): JQuery;
}

interface BootstrapToggleOptions {
    hideLabel?: boolean; //this is not part of Bootstrap Toggle options, just for Serene
    on?: string;
    off?: string;
    size?: string; //"large"|"normal"|"small"|"mini";
    onstyle?: string;
    offstyle?: string;
    style?: string;
    width?: number;
    height?: number;
}