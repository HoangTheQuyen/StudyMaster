<template>
<div class="page">
    <topic-list :topics="topics" />
</div>
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

    beforeRouteEnter(to, from, next) {
        fetch("/api/topics")
            .then(response => {
                return response.json();
            })
            .then(topics => {
                next(vm => vm.setData(topics));
            });
    },

    methods: {
        setData(topics) {
            this.topics = topics;
        }
    },

    components: {
        TopicList
    }
};
</script>
