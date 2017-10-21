/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace Enterprise.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Enterprise');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}