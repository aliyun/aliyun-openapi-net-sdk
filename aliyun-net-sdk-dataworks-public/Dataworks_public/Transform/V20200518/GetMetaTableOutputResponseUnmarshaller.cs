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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaTableOutputResponseUnmarshaller
    {
        public static GetMetaTableOutputResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableOutputResponse getMetaTableOutputResponse = new GetMetaTableOutputResponse();

			getMetaTableOutputResponse.HttpResponse = context.HttpResponse;
			getMetaTableOutputResponse.RequestId = context.StringValue("GetMetaTableOutput.RequestId");
			getMetaTableOutputResponse.ErrorCode = context.StringValue("GetMetaTableOutput.ErrorCode");
			getMetaTableOutputResponse.ErrorMessage = context.StringValue("GetMetaTableOutput.ErrorMessage");
			getMetaTableOutputResponse.HttpStatusCode = context.IntegerValue("GetMetaTableOutput.HttpStatusCode");
			getMetaTableOutputResponse.Success = context.BooleanValue("GetMetaTableOutput.Success");

			GetMetaTableOutputResponse.GetMetaTableOutput_Data data = new GetMetaTableOutputResponse.GetMetaTableOutput_Data();
			data.PageNumber = context.IntegerValue("GetMetaTableOutput.Data.PageNumber");
			data.PageSize = context.IntegerValue("GetMetaTableOutput.Data.PageSize");
			data.TotalCount = context.LongValue("GetMetaTableOutput.Data.TotalCount");

			List<GetMetaTableOutputResponse.GetMetaTableOutput_Data.GetMetaTableOutput_DataEntityListItem> data_dataEntityList = new List<GetMetaTableOutputResponse.GetMetaTableOutput_Data.GetMetaTableOutput_DataEntityListItem>();
			for (int i = 0; i < context.Length("GetMetaTableOutput.Data.DataEntityList.Length"); i++) {
				GetMetaTableOutputResponse.GetMetaTableOutput_Data.GetMetaTableOutput_DataEntityListItem dataEntityListItem = new GetMetaTableOutputResponse.GetMetaTableOutput_Data.GetMetaTableOutput_DataEntityListItem();
				dataEntityListItem.TableGuid = context.StringValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].TableGuid");
				dataEntityListItem.TaskId = context.StringValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].TaskId");
				dataEntityListItem.StartTime = context.StringValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].StartTime");
				dataEntityListItem.EndTime = context.StringValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].EndTime");
				dataEntityListItem.WaitTime = context.StringValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].WaitTime");
				dataEntityListItem.ProjectId = context.LongValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].ProjectId");
				dataEntityListItem.TaskInstanceId = context.LongValue("GetMetaTableOutput.Data.DataEntityList["+ i +"].TaskInstanceId");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaTableOutputResponse.Data = data;
        
			return getMetaTableOutputResponse;
        }
    }
}
