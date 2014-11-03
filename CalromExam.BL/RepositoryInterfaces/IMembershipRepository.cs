using System.Collections.Generic;

namespace CalromExam.BL.RepositoryInterfaces
{
    public interface IMembershipRepository
    {
        List<MembershipEntity> MembershipEntities { get; }
    }
}
