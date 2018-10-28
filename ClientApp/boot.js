import Vue from "vue";
import VueRouter from "vue-router";
import BootstrapVue from "bootstrap-vue";
import NProgress from "nprogress";

Vue.use(VueRouter);
Vue.use(BootstrapVue);

import Subject from "./pages/Subject.vue";
import Topic from "./pages/Topic.vue";
import Exam from "./pages/Exam.vue";
import Examination from "./pages/Examination.vue";

const routes = [
    {
        path:"/topics",
        component:Subject
    },
    {
        path:"/exams",
        component:Exam
    },
    {
        path:"/topics/:slug",
        component: Topic
    },
    {
        path:"/exams/:slug",
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
    next();
});

router.afterEach((to, from) => {
    NProgress.done();
});

new Vue({
    el: "#app-root",
    router: router,
    render: h => h(require("./components/App.vue"))
});