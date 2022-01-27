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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class ListInstanceServiceConfigHistoriesResponseUnmarshaller
    {
        public static ListInstanceServiceConfigHistoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceServiceConfigHistoriesResponse listInstanceServiceConfigHistoriesResponse = new ListInstanceServiceConfigHistoriesResponse();

			listInstanceServiceConfigHistoriesResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceServiceConfigHistoriesResponse.RequestId = _ctx.StringValue("ListInstanceServiceConfigHistories.RequestId");
			listInstanceServiceConfigHistoriesResponse.PageNumber = _ctx.IntegerValue("ListInstanceServiceConfigHistories.PageNumber");
			listInstanceServiceConfigHistoriesResponse.PageRecordCount = _ctx.IntegerValue("ListInstanceServiceConfigHistories.PageRecordCount");
			listInstanceServiceConfigHistoriesResponse.TotalRecordCount = _ctx.LongValue("ListInstanceServiceConfigHistories.TotalRecordCount");

			List<ListInstanceServiceConfigHistoriesResponse.ListInstanceServiceConfigHistories_Config> listInstanceServiceConfigHistoriesResponse_configureHistoryList = new List<ListInstanceServiceConfigHistoriesResponse.ListInstanceServiceConfigHistories_Config>();
			for (int i = 0; i < _ctx.Length("ListInstanceServiceConfigHistories.ConfigureHistoryList.Length"); i++) {
				ListInstanceServiceConfigHistoriesResponse.ListInstanceServiceConfigHistories_Config config = new ListInstanceServiceConfigHistoriesResponse.ListInstanceServiceConfigHistories_Config();
				config.ConfigureName = _ctx.StringValue("ListInstanceServiceConfigHistories.ConfigureHistoryList["+ i +"].ConfigureName");
				config.OldValue = _ctx.StringValue("ListInstanceServiceConfigHistories.ConfigureHistoryList["+ i +"].OldValue");
				config.NewValue = _ctx.StringValue("ListInstanceServiceConfigHistories.ConfigureHistoryList["+ i +"].NewValue");
				config.Effective = _ctx.StringValue("ListInstanceServiceConfigHistories.ConfigureHistoryList["+ i +"].Effective");
				config.CreateTime = _ctx.StringValue("ListInstanceServiceConfigHistories.ConfigureHistoryList["+ i +"].CreateTime");

				listInstanceServiceConfigHistoriesResponse_configureHistoryList.Add(config);
			}
			listInstanceServiceConfigHistoriesResponse.ConfigureHistoryList = listInstanceServiceConfigHistoriesResponse_configureHistoryList;
        
			return listInstanceServiceConfigHistoriesResponse;
        }
    }
}
