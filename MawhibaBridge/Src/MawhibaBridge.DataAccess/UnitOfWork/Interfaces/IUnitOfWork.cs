using MawhibaBridge.DataAccess.Repositories.Implementations;
using MawhibaBridge.Entities.Models;

namespace MawhibaBridge.DataAccess.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositoryBase<AppUser> AppUserRepository { get; }
        IRepositoryBase<Comment> CommentRepository { get; }
        IRepositoryBase<Course> CourseRepository { get; }
        IRepositoryBase<CourseType> CourseTypeRepository { get; }
        IRepositoryBase<Enrollment> EnrollmentRepository { get; }
        IRepositoryBase<Instructor> InstructorRepository { get; }
        IRepositoryBase<Reply> ReplyRepository { get; }
        IRepositoryBase<Section> SectionRepository { get; }
        IRepositoryBase<SectionSeen> SectionSeenRepository { get; }

        Task<int> CompleteAsync();
    }
}
