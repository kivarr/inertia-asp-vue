<template>
  <div class="p-6 bg-indigo-800 min-h-screen flex justify-center items-center">
    <div class="w-full max-w-md">
      <logo class="block mx-auto w-full max-w-xs fill-white" height="50" />
      <form class="mt-8 bg-white rounded-lg shadow-xl overflow-hidden" @submit.prevent="submit">
        <div class="px-10 py-12">
          <h1 class="text-center font-bold text-3xl">Welcome Back!</h1>
          <div class="mx-auto mt-6 w-24 border-b-2" />
          <text-input v-model:value="form.email" :error="errors.email" class="mt-10" label="Email" type="email" autofocus autocapitalize="off" />
          <text-input v-model:value="form.password" class="mt-6" label="Password" type="password" />
          <label class="mt-6 select-none flex items-center" for="remember">
            <input id="remember" v-model="form.remember" class="mr-1" type="checkbox">
            <span class="text-sm">Remember Me</span>
          </label>
        </div>
        <div class="px-10 py-4 bg-gray-100 border-t border-gray-200 flex justify-between items-center">
          <a class="hover:underline" tabindex="-1" href="#reset-password">Forget password?</a>
          <loading-button :loading="sending" class="btn-indigo" type="submit">Login</loading-button>
        </div>
      </form>
    </div>
  </div>
</template>

<script lang="ts">
import {Inertia} from "@inertiajs/inertia";
import {defineComponent, PropType, ref, reactive, inject } from "vue";

interface Errors {
  email?: string
}

interface Form {
  email: string,
  password: string,
  remember: null | boolean
}

export default defineComponent({
  // props: {
  //   errors: {
  //     type: Object as PropType<Errors>,
  //     required: false
  //   }
  // },
  setup(props) {
    console.log(Inertia);
    const sending = ref(false);
    const form = ref<Form>({
      email: 'brianne_white23@example.com',
      password: 'secret',
      remember: null,
    })
    
    const submit = () => {
      Inertia.post("Login", form.value, {
        onStart: () => sending.value = true,
        onFinish: () => sending.value = false,
      })
    }
    return {
      sending,
      form,
      errors: { } as Errors,
      submit
    }
  }
})
</script>