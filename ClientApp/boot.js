import Vue from 'vue';
import VueRouter from 'vue-router';

Vue.use(VueRouter);

import Subject from "./pages/Subject.vue";
import Topic from "./pages/Topic.vue";

const routes = [
    { path: "/topics", component: Subject },
    { path: "/topics/:slug", component: Topic },
    { path: "*", redirect: "/topics" }
];

new Vue({
    el: '#app-root',
    router: new VueRouter({ mode: 'history', routes: routes }),
    render: h => h(require('./components/App.vue'))
});
