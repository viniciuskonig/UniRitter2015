using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using UniRitter.UniRitter2015.Models;

namespace UniRitter.UniRitter2015.Services.Implementation
{
    public class CommentInMemoryRepository : ICommentRepository
    {
        private static Dictionary<Guid, CommentModel> data = new Dictionary<Guid, CommentModel>();

        public CommentModel Add(CommentModel model)
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

        public CommentModel Update(Guid id, CommentModel model)
        {
            // TODO: this is __NOT__ thread safe!
            // TODO: id should be checked against model.id
            data[id] = model;
            return model;
        }

        public IEnumerable<CommentModel> GetAll()
        {
            return data.Values;
        }

        public CommentModel GetById(Guid id)
        {
            return data.ContainsKey(id) ? data[id] : null;
        }
    }
}