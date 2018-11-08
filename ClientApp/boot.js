import Vue from "vue";
import VueRouter from "vue-router";
import store from "./store";
import BootstrapVue from "bootstrap-vue";
import NProgress from "nprogress";

Vue.use(VueRouter);
Vue.use(BootstrapVue);

import Subject from "./pages/Subject.vue";
import Topic from "./pages/Topic.vue";
import Exam from "./pages/Exam.vue";
import Examination from "./pages/Examination.vue";
import axios from "axios";

const initialStore = localStorage.getItem("store");

if (initialStore) {
    store.commit("initialise", JSON.parse(initialStore));
    if (store.getters.isAuthenticated) {
        axios.defaults.headers.common["Authorization"] = `Bearer ${
            store.state.auth.access_token
            }`;
    }
}

const routes = [
    {
        path: "/topics",
        component: Subject
    },
    {
        path: "/exams",
        component: Exam
    },
    {
        path: "/topics/:slug",
        component: Topic
    },
    {
        path: "/exams/:slug",
        component: Examination
    },
    {
        path: "*",
        redirect: "/topics"
    }

];

const router = new VueRouter({
    mode: "history",
    routes: routes
});

router.beforeEach((to, from, next) => {
    NProgress.start();

    if (to.matched.some(route => route.meta.requiresAuth)) {
        if (!store.getters.isAuthenticated) {
            store.commit("showAuthModal");

            next({ path: from.path, query: { redirect: to.path } });
        } else {
            next();
        }
    } else {
        next();
    }
});

router.afterEach((to, from) => {
    NProgress.done();
});

new Vue({
    el: "#app-root",
    router: router,
    store,
    render: h => h(require("./components/App.vue"))
});