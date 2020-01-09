using UserPosts.Data;
using UserPosts.Domain;
using UserPosts.Services;
using System;



namespace UserPosts.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPostRepository postRepository = new PostDataAccess();
            IUserRepository userRepository = new UserDataAccess();

            var service = new UserService(userRepository, postRepository);

            var response = service.GetUserActiveRespose(2);

           

            CommentDataAccess comment = new CommentDataAccess();
            var lista = comment.GetCommentsByUserId(8);
            foreach (var item in lista)
            {
                Console.WriteLine($" id : {item.Id} text : {item.Text}");
            }
            


            Console.ReadLine();
            
        }
    }
}