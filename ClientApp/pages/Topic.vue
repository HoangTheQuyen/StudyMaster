<template>
    <topic-details :topic="topic"  />
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

    mounted(){
        const slug = this.$route.params.slug;

        fetch(`api/topics/${slug}`)
        .then(response => {
            return response.json();
        })
        .then(topic =>{
            this.topic = topic;
        })
    }
}
</script>
