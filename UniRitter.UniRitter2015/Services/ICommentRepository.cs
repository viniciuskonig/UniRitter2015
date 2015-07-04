using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRitter.UniRitter2015.Models;

namespace UniRitter.UniRitter2015.Services
{
    public interface ICommentRepository
    {
        CommentModel Add(CommentModel model);

        void Delete(Guid modelId);

        CommentModel Update(Guid id, CommentModel model);

        IEnumerable<CommentModel> GetAll();

        CommentModel GetById(Guid id);
    }
}
