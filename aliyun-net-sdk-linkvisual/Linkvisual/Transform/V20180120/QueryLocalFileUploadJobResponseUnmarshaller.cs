/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryLocalFileUploadJobResponseUnmarshaller
    {
        public static QueryLocalFileUploadJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryLocalFileUploadJobResponse queryLocalFileUploadJobResponse = new QueryLocalFileUploadJobResponse();

			queryLocalFileUploadJobResponse.HttpResponse = _ctx.HttpResponse;
			queryLocalFileUploadJobResponse.Code = _ctx.StringValue("QueryLocalFileUploadJob.Code");
			queryLocalFileUploadJobResponse.ErrorMessage = _ctx.StringValue("QueryLocalFileUploadJob.ErrorMessage");
			queryLocalFileUploadJobResponse.RequestId = _ctx.StringValue("QueryLocalFileUploadJob.RequestId");
			queryLocalFileUploadJobResponse.Success = _ctx.BooleanValue("QueryLocalFileUploadJob.Success");

			QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data data = new QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data();
			data.Status = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.Status");

			List<QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem> data_resultList = new List<QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem>();
			for (int i = 0; i < _ctx.Length("QueryLocalFileUploadJob.Data.ResultList.Length"); i++) {
				QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem resultListItem = new QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem();
				resultListItem.SlotEndTime = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].SlotEndTime");
				resultListItem.ProductKey = _ctx.StringValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].ProductKey");
				resultListItem.DeviceName = _ctx.StringValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].DeviceName");
				resultListItem.SlotStartTime = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].SlotStartTime");
				resultListItem.Code = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].Code");
				resultListItem.SlotStatus = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].SlotStatus");
				resultListItem.IotId = _ctx.StringValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].IotId");

				List<QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem.QueryLocalFileUploadJob_FileListItem> resultListItem_fileList = new List<QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem.QueryLocalFileUploadJob_FileListItem>();
				for (int j = 0; j < _ctx.Length("QueryLocalFileUploadJob.Data.ResultList["+ i +"].FileList.Length"); j++) {
					QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem.QueryLocalFileUploadJob_FileListItem fileListItem = new QueryLocalFileUploadJobResponse.QueryLocalFileUploadJob_Data.QueryLocalFileUploadJob_ResultListItem.QueryLocalFileUploadJob_FileListItem();
					fileListItem.FileName = _ctx.StringValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].FileList["+ j +"].FileName");
					fileListItem.FileStartTime = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].FileList["+ j +"].FileStartTime");
					fileListItem.FileEndTime = _ctx.IntegerValue("QueryLocalFileUploadJob.Data.ResultList["+ i +"].FileList["+ j +"].FileEndTime");

					resultListItem_fileList.Add(fileListItem);
				}
				resultListItem.FileList = resultListItem_fileList;

				data_resultList.Add(resultListItem);
			}
			data.ResultList = data_resultList;
			queryLocalFileUploadJobResponse.Data = data;
        
			return queryLocalFileUploadJobResponse;
        }
    }
}
