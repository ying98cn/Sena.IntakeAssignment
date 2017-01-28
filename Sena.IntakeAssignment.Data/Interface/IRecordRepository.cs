using Sena.IntakeAssignment.Data.Model;
using System.Collections.Generic;

namespace Sena.IntakeAssignment.Data.Interface
{
    public interface IRecordRepository
    {
        /// <summary>
        /// Fetches reocrod list.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Record> FetchRecordList();

        /// <summary>
        /// Updates record.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        Record Update(Record record);

        /// <summary>
        /// Adds a new record.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        bool Add(Record record);

        /// <summary>
        /// Deletes an existing record.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        bool Delete(Record record);

    }
}
