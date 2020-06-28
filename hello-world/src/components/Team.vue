<template>
    <section class="page-section bg-light" id="team">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Our Amazing Team</h2>
                    <h3 class="section-subheading text-muted">Lorem ipsum dolor sit amet consectetur.</h3>
                </div>
                <div class="row" >
                    <div :class="className(jsonData.length)" v-for="(item,key) in jsonData" :key="key">
                        <div class="team-member">
                            <img class="mx-auto rounded-circle" :src="item.src" alt="" />
                            <h4>{{item.name}}</h4>
                            <p class="text-muted">{{item.position}}</p>
                            <a class="btn btn-dark btn-social mx-2" :href="item.linkTwitter"><i class="fab fa-twitter"></i></a>
                            <a class="btn btn-dark btn-social mx-2" :href="item.linkFacebook"><i class="fab fa-facebook-f"></i></a>
                            <a class="btn btn-dark btn-social mx-2" :href="item.linkLinkedin"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-8 mx-auto text-center"><p class="large text-muted">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aut eaque, laboriosam veritatis, quos non quis ad perspiciatis, totam corporis ea, alias ut unde.</p></div>
                </div>
            </div>
        </section>
</template>
<script>
export default {
    data: () =>({
        jsonData: [{
            imgSrc:"assets/img/team/1.jpg",
            name:"Kay Garland",
            position: "Lead Designer",
            linkFacebook: "#!",
            linkTwitter: "#!",
            linkLinkedin:"#!"
        },{
            imgSrc:"assets/img/team/1.jpg",
            name:"Kay Garland",
            position: "Lead Designer",
            linkFacebook: "#!",
            linkTwitter: "#!",
            linkLinkedin:"#!"
        }
        ]
    }),
    methods: {
        className(n){
            return n%3==0?"col-lg-4":"col-lg-6"
        }
    }
}
</script>
<style scoped>

</style>