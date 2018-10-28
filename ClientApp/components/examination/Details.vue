<template>
<b-container class="pt-4">
    <b-media>
        <img slot="aside" :src="exam.thumbnail" :alt="exam.description" />

        <h2>{{ exam.description }}</h2>

    </b-media>
    <h3 class="mt-4">Exam details</h3>

    <div v-for="question in exam.questions" v-bind:key="question.id" class="pt-4">
        <h4>Câu hỏi: {{question.content}}</h4>

        <input type="radio" id="one" v-bind:value="One" v-model="picked">
        <label for="one">A - {{question.aContent}}</label>
        <br>

        <input type="radio" id="two" v-bind:value="Two" v-model="picked">
        <label for="two">B - {{question.bContent}}</label>
        <br>

        <input type="radio" id="two" v-bind:value="Two" v-model="picked">
        <label for="two">C - {{question.cContent}}</label>
        <br>
        
        <input type="radio" id="two" v-bind:value="Two" v-model="picked">
        <label for="two">D - {{question.dContent}}</label>
        <br>
        <span>Picked: {{ picked }}</span>
    </div>

</b-container>
</template>

<script>
export default {
    name: "exam-details",
    props: {
        exam: {
            type: Object,
            required: true
        }
    },
    data(){
        return{
            picked:[]
        }
    }
};
</script>

<style>
.details {
    padding: 20px;
}
</style>
