import { createApp, h } from 'vue'
import { App, plugin } from '@inertiajs/inertia-vue3'
import { InertiaProgress } from '@inertiajs/progress'
import MainLayout from "./Layouts/MainLayout.vue";

InertiaProgress.init()

import './assets/styles/app.scss'
import Dropdown from "./Shared/Dropdown.vue";
import Logo from "./Shared/Logo.vue";
import Icon from "./Shared/Icon.vue";
import FlashMessages from "./Shared/FlashMessages.vue";
import MainMenu from "./Shared/MainMenu.vue";
import LoadingButton from "./Shared/LoadingButton.vue";
import TextInput from "./Shared/TextInput.vue";
import Pagination from "./Shared/Pagination.vue";
import SearchFilter from "./Shared/SearchFilter.vue";
import TrashedMessage from "./Shared/TrashedMessage.vue";
import SelectInput from "./Shared/SelectInput.vue";

const el = document.getElementById('app')

if (!el) throw new Error("App not found");

const app = createApp({
    metaInfo: {
        titleTemplate: (title: string) => title ? `${title} - Ping CRM` : 'Ping CRM'
    },
    render: () => h(App, {
        // @ts-ignore
        initialPage: JSON.parse(el.dataset.page),
        resolveComponent: (name:string) => import(`./Pages/${name}`).then(({ default: page }) => {
            page.layout = page.layout === undefined ? MainLayout : page.layout;
            page.layout = name === "Auth/Login" ? undefined : page.layout;
            return page
        })
    })
});
app.component("Logo", Logo);
app.component("Dropdown", Dropdown);
app.component("Icon", Icon);
app.component("FlashMessages", FlashMessages);
app.component("MainMenu", MainMenu);
app.component("LoadingButton", LoadingButton);
app.component("TextInput", TextInput);
app.component("Pagination", Pagination);
app.component("SearchFilter", SearchFilter);
app.component('TrashedMessage', TrashedMessage);
app.component("SelectInput", SelectInput);
app.use(plugin);
app.mount(el);

export default app;
