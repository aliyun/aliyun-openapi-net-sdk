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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListClusterServiceConfigHistoryResponseUnmarshaller
    {
        public static ListClusterServiceConfigHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterServiceConfigHistoryResponse listClusterServiceConfigHistoryResponse = new ListClusterServiceConfigHistoryResponse();

			listClusterServiceConfigHistoryResponse.HttpResponse = _ctx.HttpResponse;
			listClusterServiceConfigHistoryResponse.RequestId = _ctx.StringValue("ListClusterServiceConfigHistory.RequestId");
			listClusterServiceConfigHistoryResponse.TotalCount = _ctx.IntegerValue("ListClusterServiceConfigHistory.TotalCount");
			listClusterServiceConfigHistoryResponse.PageNumber = _ctx.IntegerValue("ListClusterServiceConfigHistory.PageNumber");
			listClusterServiceConfigHistoryResponse.PageSize = _ctx.IntegerValue("ListClusterServiceConfigHistory.PageSize");

			List<ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory> listClusterServiceConfigHistoryResponse_configHistoryList = new List<ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory>();
			for (int i = 0; i < _ctx.Length("ListClusterServiceConfigHistory.ConfigHistoryList.Length"); i++) {
				ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory configHistory = new ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory();
				configHistory.ServiceName = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ServiceName");
				configHistory.ConfigVersion = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ConfigVersion");
				configHistory.ConfigFileName = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ConfigFileName");
				configHistory.ConfigItemName = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ConfigItemName");
				configHistory.NewValue = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].NewValue");
				configHistory.OldValue = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].OldValue");
				configHistory.Applied = _ctx.BooleanValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].Applied");
				configHistory.CreateTime = _ctx.LongValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].CreateTime");
				configHistory.Author = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].Author");
				configHistory.Comment = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].Comment");
				configHistory.HostGroupId = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].HostGroupId");
				configHistory.HostGroupName = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].HostGroupName");
				configHistory.HostInstanceId = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].HostInstanceId");
				configHistory.HostName = _ctx.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].HostName");

				listClusterServiceConfigHistoryResponse_configHistoryList.Add(configHistory);
			}
			listClusterServiceConfigHistoryResponse.ConfigHistoryList = listClusterServiceConfigHistoryResponse_configHistoryList;
        
			return listClusterServiceConfigHistoryResponse;
        }
    }
}
