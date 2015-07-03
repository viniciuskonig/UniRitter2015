using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniRitter.UniRitter2015.Models;

namespace UniRitter.UniRitter2015.Services
{
    public interface IPostRepository
    {
        PostModel Add(PostModel model);

        void Delete(Guid modelId);

        PostModel Update(Guid id, PostModel model);

        IEnumerable<PostModel> GetAll();

        PostModel GetById(Guid id);
    }
}
