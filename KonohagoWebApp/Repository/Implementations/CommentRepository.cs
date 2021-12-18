using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonohagoWebApp.Repository.Interfaces;
using Npgsql;
using KonohagoWebApp.Models;

namespace KonohagoWebApp.Repository.Implementations
{
    public class CommentRepository : IComentRepository
    {
        private string connection = "Host=localhost; " + "Username=postgres; " + "Password=Werrew123@; " + "Database=KonohagoDB";

        public async Task AddComment(Comment comment)
        {
            await using(var connection = new NpgsqlConnection(this.connection))
            {
                await connection.OpenAsync();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@comment" ,comment.Text);
                    cmd.Parameters.AddWithValue("@user_id", comment.User_id);
                    cmd.Parameters.AddWithValue("@art_id", comment.Anime_id);
                    cmd.CommandText = "insert into comments (user_id, comment) values (@user_id, @art_id, @comment)";
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<List<Comment>> GetCommentsByArtIdAsync(int id)
        {
            List<Comment> comments = new List<Comment>();
            await using (var connection = new NpgsqlConnection(this.connection))
            {
                await connection.OpenAsync();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandText = "select users.user_id, comments.comment, users.nickname from comments join users on users.user_id = comments.user_id = @id";
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Comment comment = new Comment(rdr.GetInt32(rdr.GetOrdinal("user_id")));
                            comment.Text = rdr.GetString(rdr.GetOrdinal("comment"));
                            comment.Username = rdr.GetString(rdr.GetOrdinal("nickname"));
                            comments.Add(comment);
                        }
                    }
                }
                return comments;
            }
        }
            
    }
}
