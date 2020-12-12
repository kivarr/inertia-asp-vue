<template>
  <div>
    <div class="mb-4">
      <inertia-link class="flex items-center group py-3" href="/">
        <icon name="dashboard" class="w-4 h-4 mr-2" :class="isUrl('') ? 'fill-white' : 'fill-indigo-400 group-hover:fill-white'" />
        <div :class="isUrl('') ? 'text-white' : 'text-indigo-300 group-hover:text-white'">Dashboard</div>
      </inertia-link>
    </div>
    <div class="mb-4">
      <inertia-link class="flex items-center group py-3" href="/Home/Orgs">
        <icon name="office" class="w-4 h-4 mr-2" :class="isUrl('Home/Orgs') ? 'fill-white' : 'fill-indigo-400 group-hover:fill-white'" />
        <div :class="isUrl('Home/Orgs') ? 'text-white' : 'text-indigo-300 group-hover:text-white'">Organizations</div>
      </inertia-link>
    </div>
    <div class="mb-4">
      <inertia-link class="flex items-center group py-3" href="route('contacts')">
        <icon name="users" class="w-4 h-4 mr-2" :class="isUrl('contacts') ? 'fill-white' : 'fill-indigo-400 group-hover:fill-white'" />
        <div :class="isUrl('contacts') ? 'text-white' : 'text-indigo-300 group-hover:text-white'">Contacts</div>
      </inertia-link>
    </div>
    <div class="mb-4">
      <inertia-link class="flex items-center group py-3" href="route('reports')">
        <icon name="printer" class="w-4 h-4 mr-2" :class="isUrl('reports') ? 'fill-white' : 'fill-indigo-400 group-hover:fill-white'" />
        <div :class="isUrl('reports') ? 'text-white' : 'text-indigo-300 group-hover:text-white'">Reports</div>
      </inertia-link>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  props: {
    url: {
      type: String,
      required: true
    },
  },
  setup(props) {
    const isUrl = (...urls: string[]) => {
      if (urls[0] === '') {
        return props.url === ''
      }
      return urls.filter(url => props.url.startsWith(url)).length
    }
    
    return {
      isUrl
    }
  }
});
</script>