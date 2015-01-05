using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorld.Data
{
    public class MessageBoardRepository : IMessageBoardRepository
    {
        private MessageBoardContext _ctx;
        public MessageBoardRepository()
        {
            _ctx = new MessageBoardContext(); // using the db context in requestscope and configured using ninject bind
        }
        
        public IQueryable<Topic> GeTopics()
        {
            return _ctx.Topics;
        }

        public IQueryable<Reply> Replies(int topicId)
        {
            return _ctx.Replies.Where(r => r.TopicId == topicId);
        }
    }
}