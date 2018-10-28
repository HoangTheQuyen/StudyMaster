<template>
<div class="page">
    <topic-details :topic="topic" />
</div>
</template>

<script>

import TopicDetails from "../components/topic/Details.vue";
import axios from "axios";

export default {
    name: "topic",

    components: {
        TopicDetails
    },
    
    data() {
        return {
            topic: null
        };
    },

        beforeRouteEnter(to, from, next) {
            axios.get(`/api/topics/${to.params.slug}`).then(response => {
                next(vm => vm.setData(response.data));
            });
    },

    methods: {
        setData(topic) {
            this.topic = topic;
        }
    }
}
</script>
