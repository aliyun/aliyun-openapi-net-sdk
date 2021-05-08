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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListJobResponseUnmarshaller
    {
        public static ListJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobResponse listJobResponse = new ListJobResponse();

			listJobResponse.HttpResponse = _ctx.HttpResponse;
			listJobResponse.RequestId = _ctx.StringValue("ListJob.RequestId");
			listJobResponse.Success = _ctx.BooleanValue("ListJob.Success");
			listJobResponse.Code = _ctx.StringValue("ListJob.Code");
			listJobResponse.ErrorMessage = _ctx.StringValue("ListJob.ErrorMessage");
			listJobResponse.Total = _ctx.IntegerValue("ListJob.Total");
			listJobResponse.PageSize = _ctx.IntegerValue("ListJob.PageSize");
			listJobResponse.Page = _ctx.IntegerValue("ListJob.Page");

			List<ListJobResponse.ListJob_DataItem> listJobResponse_data = new List<ListJobResponse.ListJob_DataItem>();
			for (int i = 0; i < _ctx.Length("ListJob.Data.Length"); i++) {
				ListJobResponse.ListJob_DataItem dataItem = new ListJobResponse.ListJob_DataItem();
				dataItem.JobId = _ctx.StringValue("ListJob.Data["+ i +"].JobId");
				dataItem.JobName = _ctx.StringValue("ListJob.Data["+ i +"].JobName");
				dataItem.UtcCreate = _ctx.StringValue("ListJob.Data["+ i +"].UtcCreate");
				dataItem.UtcModified = _ctx.StringValue("ListJob.Data["+ i +"].UtcModified");
				dataItem.Status = _ctx.StringValue("ListJob.Data["+ i +"].Status");
				dataItem.Description = _ctx.StringValue("ListJob.Data["+ i +"].Description");
				dataItem.Type = _ctx.StringValue("ListJob.Data["+ i +"].Type");
				dataItem.ScheduledTime = _ctx.LongValue("ListJob.Data["+ i +"].ScheduledTime");

				listJobResponse_data.Add(dataItem);
			}
			listJobResponse.Data = listJobResponse_data;
        
			return listJobResponse;
        }
    }
}
