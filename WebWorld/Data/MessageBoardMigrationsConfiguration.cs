using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace WebWorld.Data
{
    public class MessageBoardMigrationsConfiguration : DbMigrationsConfiguration<MessageBoardContext>
    {
        public MessageBoardMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        } 
        
        
        protected override void Seed(MessageBoardContext context)
        {
             // starts on application start - new appdomain created



            // count topics so can seed using the context
            if (context.Topics.Count() == 0 )
            {
       

            var topic = new Topic()
                {
                    Title = "First Topic",
                    Body = "Body of Topic",
                    Created = DateTime.UtcNow,
                    Replies = new List<Reply>()
                    {
                        new Reply()
                        {
                            Body = "first reply",
                            Created = DateTime.UtcNow
                        },

                         new Reply()
                        {
                            Body = "second reply",
                            Created = DateTime.UtcNow
                        },

                         new Reply()
                        {
                            Body = "third reply",
                            Created = DateTime.UtcNow
                        },


                    }
                };

                context.Topics.Add(topic);

                var topic2 = new Topic()
                {
                    Title = "2First Topic",
                    Body = "2Body of Topic",
                    Created = DateTime.UtcNow
                };

                context.Topics.Add(topic2);

                var topic3 = new Topic()
                {
                    Title = "First Topic",
                    Body = "Body of Topic",
                    Created = DateTime.UtcNow
                };

                context.Topics.Add(topic3);

                try
                {
                    context.SaveChanges();
                }

                catch (Exception ex)
                {
                    var msg = ex.Message;
                }

            }

            base.Seed(context);

        }
    }
}
