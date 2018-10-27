using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using StudyMaster.Data.Entities;

namespace StudyMaster.Data
{
    public static class DbContextExtentions
    {
        public static UserManager<AppUser> UserManager { get; set; }

         private static void AddTopics(EFDataContext context)
        {
            if (context.Topics.Any() == false)
            {
                var topics = new List<Topic>()
                {
                     new Topic
                     {
                         Name = "Chủ để số1",

                         Slug = "Chu-De-So-1",

                         Thumbnail = "http://placehold.it/200x300",

                         LectureContent = @"Lorem ipsum dolor sit amet consectetur adipisicing elit.
                         Perferendis tempora ad cum laudantium, omnis fugit amet iure animi corporis labore
                         repellat magnam perspiciatis explicabo maiores fuga provident a obcaecati tenetur
                         nostrum, quidem quod dignissimos, voluptatem quasi? Nisi quaerat, fugit voluptas
                         ducimus facilis impedit quod dicta, laborum sint iure nihil veniam aspernatur delectus
                         officia culpa, at cupiditate? Totam minima ut deleniti laboriosam dolores cumque in,
                         nesciunt optio! Quod recusandae voluptate facere pariatur soluta vel corrupti tenetur
                         aut maiores, cumque mollitia fugiat laudantium error odit voluptas nobis laboriosam
                         quo, rem deleniti? Iste quidem amet perferendis sed iusto tempora modi illo tempore
                         quibusdam laborum? Dicta aliquam libero, facere, maxime corporis qui officiis explicabo
                         aspernatur non consequatur mollitia iure magnam odit enim. Eligendi suscipit, optio
                         officiis repellat eos quis iure? Omnis, error aliquid quibusdam iste amet nihil nisi
                         cumque magni sequi enim illo autem nesciunt optio accusantium animi commodi tenetur
                         neque eum vitae est."

                     },
                // rest of product list omitted for brevity…
                };
                context.Topics.AddRange(topics);
                context.SaveChanges();
            }
        }
        public static void EnsureSeeded(this EFDataContext context)
        {
            if (UserManager.FindByEmailAsync("HoangTheQuyen01@gmail.com").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                    FirstName = "Hoang",
                    LastName = "Quyen",
                    UserName = "HoangTheQuyen01@gmail.com",
                    Email = "HoangTheQuyen01@gmail.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };
                UserManager.CreateAsync(user,"Password1*").GetAwaiter().GetResult();
            }
            AddTopics(context);
        }
    }
}