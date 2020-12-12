declare module '*.vue' {
  import type { DefineComponent } from 'vue'
  const component: DefineComponent<{}, {}, any>
  export default component
}
declare module '@inertiajs/inertia-vue3';
declare module 'lodash/mapValues';
declare module 'ziggy-js';