using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using UniRitter.UniRitter2015.Models;

namespace UniRitter.UniRitter2015.Services.Implementation
{
    public class PostInMemoryRepository : IPostRepository
    {
        private static Dictionary<Guid, PostModel> data = new Dictionary<Guid, PostModel>();

        public PostModel Add(PostModel model)
        {
            var id = Guid.NewGuid();
            model.id = id;
            // TODO: this is __NOT__ thread safe!
            data[id] = model;
            return model;
        }

        public void Delete(Guid modelId)
        {
            data.Remove(modelId);
        }

        public PostModel Update(Guid id, PostModel model)
        {
            // TODO: this is __NOT__ thread safe!
            // TODO: id should be checked against model.id
            data[id] = model;
            return model;
        }

        public IEnumerable<PostModel> GetAll()
        {
            return data.Values;
        }

        public PostModel GetById(Guid id)
        {
            return data.ContainsKey(id) ? data[id] : null;
        }
    }
}