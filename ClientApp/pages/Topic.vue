<template>
<div class="page">
    <topic-details :topic="topic" />
</div>
</template>

<script>

import TopicDetails from "../components/topic/Details.vue";

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
        
        fetch(`/api/topics/${to.params.slug}`)
            .then(response => {
                return response.json();
            })
            .then(topic => {
                next(vm => vm.setData(topic));
            });
    },

    methods: {
        setData(topic) {
            this.topic = topic;
        }
    }
}
</script>
