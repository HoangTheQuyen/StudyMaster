<template>
    <div>
        <topic-list />
    </div>
</template>

<script>
    import TopicList from "./topics/List.vue";
    export default {
        name: "app",
        components: {
            TopicList
        }
    };
</script>
