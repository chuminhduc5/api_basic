using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        // Đọc dữ liệu
        private readonly ApplicationDBContext _context;

        // Đưa bối cảnh DB vào ứng dụng
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        // Lấy ra tất cả danh sách
        public async Task<List<Comment>> GetAllAsync()
        {
           return await _context.Comments.ToListAsync();
        }
        

        public async Task<Comment?> GetByIdAsync(int id)
        {
           return await _context.Comments.FindAsync(id);
        }
    }
}