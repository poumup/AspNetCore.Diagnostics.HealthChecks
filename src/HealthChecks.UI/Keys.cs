﻿namespace HealthChecks.UI
{
    class Keys
    {
        internal const string HEALTHCHECKSUI_SECTION_SETTING_KEY = "HealthChecks-UI";
        internal const string HEALTHCHECKS_DEFAULT_PATH = "hc";
        internal const string HEALTHCHECKS_DEFAULT_DISCOVERY_LABEL = "HealthChecks";
        internal const string HEALTHCHECKSUI_KUBERNETES_DISCOVERY_SETTING_KEY = "HealthChecks-UI:KubernetesDiscoveryService";
        internal const string HEALTHCHECKSUI_RESOURCES_PATH = "/ui/resources";
        internal const string HEALTHCHECKSUI_MAIN_UI_RESOURCE = "index.html";
        internal const string HEALTHCHECKSUI_MAIN_UI_API_TARGET = "#apiPath#";
        internal const string HEALTHCHECKSUI_WEBHOOKS_API_TARGET = "#webhookPath#";
        internal const string DEFAULT_RESPONSE_CONTENT_TYPE = "application/json";
        internal const string LIVENESS_BOOKMARK = "[[LIVENESS]]";
        internal const string FAILURE_BOOKMARK = "[[FAILURE]]";
    }
}
