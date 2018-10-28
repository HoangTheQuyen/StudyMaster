<template>
    <b-container fluid class="page">
        <b-row>
            <b-col cols="3">
                <filters :filters="filters" />
            </b-col>

            <b-col cols="9">
                <topic-list :topics="topics" />
            </b-col>
        </b-row>
    </b-container>
</template>

<script>
    import TopicList from "../components/subject/TopicList.vue";
    import Filters from "../components/subject/Filters.vue";
    import axios from "axios";

    export default {
        name: "topiclist",

        data() {
            return {
                topics: [],
                filters: {
                    subjects: []
                }
            };
        },

        beforeRouteEnter(to, from, next) {
            axios
                .all([
                    axios.get("/api/topics", {
                        params: to.query
                    }),
                    axios.get("/api/filters")
                ])
                .then(
                    axios.spread((topics, filters) => {
                        next(vm => vm.setData(topics.data, filters.data));
                    })
                );
        },

        beforeRouteUpdate(to, from, next) {
            axios.get("/api/topics", {
                params: to.query
            }).then(response => {
                this.topics = response.data;
                next();
            });
        },

        methods: {
            setData(topics, filters) {
                this.topics = topics;
                this.filters = filters;
            }
        },

        components: {
            TopicList,
            Filters
        }
    };
</script>
