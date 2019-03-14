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
        public static ListClusterServiceConfigHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterServiceConfigHistoryResponse listClusterServiceConfigHistoryResponse = new ListClusterServiceConfigHistoryResponse();

			listClusterServiceConfigHistoryResponse.HttpResponse = context.HttpResponse;
			listClusterServiceConfigHistoryResponse.RequestId = context.StringValue("ListClusterServiceConfigHistory.RequestId");
			listClusterServiceConfigHistoryResponse.TotalCount = context.IntegerValue("ListClusterServiceConfigHistory.TotalCount");
			listClusterServiceConfigHistoryResponse.PageNumber = context.IntegerValue("ListClusterServiceConfigHistory.PageNumber");
			listClusterServiceConfigHistoryResponse.PageSize = context.IntegerValue("ListClusterServiceConfigHistory.PageSize");

			List<ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory> listClusterServiceConfigHistoryResponse_configHistoryList = new List<ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory>();
			for (int i = 0; i < context.Length("ListClusterServiceConfigHistory.ConfigHistoryList.Length"); i++) {
				ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory configHistory = new ListClusterServiceConfigHistoryResponse.ListClusterServiceConfigHistory_ConfigHistory();
				configHistory.ServiceName = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ServiceName");
				configHistory.ConfigVersion = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ConfigVersion");
				configHistory.ConfigFileName = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ConfigFileName");
				configHistory.ConfigItemName = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].ConfigItemName");
				configHistory.NewValue = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].NewValue");
				configHistory.OldValue = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].OldValue");
				configHistory.Applied = context.BooleanValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].Applied");
				configHistory.CreateTime = context.LongValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].CreateTime");
				configHistory.Author = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].Author");
				configHistory.Comment = context.StringValue("ListClusterServiceConfigHistory.ConfigHistoryList["+ i +"].Comment");

				listClusterServiceConfigHistoryResponse_configHistoryList.Add(configHistory);
			}
			listClusterServiceConfigHistoryResponse.ConfigHistoryList = listClusterServiceConfigHistoryResponse_configHistoryList;
        
			return listClusterServiceConfigHistoryResponse;
        }
    }
}
