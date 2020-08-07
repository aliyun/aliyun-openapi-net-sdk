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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindInstanceNodeListResponseUnmarshaller
    {
        public static FindInstanceNodeListResponse Unmarshall(UnmarshallerContext context)
        {
			FindInstanceNodeListResponse findInstanceNodeListResponse = new FindInstanceNodeListResponse();

			findInstanceNodeListResponse.HttpResponse = context.HttpResponse;
			findInstanceNodeListResponse.Code = context.IntegerValue("FindInstanceNodeList.Code");
			findInstanceNodeListResponse.Message = context.StringValue("FindInstanceNodeList.Message");
			findInstanceNodeListResponse.RequestId = context.StringValue("FindInstanceNodeList.RequestId");

			FindInstanceNodeListResponse.FindInstanceNodeList_Data data = new FindInstanceNodeListResponse.FindInstanceNodeList_Data();
			data.CurrentPage = context.IntegerValue("FindInstanceNodeList.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindInstanceNodeList.Data.PageNumber");

			List<FindInstanceNodeListResponse.FindInstanceNodeList_Data.FindInstanceNodeList_InstanceNode> data_instanceNodeList = new List<FindInstanceNodeListResponse.FindInstanceNodeList_Data.FindInstanceNodeList_InstanceNode>();
			for (int i = 0; i < context.Length("FindInstanceNodeList.Data.InstanceNodeList.Length"); i++) {
				FindInstanceNodeListResponse.FindInstanceNodeList_Data.FindInstanceNodeList_InstanceNode instanceNode = new FindInstanceNodeListResponse.FindInstanceNodeList_Data.FindInstanceNodeList_InstanceNode();
				instanceNode.Id = context.LongValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].Id");
				instanceNode.InstanceName = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].InstanceName");
				instanceNode.IsImported = context.BooleanValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].IsImported");
				instanceNode.GroupAddress = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].GroupAddress");
				instanceNode.BrokerAddress = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].BrokerAddress");
				instanceNode.EdasTenantInfo = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].EdasTenantInfo");
				instanceNode.ImportedName = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].ImportedName");
				instanceNode.CsbId = context.LongValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].CsbId");
				instanceNode.Deleted = context.IntegerValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].Deleted");
				instanceNode.OwnerId = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].OwnerId");
				instanceNode.BrokerCmdAddress = context.StringValue("FindInstanceNodeList.Data.InstanceNodeList["+ i +"].BrokerCmdAddress");

				data_instanceNodeList.Add(instanceNode);
			}
			data.InstanceNodeList = data_instanceNodeList;
			findInstanceNodeListResponse.Data = data;
        
			return findInstanceNodeListResponse;
        }
    }
}
