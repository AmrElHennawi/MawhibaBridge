
using MawhibaBridge.DataAccess.Repositories.Implementations;
using MawhibaBridge.DataAccess.Repositories.Interfaces;
using MawhibaBridge.DataAccess.UnitOfWork.Interfaces;
using MawhibaBridge.DataContext.Context;
using MawhibaBridge.Entities.Models;

namespace MawhibaBridge.DataAccess.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _context;

        public UnitOfWork(DBContext context)
        {
            _context = context;
            AppUserRepository = new RepositoryBase<AppUser>(_context);
            CommentRepository = new RepositoryBase<Comment>(_context);
            CourseRepository = new RepositoryBase<Course>(_context);
            CourseTypeRepository = new RepositoryBase<CourseType>(_context);
            EnrollmentRepository = new RepositoryBase<Enrollment>(_context);
            InstructorRepository = new RepositoryBase<Instructor>(_context);
            ReplyRepository = new RepositoryBase<Reply>(_context);
            SectionRepository = new RepositoryBase<Section>(_context);
            SectionSeenRepository = new RepositoryBase<SectionSeen>(_context);
        }

        public IRepositoryBase<AppUser> AppUserRepository { get; private set; }
        public IRepositoryBase<Comment> CommentRepository { get; private set; }
        public IRepositoryBase<Course> CourseRepository { get; private set; }
        public IRepositoryBase<CourseType> CourseTypeRepository { get; private set; }
        public IRepositoryBase<Enrollment> EnrollmentRepository { get; private set; }
        public IRepositoryBase<Instructor> InstructorRepository { get; private set; }
        public IRepositoryBase<Reply> ReplyRepository { get; private set; }
        public IRepositoryBase<Section> SectionRepository { get; private set; }
        public IRepositoryBase<SectionSeen> SectionSeenRepository { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
