﻿namespace Jinget.Core.Types
{
    public class ResponseResult<TResponseModel>
        where TResponseModel : new()
    {
        private static ResponseResult<TResponseModel>? _instance;
        public static ResponseResult<TResponseModel> Empty => _instance ??= new ResponseResult<TResponseModel>();
        public long EffectedRowsCount { get; }

        public TResponseModel Data { get; }

        public ResponseResult() { Data = new TResponseModel(); }

        public ResponseResult(TResponseModel data) : this() => Data = data;

        public ResponseResult(TResponseModel data, long effectedRowsCount) : this(data) => EffectedRowsCount = effectedRowsCount;
    }
}
