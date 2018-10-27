<template>
    <topic-list :topics="topics" />
</template>

<script>
    import TopicList from "../components/subject/TopicList.vue";
    
    export default {
        name: "topiclist",

        data() {
            return {
                topics: []
            };
        },

        mounted() {
            fetch("/api/topics")
                .then(response => {
                    return response.json();
                })
                .then(topics => {
                    this.topics = topics;
                });
        },

        components: {
            TopicList
        }
    };
</script>