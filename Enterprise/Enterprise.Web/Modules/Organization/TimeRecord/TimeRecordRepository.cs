
namespace Enterprise.Organization.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.TimeRecordRow;
    using Entities;

    public class TimeRecordRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> {
            protected override void BeforeSave()
            {
                Row.SyncTimesForSaving();
                Row.InsertDate = DateTime.UtcNow;
                Row.InsertUserId = Convert.ToInt64(LoggedIn.User.Id);
                base.BeforeSave();
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> {
            protected override void OnReturn()
            {
                base.OnReturn();
                Row.SyncTimesForDisplaying();
            }
        }
        private class MyListHandler : ListRequestHandler<MyRow> {
            protected override MyRow ProcessEntity(MyRow row)
            {
                row.SyncTimesForDisplaying();
                return base.ProcessEntity(row);
            }
        }
    }
}