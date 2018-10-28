<template>
<div class="page">
    <exam-details :exam="exam" />
</div>
</template>

<script>

import ExamDetails from "../components/examination/Details.vue";
import axios from "axios";

export default {
    name: "exam",

    components: {
        ExamDetails
    },
    
    data() {
        return {
            exam: null
        };
    },

        beforeRouteEnter(to, from, next) {
            axios.get(`/api/exams/${to.params.slug}`).then(response => {
                next(vm => vm.setData(response.data));
            });
    },

    methods: {
        setData(exam) {
            this.exam = exam;
        }
    }
}
</script>
