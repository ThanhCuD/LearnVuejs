<template>
    <section class="page-section bg-light" id="portfolio">
            <div class="container">
                <div class="text-center">
                    <h2 class="section-heading text-uppercase">Bài Viết</h2>
                    <h3 class="section-subheading text-muted">Các sự kiện, thông tin cập nhật từ Pet Life</h3>
                </div>
                <div class="row">
                    <div class="col-lg-4 col-sm-6 mb-4" v-for="(item,key) of jsonData" :key="key">
                        <div class="portfolio-item">
                            <a class="portfolio-link" data-toggle="modal" href="#portfolioModal1">
                                <div class="portfolio-hover">
                                    <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                                </div>
                                 <!-- <img :src="class2(item.img)" class="img-fluid" alt="" />  -->
                                  <img src="../assets/img/bg1.jpg" class="img-fluid" alt="" /> 
                            </a>
                            <div class="portfolio-caption">
                                <div class="portfolio-caption-heading">{{ item.heading }}</div>
                                <div class="portfolio-caption-subheading text-muted">{{ item.subheading }}</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
</template>

<script>
export default {
    data: () =>({
         jsonData : [
            { 
                img : '../assets/img/bg1.jpg',
                heading: 'Tìm Chủ cho bé cún Budle Thất Lạc',
                subheading: 'Bên mình có nhặt được 1 bé poodle ở đường 297, phường Phước Long B, Q9 Ba mẹ nào lạc con liên hệ bên mình để nhận lại nha'
            },
             { 
                img : '../assets/img/bg1.jpg',
                heading: 'Tin Tức',
                subheading: 'Gọn gàng rồi sinh khoẻ nha con...'
            },
             { 
                img : '../assets/img/bg1.jpg',
                heading: 'Tin Tức',
                subheading: 'Sắp cuối tuần rồi book lịch cho mấy đứa lông lá qua Petlife tỉa tót đi mọi người ơi...'
            },{ 
                img : '../assets/img/bg1.jpg',
                heading: 'Tìm Chủ cho bé cún Budle Thất Lạc',
                subheading: 'Bên mình có nhặt được 1 bé poodle ở đường 297, phường Phước Long B, Q9 Ba mẹ nào lạc con liên hệ bên mình để nhận lại nha'
            },
             { 
                img : '../assets/img/bg1.jpg',
                heading: 'Tin Tức',
                subheading: 'Gọn gàng rồi sinh khoẻ nha con...'
            },
             { 
                img : '../assets/img/bg1.jpg',
                heading: 'Tin Tức',
                subheading: 'Sắp cuối tuần rồi book lịch cho mấy đứa lông lá qua Petlife tỉa tót đi mọi người ơi...'
            }
        ]
    }),
    methods: {
        class2(salut) {
            return salut;
        }
    }
}
</script>

<style scoped>

</style>