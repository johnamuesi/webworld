using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWorld.Data
{
    // interface exposing methods for data operations we want - interface so its testable
    public interface IMessageBoardRepository
    {
        IQueryable<Topic> GeTopics();// iqueryable object supports paging and sorting
        IQueryable<Reply> Replies(int topicId);
    }
}
