<template>
  <div>
    <teleport to="head">
      <title>AAAAA</title>
    </teleport>
    <h1 class="mb-8 font-bold text-3xl">
      <inertia-link class="text-indigo-400 hover:text-indigo-600" :href="route('organizations')">Organizations&nbsp;</inertia-link>
      <span class="text-indigo-400 font-medium">/</span>
      {{ form.name }}
    </h1>
    <trashed-message v-if="organization.deleted_at" class="mb-6" @restore="restore">
      This organization has been deleted.
    </trashed-message>
    <div class="bg-white rounded shadow overflow-hidden max-w-3xl">
      <form @submit.prevent="submit">
        <div class="p-8 -mr-6 -mb-8 flex flex-wrap">
          <text-input v-model:value="form.name" :error="errors.name" class="pr-6 pb-8 w-full lg:w-1/2" label="Name" />
          <text-input v-model:value="form.email" :error="errors.email" class="pr-6 pb-8 w-full lg:w-1/2" label="Email" />
          <text-input v-model:value="form.phone" :error="errors.phone" class="pr-6 pb-8 w-full lg:w-1/2" label="Phone" />
          <text-input v-model:value="form.address" :error="errors.address" class="pr-6 pb-8 w-full lg:w-1/2" label="Address" />
          <text-input v-model:value="form.city" :error="errors.city" class="pr-6 pb-8 w-full lg:w-1/2" label="City" />
          <text-input v-model:value="form.region" :error="errors.region" class="pr-6 pb-8 w-full lg:w-1/2" label="Province/State" />
          <select-input v-model:value="form.country" :error="errors.country" class="pr-6 pb-8 w-full lg:w-1/2" label="Country">
            <option :value="null" />
            <option value="CA">Canada</option>
            <option value="US">United States</option>
          </select-input>
          <text-input v-model:value="form.postal_code" :error="errors.postal_code" class="pr-6 pb-8 w-full lg:w-1/2" label="Postal code" />
        </div>
        <div class="px-8 py-4 bg-gray-100 border-t border-gray-200 flex items-center">
          <button v-if="!organization.deleted_at" class="text-red-600 hover:underline" tabindex="-1" type="button" @click="destroy">Delete Organization</button>
          <loading-button :loading="sending" class="btn-indigo ml-auto" type="submit">Update Organization</loading-button>
        </div>
      </form>
    </div>
    <h2 class="mt-12 font-bold text-2xl">Contacts</h2>
    <div class="mt-6 bg-white rounded shadow overflow-x-auto">
      <table class="w-full whitespace-no-wrap">
        <tr class="text-left font-bold">
          <th class="px-6 pt-6 pb-4">Name</th>
          <th class="px-6 pt-6 pb-4">City</th>
          <th class="px-6 pt-6 pb-4" colspan="2">Phone</th>
        </tr>
        <tr v-for="contact in organization.contacts" :key="contact.id" class="hover:bg-gray-100 focus-within:bg-gray-100">
          <td class="border-t">
            <inertia-link class="px-6 py-4 flex items-center focus:text-indigo-500" href="route('contacts.edit', contact.id)">
              {{ contact.name }}
              <icon v-if="contact.deleted_at" name="trash" class="flex-shrink-0 w-3 h-3 fill-gray-400 ml-2" />
            </inertia-link>
          </td>
          <td class="border-t">
            <inertia-link class="px-6 py-4 flex items-center" href="route('contacts.edit', contact.id)" tabindex="-1">
              {{ contact.city }}
            </inertia-link>
          </td>
          <td class="border-t">
            <inertia-link class="px-6 py-4 flex items-center" href="route('contacts.edit', contact.id)" tabindex="-1">
              {{ contact.phone }}
            </inertia-link>
          </td>
          <td class="border-t w-px">
            <inertia-link class="px-4 flex items-center" href="route('contacts.edit', contact.id)" tabindex="-1">
              <icon name="cheveron-right" class="block w-6 h-6 fill-gray-400" />
            </inertia-link>
          </td>
        </tr>
        <tr v-if="organization.contacts.length === 0">
          <td class="border-t px-6 py-4" colspan="4">No contacts found.</td>
        </tr>
      </table>
    </div>
  </div>
</template>

<script lang="ts">
import {defineComponent, ref, PropType } from "vue"
import { Inertia } from "@inertiajs/inertia";
import { routeHelper as route } from "../../ziggy";
import app from "../../main";

interface Organization {
  name: string
  email: string,
  phone: string,
  address: string,
  city: string,
  region: string,
  country: string,
  postal_code: string,
  deleted_at: string,
  contacts: Array<{}>
}

export default defineComponent({
  remember: 'form',
  setup() {
    const page = app.config.globalProperties.$inertia.page.props.controller;
    
    const organization = ref<Organization>(page.organization);
    
    const form = ref({
      name: organization.value.name,
      email: organization.value.email,
      phone: organization.value.phone,
      address: organization.value.address,
      city: organization.value.city,
      region: organization.value.region,
      country: organization.value.country,
      postal_code: organization.value.postal_code
    })
    
    const errors = ref(page.errors);
    
    const sending = ref(false);
    
    const submit = () => {
      Inertia.put(route('organizations.update', page.organization.id), form.value, {
        onStart: () => sending.value = true,
        onFinish: () => sending.value = false,
      })
    }
    
    const destroy = () => {
      if (confirm('Are you sure you want to delete this organization?')) {
        Inertia.delete(route('organizations.destroy', page.organization.id))
      }
    }
    
    const restore = () => {
      if (confirm('Are you sure you want to restore this organization?')) {
        Inertia.put(route('organizations.restore', page.organization.id))
      }
    }
    
    return {
      sending,
      errors,
      organization,
      form,
      route,
      submit,
      destroy,
      restore
    }
  }
})
</script>