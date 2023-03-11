using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService: IGenericService<Comment>
    {
        void CommentAdd(Comment comment);

        //void CommentDelete(Category category);

        //void CategoryUpdate(Category category);

        List<Comment> GetList(int id);

        List<Comment> GetCommentWithBlog();


        //Comment GetById(int id);
    }
}
