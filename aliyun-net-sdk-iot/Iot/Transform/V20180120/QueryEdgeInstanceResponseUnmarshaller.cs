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
    public class QueryEdgeInstanceResponseUnmarshaller
    {
        public static QueryEdgeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeInstanceResponse queryEdgeInstanceResponse = new QueryEdgeInstanceResponse();

			queryEdgeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeInstanceResponse.RequestId = _ctx.StringValue("QueryEdgeInstance.RequestId");
			queryEdgeInstanceResponse.Success = _ctx.BooleanValue("QueryEdgeInstance.Success");
			queryEdgeInstanceResponse.Code = _ctx.StringValue("QueryEdgeInstance.Code");
			queryEdgeInstanceResponse.ErrorMessage = _ctx.StringValue("QueryEdgeInstance.ErrorMessage");

			QueryEdgeInstanceResponse.QueryEdgeInstance_Data data = new QueryEdgeInstanceResponse.QueryEdgeInstance_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeInstance.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeInstance.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeInstance.Data.CurrentPage");

			List<QueryEdgeInstanceResponse.QueryEdgeInstance_Data.QueryEdgeInstance_Instance> data_instanceList = new List<QueryEdgeInstanceResponse.QueryEdgeInstance_Data.QueryEdgeInstance_Instance>();
			for (int i = 0; i < _ctx.Length("QueryEdgeInstance.Data.InstanceList.Length"); i++) {
				QueryEdgeInstanceResponse.QueryEdgeInstance_Data.QueryEdgeInstance_Instance instance = new QueryEdgeInstanceResponse.QueryEdgeInstance_Data.QueryEdgeInstance_Instance();
				instance.InstanceId = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].InstanceId");
				instance.Name = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].Name");
				instance.Tags = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].Tags");
				instance.Type = _ctx.IntegerValue("QueryEdgeInstance.Data.InstanceList["+ i +"].Type");
				instance.GmtCreate = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].GmtCreate");
				instance.GmtModified = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].GmtModified");
				instance.RoleArn = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].RoleArn");
				instance.RoleName = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].RoleName");
				instance.RoleAttachTime = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].RoleAttachTime");
				instance.Spec = _ctx.IntegerValue("QueryEdgeInstance.Data.InstanceList["+ i +"].Spec");
				instance.BizEnable = _ctx.BooleanValue("QueryEdgeInstance.Data.InstanceList["+ i +"].BizEnable");
				instance.LatestDeploymentStatus = _ctx.IntegerValue("QueryEdgeInstance.Data.InstanceList["+ i +"].LatestDeploymentStatus");
				instance.LatestDeploymentType = _ctx.StringValue("QueryEdgeInstance.Data.InstanceList["+ i +"].LatestDeploymentType");
				instance.GmtCreateTimestamp = _ctx.LongValue("QueryEdgeInstance.Data.InstanceList["+ i +"].GmtCreateTimestamp");
				instance.GmtModifiedTimestamp = _ctx.LongValue("QueryEdgeInstance.Data.InstanceList["+ i +"].GmtModifiedTimestamp");
				instance.RoleAttachTimestamp = _ctx.LongValue("QueryEdgeInstance.Data.InstanceList["+ i +"].RoleAttachTimestamp");

				data_instanceList.Add(instance);
			}
			data.InstanceList = data_instanceList;
			queryEdgeInstanceResponse.Data = data;
        
			return queryEdgeInstanceResponse;
        }
    }
}
